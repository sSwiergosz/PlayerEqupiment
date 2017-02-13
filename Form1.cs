using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PlayerEq.Properties;

namespace PlayerEq
{
    public partial class Form1 : Form
    {
        public List<Character> CharactersList = new List<Character>(); //tworzenie listy wszystkich postaci

        private Form2 _form2;
        private Form3 _form3;
        public List<Item> ItemsList = new List<Item>(); //tworzenie listy wszystkich itemow
        public List<string> Read = new List<string>();

        //zmienne pomocnicze do obliczania atrybutow postci po otrzymaniu bonusu
        public double TempBonusStrength;
        public double TempBonusDefence;
        public double TempBonusMagic;

        //zmienne pomocnicze do blokowania mozliwosci zaklozenia kolejnego itemu
        public bool HasHelmet = false;
        public bool HasArmor = false;
        public bool HasWand = false;
        public bool HasSword = false;

        public int CharId = 0;
        public int ItemId = 0;

        //pomocnicze listy pomagajace w zapisie gotowej postaci
        public List<string> TempString = new List<string>();
        public List<string> TempString2 = new List<string>();

        public Form1()
        {
            InitializeComponent();
            readCh("char1.txt");
            readCh("char2.txt");
            readCh("char3.txt");
            readCh("char4.txt");
            readCh("char5.txt");

            if (_form3 == null)
                _form3 = new Form3(this);

            _form3.readIt("item1.txt");
            _form3.readIt("item2.txt");
            _form3.readIt("item3.txt");
            _form3.readIt("item4.txt");
            _form3.readIt("item5.txt");
            _form3.readIt("item6.txt");
            _form3.readIt("item7.txt");
            _form3.readIt("item8.txt");
            _form3.readIt("item9.txt");
            _form3.readIt("item10.txt");
        }

        public Form1(Form2 form2)
        {
            InitializeComponent();
            _form2 = form2;
        }

        public Form1(Form3 form3)
        {
            InitializeComponent();
            _form3 = form3;
        }

        private void CharacterWindowOpen(object sender, EventArgs e)
        {
            if (_form2 == null)
                _form2 = new Form2(this);
            _form2.Show();

            //inicjalizacja domyslnymi wartosciami
            _form2.cCharClassBox.Items.Add("Warrior");
            _form2.cCharClassBox.Items.Add("Mag");
            _form2.cCharClassBox.Items.Add("Thief");
            _form2.cCharStrengthBox.Text = @"10";
            _form2.cCharDefenceBox.Text = @"10";
            _form2.cCharMagicBox.Text = @"5";
            _form2.cCharCapacityBox.Text = @"5";
        }

        //funkcja wypelniajaca textboxy wczytanymi wartosciami z listy
        private void FillTextboxes()
        {
            var i = characterBox.SelectedIndex;

            nameBox.Text = CharactersList[i].Name;
            levelBox.Text = CharactersList[i].Level.ToString();
            strengthBox.Text = CharactersList[i].Strength.ToString();
            defenceBox.Text = CharactersList[i].Defence.ToString();
            magicBox.Text = CharactersList[i].Magic.ToString();
            capacityBoxMax.Text = CharactersList[i].Capacity.ToString();
            capacityBox.Text = @"0";
            classBox.Text = CharactersList[i].ClassOption;
            descriptionBox.Text = CharactersList[i].Description;
        }

        //Funkcja sluzaca wypelnieniu textboxow po wyborze postaci
        private void CharacterChoice(object sender, EventArgs e)
        {
            if (_form2 == null)
                _form2 = new Form2(this);

            //index w ComboBoxie jest rowny indexowi na liscie
            var i = characterBox.SelectedIndex;

            FillTextboxes();

            _form2.cCharNameBox.Text = CharactersList[i].Name;
            _form2.cCharLevelBox.Text = CharactersList[i].Level.ToString();
            _form2.cCharStrengthBox.Text = CharactersList[i].Strength.ToString();
            _form2.cCharDefenceBox.Text = CharactersList[i].Defence.ToString();
            _form2.cCharMagicBox.Text = CharactersList[i].Magic.ToString();
            _form2.cCharCapacityBox.Text = CharactersList[i].Capacity.ToString();
            _form2.cCharClassBox.Text = CharactersList[i].ClassOption;
            _form2.cCharDescriptBox.Text = CharactersList[i].Description;

            usingItems.Items.Clear();
        }

        public void ClearTextBoxes()
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
            if (_form3 == null)
                _form3 = new Form3(this);
            _form3.Show();
        }

        private void SelectItem(object sender, EventArgs e)
        {
            var i = addingItemBox.SelectedIndex;

            //wyswietlanie wykresow dla 
            if (ItemsList[i].Type == "Sword")
            {
                chart1.Series["Before"].Points.AddXY("Strength", Convert.ToDouble(strengthBox.Text));
                chart1.Series["After"].Points.AddXY("Strength", Convert.ToDouble(strengthBox.Text) + ItemsList[i].Bonus);
            }
            else if (ItemsList[i].Type == "Wand")
            {
                chart1.Series["Before"].Points.AddXY("Magic", Convert.ToDouble(magicBox.Text));
                chart1.Series["After"].Points.AddXY("Strength", Convert.ToDouble(magicBox.Text) + ItemsList[i].Bonus);
            }
            else if (ItemsList[i].Type == "Armor" || ItemsList[i].Type == "Helmet")
            {
                chart1.Series["Before"].Points.AddXY("Defence", Convert.ToDouble(defenceBox.Text));
                chart1.Series["After"].Points.AddXY("Strength",Convert.ToDouble(defenceBox.Text) + 
                                                    ItemsList[i].Bonus);
                if (HasHelmet == true)
                {
                    return;
                }
            }

            MessageBox.Show("ID: " + ItemsList[i].ID + Environment.NewLine +
                            "Name: " + ItemsList[i].Name + Environment.NewLine +
                            "Type: " + ItemsList[i].Type + Environment.NewLine +
                            "Requirement: " + ItemsList[i].Requirements + Environment.NewLine +
                            "Bonus: " + ItemsList[i].Bonus + Environment.NewLine +
                            "Properties: " + ItemsList[i].Properties + Environment.NewLine +
                            "Weight: " + ItemsList[i].Weight);
        }

        //Dodawanie wybranych itemow listy w oknie postaci
        private void addItem_Click(object sender, EventArgs e)
        {
            var i = addingItemBox.SelectedIndex;
            var j = characterBox.SelectedIndex;

            //zabezpieczenie przed dodaniem niewlasciwego przedmiotu do postaci
            if (classBox.Text == ItemsList[i].Requirements || ItemsList[i].Requirements == "None")
            {
                var temp = int.Parse(capacityBox.Text) + ItemsList[i].Weight; //zmodyfikowany udzwig

                //zabezpieczenie przed przekroczeniem udzwigu postaci
                if (temp < Convert.ToDouble(capacityBoxMax.Text))
                {
                    //dodawanie bonusu po zalozeniu itemu
                    if (ItemsList[i].Type == "Sword")
                    {
                        if(HasSword == false)
                        {
                            TempBonusStrength += ItemsList[i].Bonus;
                            strengthBox.Text = (CharactersList[j].Strength + TempBonusStrength).ToString();
                            HasSword = true;
                        }
                        else
                        {
                            MessageBox.Show("Character cannot have more than 1 sword!");
                            return;
                        }
                    }
                    else if (ItemsList[i].Type == "Wand")
                    {
                        if (HasWand == false)
                        {
                            TempBonusMagic += ItemsList[i].Bonus;
                            magicBox.Text = (Convert.ToDouble(magicBox.Text.Split(' ')[0]) + TempBonusMagic).ToString();
                            HasWand = true;
                        }
                        else
                        {
                            MessageBox.Show("Character cannot have more than 1 wand!");
                            return;
                        }
                    }
                    else
                    {
                        if (ItemsList[i].Type == "Helmet")
                        {
                            if (HasHelmet == false)
                            {
                                TempBonusDefence += ItemsList[i].Bonus;
                                defenceBox.Text = (CharactersList[j].Defence + TempBonusDefence).ToString();
                                HasHelmet = true;
                            }
                            else
                            {
                                MessageBox.Show("Character cannot have more than 1 helmet!");
                                return;
                            }
                        }
                        if (ItemsList[i].Type == "Armor")
                        {
                            if (HasArmor == false)
                            {
                                TempBonusDefence += ItemsList[i].Bonus;
                                defenceBox.Text = (CharactersList[j].Defence + TempBonusDefence).ToString();
                                HasArmor = true;
                            }
                            else
                            {
                                MessageBox.Show("Character cannot have more than 1 armor!");
                                return;
                            }
                        }
                    }
                    MessageBox.Show("Item added to your character!");

                    capacityBox.Text = temp.ToString();
                    usingItems.Items.Add(ItemsList[i].Name);

                    //dodanie do listy zapisu wszystkich itemow obecnych na postaci
                    TempString.Add(ItemsList[i].Name);
                    TempString.Add(ItemsList[i].Type);
                    TempString.Add(ItemsList[i].Requirements);
                    TempString.Add(ItemsList[i].Bonus.ToString());
                    TempString.Add(ItemsList[i].Properties);
                    TempString.Add(ItemsList[i].Weight.ToString());
                    TempString.Add(ItemsList[i].Description);

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

            //czyszczenie wykresu
            foreach (var series in chart1.Series)
                series.Points.Clear();
        }

        private void saveCharItemsButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var name = saveFileDialog1.FileName; //nazwa pliku do zapisu

            //dodanie do listy zapisu wartosci postaci
            TempString2.Add(nameBox.Text);
            TempString2.Add(levelBox.Text);
            TempString2.Add(strengthBox.Text);
            TempString2.Add(defenceBox.Text);
            TempString2.Add(magicBox.Text);
            TempString2.Add(capacityBoxMax.Text);
            TempString2.Add(classBox.Text);
            TempString2.Add(descriptionBox.Text);

            //polaczenie postaci ze wszystkimi itemami postaci
            var allStringList = TempString2.Concat(TempString).ToList();

            File.WriteAllLines(name, allStringList);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {}

        private void readCh(string file)
        {
                try
                {
                    Read = File.ReadAllLines(file).ToList(); //wczytywanie z pliku linia po linii
                }
                catch (IOException)
                {
                    MessageBox.Show("Reading failed");
                }
           
            CharId++;
            var newCharacter = new Character(CharId, Read[0], int.Parse(Read[1]),
                Convert.ToDouble(Read[2]), Convert.ToDouble(Read[3]), int.Parse(Read[4]),
                Convert.ToDouble(Read[5]), Read[6], Read[7]);

            var lvl = int.Parse(Read[1]) * 20; //zwiekszanie wartosci bazowych
            newCharacter.GiveBonus(lvl);

            CharactersList.Add(newCharacter);
            characterBox.Items.Add(newCharacter.Name + ", level: " + newCharacter.Level + ", class: " +
                                    newCharacter.ClassOption);
            characterBox.SelectedIndex = characterBox.Items.Count - 1;
            Read.Clear();
        }

        private void readCharItemsButton_Click(object sender, EventArgs e)
        {
            if (_form3 == null)
                _form3 = new Form3(this);

            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                readCh(openFileDialog1.FileName);
            }

            //ostatni element listy postaci
            var i = CharactersList.Count - 1;

            nameBox.Text = CharactersList[i].Name;
            levelBox.Text = CharactersList[i].Level.ToString();
            strengthBox.Text = CharactersList[i].Strength.ToString();
            defenceBox.Text = CharactersList[i].Defence.ToString();
            magicBox.Text = CharactersList[i].Magic.ToString();
            capacityBoxMax.Text = CharactersList[i].Capacity.ToString();
            capacityBox.Text = @"0";
            classBox.Text = CharactersList[i].ClassOption;
            descriptionBox.Text = CharactersList[i].Description;

            var temp = new string[7];
            var counter = 0;
            var lastElement = Read.Last();

            //pierwsze 8 wersow zawsze bedzie nalezec do postaci
            //te atrybuty zostaly juz wczytane, wiec mozna je pominac
            foreach (var s in Read.Skip(8))
            {
                if (counter <= 6)
                {
                    temp[counter] = s;
                    counter++;
                }
                else
                {
                    ItemId++;
                    var newItem = new Item(ItemId, temp[0], temp[1], temp[2], int.Parse(temp[3]), temp[4], int.Parse(temp[5]),
                        temp[6]);
                    ItemsList.Add(newItem);
                    var j = ItemsList.Count - 1;
                    addingItemBox.Items.Add(ItemsList[ItemsList.Count - 1].Name);
                    _form3.selectedItemComboBox.Items.Add(newItem.Name);
                    capacityBox.Text = (int.Parse(capacityBox.Text) + ItemsList[j].Weight).ToString();
                    usingItems.Items.Add(newItem.Name);
                    Array.Clear(temp, 0, temp.Length);
                    temp[0] = s;
                    counter = 1;
                }

                if (s == lastElement)
                {
                    ItemId++;
                    var newItem = new Item(ItemId, temp[0], temp[1], temp[2], int.Parse(temp[3]), temp[4], int.Parse(temp[5]),
                        temp[6]);
                    ItemsList.Add(newItem);
                    var j = ItemsList.Count - 1;
                    addingItemBox.Items.Add(ItemsList[ItemsList.Count - 1].Name);
                    _form3.selectedItemComboBox.Items.Add(newItem.Name);
                    capacityBox.Text = (int.Parse(capacityBox.Text) + ItemsList[j].Weight).ToString();
                    usingItems.Items.Add(newItem.Name);
                    Array.Clear(temp, 0, temp.Length);
                }
            }
        }
    }
}