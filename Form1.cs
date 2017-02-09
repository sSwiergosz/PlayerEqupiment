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
using System.Text.RegularExpressions;

namespace PlayerEq
{
    public partial class Form1 : Form
    {
        public List<Character> charactersList = new List<Character>(); //tworzenie listy wszystkich postaci
        public List<Item> itemsList = new List<Item>(); //tworzenie listy wszystkich itemow

        public List<string> tempString = new List<string>();
        public List<string> tempString2 = new List<string>();
        public List<string> read = new List<string>();

        //zmienne pomocnicze do obliczania atrybutow postci po otrzymaniu bonusu
        public double tempBonusStrength = 0;
        public double tempBonusMagic = 0;
        public double tempBonusDefence = 0;

        private Form2 form2;
        private Form3 form3;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Form3 form3)
        {
            InitializeComponent();
            this.form3 = form3;
        }

        private void characterWindowOpen(object sender, EventArgs e)
        {
            if (form2 == null)
                form2 = new Form2(this);
            form2.Show();

            //inicjalizacja domyslnymi wartosciami
            form2.cCharClassBox.Items.Add("Warrior");
            form2.cCharClassBox.Items.Add("Mag");
            form2.cCharClassBox.Items.Add("Thief");
            form2.cCharStrengthBox.Text = "10";
            form2.cCharDefenceBox.Text = "10";
            form2.cCharMagicBox.Text = "5";
            form2.cCharCapacityBox.Text = "5";
        }

        //funkcja wypelniajaca textboxy wczytanymi wartosciami z listy
        private void fillTextboxes()
        {
            int i = characterBox.SelectedIndex;

            nameBox.Text = charactersList[i].Name;
            levelBox.Text = charactersList[i].Level.ToString();
            strengthBox.Text = charactersList[i].Strength.ToString();
            defenceBox.Text = charactersList[i].Defence.ToString();
            magicBox.Text = charactersList[i].Magic.ToString();
            capacityBoxMax.Text = charactersList[i].Capacity.ToString();
            capacityBox.Text = "0";
            classBox.Text = charactersList[i].ClassOption;
            descriptionBox.Text = charactersList[i].Description;
        }

        //Funkcja sluzaca wypelnieniu textboxow po wyborze postaci
        private void characterChoice(object sender, EventArgs e)
        {
            //index w ComboBoxie jest rowny indexowi na liscie
            int i = characterBox.SelectedIndex;

            fillTextboxes();

            form2.cCharNameBox.Text = charactersList[i].Name;
            form2.cCharLevelBox.Text = charactersList[i].Level.ToString();
            form2.cCharStrengthBox.Text = charactersList[i].Strength.ToString();
            form2.cCharDefenceBox.Text = charactersList[i].Defence.ToString();
            form2.cCharMagicBox.Text = charactersList[i].Magic.ToString();
            form2.cCharCapacityBox.Text = charactersList[i].Capacity.ToString();
            form2.cCharClassBox.Text = charactersList[i].ClassOption;
            form2.cCharDescriptBox.Text = charactersList[i].Description;

            usingItems.Items.Clear();
        }

        public void clearTextBoxes()
        {
            nameBox.Text = "";
            levelBox.Text = "";
            strengthBox.Text = "";
            defenceBox.Text = "";
            magicBox.Text = "";
            capacityBoxMax.Text = "";
            classBox.Text = "";
            descriptionBox.Text = "";
        }

        private void itemsWindowOpen_Click(object sender, EventArgs e)
        {
            if (form3 == null)
                form3 = new Form3(this);
            form3.Show();
        }

        private void selectItem(object sender, EventArgs e)
        {
            int i = addingItemBox.SelectedIndex;

            //wyswietlanie wykresow dla 
            if(itemsList[i].Type == "Sword")
            {
                this.chart1.Series["Before"].Points.AddXY("Strength", Convert.ToDouble(strengthBox.Text));
                this.chart1.Series["After"].Points.AddXY("Strength", Convert.ToDouble(strengthBox.Text) + itemsList[i].Bonus);
            }
            else if(itemsList[i].Type == "Armor")
            {
                this.chart1.Series["Before"].Points.AddXY("Defence", Convert.ToDouble(defenceBox.Text));
                this.chart1.Series["After"].Points.AddXY("Strength", Convert.ToDouble(defenceBox.Text) + itemsList[i].Bonus);
            }
            else if (itemsList[i].Type == "Wand")
            {
                this.chart1.Series["Before"].Points.AddXY("Magic", Convert.ToDouble(magicBox.Text));
                this.chart1.Series["After"].Points.AddXY("Strength", Convert.ToDouble(magicBox.Text) + itemsList[i].Bonus);
            }

            MessageBox.Show("Name: " + itemsList[i].Name + Environment.NewLine +
                "Type: " + itemsList[i].Type + Environment.NewLine + 
                "Requirement: " + itemsList[i].Requirements + Environment.NewLine +
                "Bonus: " + itemsList[i].Bonus + Environment.NewLine + 
                "Properties: " + itemsList[i].Properties + Environment.NewLine + 
                "Weight: " + itemsList[i].Weight);
        }

        //Dodawanie wybranych itemow listy w oknie postaci
        private void addItem_Click(object sender, EventArgs e)
        {
            int i = addingItemBox.SelectedIndex;
            int j = characterBox.SelectedIndex;

            if(classBox.Text == itemsList[i].Requirements || itemsList[i].Requirements == "None")
            {
                int temp = (int.Parse(capacityBox.Text) + itemsList[i].Weight); //zmodyfikowany udzwig

                //zabezpieczenie przed przekroczeniem udzwigu postaci
                if (temp < Convert.ToDouble(capacityBoxMax.Text))
                {
                    capacityBox.Text = temp.ToString();
                    usingItems.Items.Add(itemsList[i].Name);

                    //dodawanie bonusu po zalozeniu itemu
                    if(itemsList[i].Type == "Sword")
                    {
                        tempBonusStrength += itemsList[i].Bonus;
                        strengthBox.Text = (charactersList[j].Strength + tempBonusStrength).ToString();
                    }
                    else if(itemsList[i].Type == "Wand")
                    {
                        tempBonusMagic += itemsList[i].Bonus;
                        magicBox.Text = (Convert.ToDouble(magicBox.Text.Split(' ')[0]) + tempBonusMagic).ToString();
                    }
                    else
                    {
                        tempBonusDefence += itemsList[i].Bonus;
                        defenceBox.Text = (charactersList[j].Defence + tempBonusDefence).ToString();
                    }

                    //dodanie do listy zapisu wszystkich itemow obecnych na postaci
                    tempString.Add(itemsList[i].Name);
                    tempString.Add(itemsList[i].Type);
                    tempString.Add(itemsList[i].Requirements);
                    tempString.Add(itemsList[i].Bonus.ToString());
                    tempString.Add(itemsList[i].Properties);
                    tempString.Add(itemsList[i].Weight.ToString());
                    tempString.Add(itemsList[i].Description);

                }
                else
                {
                    MessageBox.Show("Capacity overrun!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Item not avaible for your character class");
                return;
            }

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
        }

        private void saveCharItemsButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string name = saveFileDialog1.FileName; //nazwa pliku do zapisu

            //dodanie do listy zapisu wartosci postaci
            tempString2.Add(nameBox.Text);
            tempString2.Add(levelBox.Text);
            tempString2.Add(strengthBox.Text.ToString());
            tempString2.Add(defenceBox.Text.ToString());
            tempString2.Add(magicBox.Text.ToString());
            tempString2.Add(capacityBoxMax.Text);
            tempString2.Add(classBox.Text);
            tempString2.Add(descriptionBox.Text);

            //polaczenie postaci ze wszystkimi itemami postaci
            var allStringList = tempString2.Concat(tempString).ToList();

            File.WriteAllLines(name, allStringList);

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) { }

        private void readCharItemsButton_Click(object sender, EventArgs e)
        {
            var result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = this.openFileDialog1.FileName;
                try
                {
                    read = File.ReadAllLines(file).ToList(); //wczytywanie z pliku linia po linii
                }
                catch (IOException) { }
            }

            var newCharacter = new Character(read[0], int.Parse(read[1]),
                Convert.ToDouble(read[2]), Convert.ToDouble(read[3]), int.Parse(read[4]),
                Convert.ToDouble(read[5]), read[6], read[7]);

            charactersList.Add(newCharacter);
            characterBox.Items.Add(newCharacter.Name + ", level: " + newCharacter.Level + ", klasa: " + read[7]);
            characterBox.SelectedIndex = characterBox.Items.Count - 1;

            //ostatni element listy postaci
            int i = charactersList.Count - 1;

            nameBox.Text = charactersList[i].Name;
            levelBox.Text = charactersList[i].Level.ToString();
            strengthBox.Text = charactersList[i].Strength.ToString();
            defenceBox.Text = charactersList[i].Defence.ToString();
            magicBox.Text = charactersList[i].Magic.ToString();
            capacityBoxMax.Text = charactersList[i].Capacity.ToString();
            capacityBox.Text = "0";
            classBox.Text = charactersList[i].ClassOption;
            descriptionBox.Text = charactersList[i].Description;

            var temp = new string[7];
            int counter = 0;

            string lastElement = read.Last();

            //pierwsze 8 wersow zawsze bedzie nalezec do postaci
            //te atrybuty zostaly juz wczytane, wiec mozna je pominac
            foreach (string s in read.Skip(8))
            {
                if (counter <= 6)
                {
                    temp[counter] = s;
                    counter++;
                }
                else
                {
                    var newItem = new Item(temp[0], temp[1], temp[2], int.Parse(temp[3]), temp[4], int.Parse(temp[5]), temp[6]);
                    itemsList.Add(newItem);
                    int j = itemsList.Count - 1;
                    addingItemBox.Items.Add(itemsList[itemsList.Count-1].Name);
                    form3.selectedItemComboBox.Items.Add(newItem.Name);
                    capacityBox.Text = (int.Parse(capacityBox.Text) + itemsList[j].Weight).ToString();
                    usingItems.Items.Add(newItem.Name);
                    Array.Clear(temp, 0, temp.Length);
                    temp[0] = s;
                    counter = 1;
                }

                if(s == lastElement)
                {
                    var newItem = new Item(temp[0], temp[1], temp[2], int.Parse(temp[3]), temp[4], int.Parse(temp[5]), temp[6]);
                    itemsList.Add(newItem);
                    int j = itemsList.Count - 1;
                    addingItemBox.Items.Add(itemsList[itemsList.Count - 1].Name);
                    form3.selectedItemComboBox.Items.Add(newItem.Name);
                    capacityBox.Text = (int.Parse(capacityBox.Text) + itemsList[j].Weight).ToString();
                    usingItems.Items.Add(newItem.Name);
                    Array.Clear(temp, 0, temp.Length);
                }
            }
        }
    }
}
