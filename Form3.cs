using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace PlayerEq
{
    public partial class Form3 : Form
    {
        private readonly Form1 _frm1;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form1 frm1)
        {
            InitializeComponent();
            _frm1 = frm1;

            itemReqBox.Items.Add("Mag");
            itemReqBox.Items.Add("Warrior");
            itemReqBox.Items.Add("Thief");

            itemTypeBox.Items.Add("Sword");
            itemTypeBox.Items.Add("Wand");
            itemTypeBox.Items.Add("Armor");
            itemTypeBox.Items.Add("Helmet");
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ukrywanie okna
            Hide();
            e.Cancel = true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void readItemButton_Click(object sender, EventArgs e)
        {
            var readItem = new string[6]; //do tej tablicy wczytujemy wartosci z pliku
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog1.FileName;
                try
                {
                    readItem = File.ReadAllLines(file); //wczytywanie z pliku linia po linii
                }
                catch (IOException)
                {
                }
            }

            //tworzenie obiektu klasy Item
            var newItem = new Item(readItem[0], readItem[1], readItem[2], int.Parse(readItem[3]),
                readItem[4], int.Parse(readItem[5]), readItem[6]);

            //dodawanie obiektu do listy wszystkich itemow
            _frm1.ItemsList.Add(newItem);

            //wyswietlanie itemow w comboboxie
            _frm1.addingItemBox.Items.Add(newItem.Name);
            selectedItemComboBox.Items.Add(newItem.Name);
        }

        //edycja itemu
        private void editItemButton_Click(object sender, EventArgs e)
        {
            var i = selectedItemComboBox.SelectedIndex;

            //edytowany item jest zdejmowany z postaci
            for (var j = 0; j < _frm1.usingItems.Items.Count; j++)
                if (_frm1.usingItems.Items[j].ToString() == _frm1.ItemsList[i].Name)
                {
                    _frm1.usingItems.Items.RemoveAt(j);
                    _frm1.capacityBox.Text = (_frm1.ItemsList[i].Weight - int.Parse(_frm1.capacityBox.Text)).ToString();
                    break;
                }

            _frm1.ItemsList[i].Name = eItemNameBox.Text;
            _frm1.ItemsList[i].Type = itemTypeBox.Text;
            _frm1.ItemsList[i].Requirements = itemReqBox.Text;
            _frm1.ItemsList[i].Bonus = int.Parse(eItemBonusBox.Text);
            _frm1.ItemsList[i].Properties = eItemPropBox.Text;
            _frm1.ItemsList[i].Weight = int.Parse(eItemWeightBox.Text);
            _frm1.ItemsList[i].Description = eItemDescBox.Text;

            selectedItemComboBox.Items.Add(_frm1.ItemsList[i].Name);
            selectedItemComboBox.Items.RemoveAt(i);

            _frm1.addingItemBox.Items.Add(_frm1.ItemsList[i].Name);
            _frm1.addingItemBox.Items.RemoveAt(i);
        }

        private void saveItemButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            var i = selectedItemComboBox.SelectedIndex;

            var name = saveFileDialog1.FileName; //nazwa pliku do zapisu
            File.WriteAllText(name, _frm1.ItemsList[i].Name + Environment.NewLine + _frm1.ItemsList[i].Requirements);
        }

        private void dItemButton_Click(object sender, EventArgs e)
        {
            var i = selectedItemComboBox.SelectedIndex;

            for (var j = 0; j < _frm1.usingItems.Items.Count; j++)
                if (_frm1.usingItems.Items[j].ToString() == _frm1.ItemsList[i].Name)
                {
                    _frm1.usingItems.Items.RemoveAt(j);
                    _frm1.capacityBox.Text = (int.Parse(_frm1.capacityBox.Text) - _frm1.ItemsList[i].Weight).ToString();
                    break;
                }

            if (_frm1.ItemsList[i].Type == "Sword")
            {
                _frm1.strengthBox.Text =
                    (Convert.ToDouble(_frm1.strengthBox.Text.Split(' ')[0]) - _frm1.ItemsList[i].Bonus).ToString();
                _frm1.TempBonusStrength = _frm1.TempBonusStrength - _frm1.ItemsList[i].Bonus;
                _frm1.HasSword = false;
            }
            else if (_frm1.ItemsList[i].Type == "Wand")
            {
                _frm1.magicBox.Text =
                    (Convert.ToDouble(_frm1.magicBox.Text.Split(' ')[0]) - _frm1.ItemsList[i].Bonus).ToString();
                _frm1.TempBonusMagic = _frm1.TempBonusMagic - _frm1.ItemsList[i].Bonus;
                _frm1.HasWand = false;
            }
            else
            {
                _frm1.defenceBox.Text =
                    (Convert.ToDouble(_frm1.defenceBox.Text.Split(' ')[0]) - _frm1.ItemsList[i].Bonus).ToString();
                _frm1.TempBonusDefence = _frm1.TempBonusDefence - _frm1.ItemsList[i].Bonus;

                if (_frm1.ItemsList[i].Type == "Armor")
                {
                    _frm1.HasArmor = false;
                }
                else
                {
                    _frm1.HasHelmet = false;
                }
            }

            _frm1.ItemsList.RemoveAt(i);
            selectedItemComboBox.Items.RemoveAt(i);
            selectedItemComboBox.Text = " ";

            _frm1.addingItemBox.Items.RemoveAt(i);
            _frm1.addingItemBox.Text = " ";
        }

        private void createItemButton_Click(object sender, EventArgs e)
        {
            var newItem = new Item(eItemNameBox.Text, itemTypeBox.Text, itemReqBox.Text, int.Parse(eItemBonusBox.Text),
                eItemPropBox.Text, int.Parse(eItemWeightBox.Text), eItemDescBox.Text);

            _frm1.ItemsList.Add(newItem);
            _frm1.addingItemBox.Items.Add(newItem.Name);
            selectedItemComboBox.Items.Add(newItem.Name);
        }
    }
}