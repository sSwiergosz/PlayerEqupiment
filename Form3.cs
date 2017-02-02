using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PlayerEq
{
    public partial class Form3 : Form
    {
        private readonly Form1 frm1;
        int id = 0;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form1 frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ukrywanie okna
            Hide();
            e.Cancel = true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) { }

        private void readItemButton_Click(object sender, EventArgs e)
        {
            var readItem = new string[6]; //do tej tablicy wczytujemy wartosci z pliku
            var result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = this.openFileDialog1.FileName;
                try
                {
                    readItem = File.ReadAllLines(file); //wczytywanie z pliku linia po linii
                }
                catch (IOException) { }
            }

            //tworzenie obiektu klasy Item
            id = id + 1;
            var newItem = new Item(readItem[0], readItem[1], readItem[2], int.Parse(readItem[3]),
                                    readItem[4], int.Parse(readItem[5]), readItem[6]);

            //dodawanie obiektu do listy wszystkich itemow
            frm1.itemsList.Add(newItem);

            //wyswietlanie itemow w comboboxie
            frm1.addingItemBox.Items.Add(newItem.Name);
            selectedItemComboBox.Items.Add(newItem.Name);
        }

        //edycja itemu
        private void editItemButton_Click(object sender, EventArgs e)
        {
            int i = selectedItemComboBox.SelectedIndex;

            //edytowany item jest zdejmowany z postaci
            for(int j=0; j < frm1.usingItems.Items.Count; j++)
            {
                if(frm1.usingItems.Items[j].ToString() == frm1.itemsList[i].Name)
                {
                    frm1.usingItems.Items.RemoveAt(j);
                    frm1.capacityBox.Text = (frm1.itemsList[i].Weight - int.Parse(frm1.capacityBox.Text)).ToString();
                    break;
                }
            }

            frm1.itemsList[i].Name = eItemNameBox.Text;
            frm1.itemsList[i].Type = eItemTypeBox.Text;
            frm1.itemsList[i].Requirements = eItemReqBox.Text;
            frm1.itemsList[i].Bonus = int.Parse(eItemBonusBox.Text);
            frm1.itemsList[i].Properties = eItemPropBox.Text;
            frm1.itemsList[i].Weight = int.Parse(eItemWeightBox.Text);
            frm1.itemsList[i].Description = eItemDescBox.Text;

            selectedItemComboBox.Items.Add(frm1.itemsList[i].Name);
            selectedItemComboBox.Items.RemoveAt(i);

            frm1.addingItemBox.Items.Add(frm1.itemsList[i].Name);
            frm1.addingItemBox.Items.RemoveAt(i);

        }

        private void saveItemButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            int i = selectedItemComboBox.SelectedIndex;

            string name = saveFileDialog1.FileName; //nazwa pliku do zapisu
            File.WriteAllText(name, frm1.itemsList[i].Name + Environment.NewLine + frm1.itemsList[i].Requirements);
        }

        private void dItemButton_Click(object sender, EventArgs e)
        {
            int i = selectedItemComboBox.SelectedIndex;

            for (int j = 0; j < frm1.usingItems.Items.Count; j++)
            {
                if (frm1.usingItems.Items[j].ToString() == frm1.itemsList[i].Name)
                {
                    frm1.usingItems.Items.RemoveAt(j);
                    frm1.capacityBox.Text = (int.Parse(frm1.capacityBox.Text) - frm1.itemsList[i].Weight).ToString();
                    break;
                }
            }

            frm1.itemsList.RemoveAt(i);
            selectedItemComboBox.Items.RemoveAt(i);
            selectedItemComboBox.Text = " ";

            frm1.addingItemBox.Items.RemoveAt(i);
            frm1.addingItemBox.Text = " ";
        }
    }
}
