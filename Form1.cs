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
    public partial class Form1 : Form
    {
        public List<Character> charactersList = new List<Character>(); //tworzenie listy wszystkich postaci
        public List<Item> itemsList = new List<Item>(); //tworzenie listy wszystkich itemow

        public List<string> tempString = new List<string>();
        public List<string> tempString2 = new List<string>();
        public List<string> read = new List<string>();

        private Form2 form2;
        private Form3 form3;

        private double strength_before;
        private double magic_before;
        private double defence_before;

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

            form2.comboBox1.Items.Add("Wojownik");
            form2.comboBox1.Items.Add("Mag");
            form2.comboBox1.Items.Add("Zlodziej");
            form2.textBox2.Text = "10";
            form2.textBox3.Text = "10";
            form2.textBox4.Text = "5";
            form2.textBox5.Text = "5";
        }

        private void characterChoice(object sender, EventArgs e)
        {   //wypelnienie textBoxow wartosciami z listy postaci
            //index w ComboBoxie jest rowny indexowi na liscie
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

        //Dodawanie wybranych itemow listy w oknie postaci
        private void addItem_Click(object sender, EventArgs e)
        {
            int i = addingItemBox.SelectedIndex;

            if(classBox.Text == itemsList[i].Requirements || itemsList[i].Requirements == "None")
            {
                int temp = (int.Parse(capacityBox.Text) + itemsList[i].Weight); //zmodyfikowana waga

                //zabezpieczenie przed przekroczeniem udzwigu postaci
                if (temp < Convert.ToDouble(capacityBoxMax.Text))
                {
                    capacityBox.Text = temp.ToString();
                    usingItems.Items.Add(itemsList[i].Name);

                    //dodawanie bonusu po zalozeniu itemu
                    if(itemsList[i].Type == "Miecz")
                    {
                        strength_before = Convert.ToDouble(strengthBox.Text);
                        strengthBox.Text = (Convert.ToDouble(strengthBox.Text) + itemsList[i].Bonus).ToString() 
                                            + " " + "(" + strengthBox.Text + " + " + itemsList[i].Bonus + ")";
                    }
                    else if(itemsList[i].Type == "Rozdzka")
                    {
                        magic_before = Convert.ToDouble(strengthBox.Text);
                        magicBox.Text = (Convert.ToDouble(magicBox.Text) + itemsList[i].Bonus).ToString()
                                            + " " + "(" + magicBox.Text + " + " + itemsList[i].Bonus + ")";
                    }
                    else
                    {
                        defence_before = Convert.ToDouble(strengthBox.Text);
                        defenceBox.Text = (Convert.ToDouble(defenceBox.Text) + itemsList[i].Bonus).ToString()
                                            + " " + "(" + defenceBox.Text + " + " + itemsList[i].Bonus + ")";
                    }

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
        }

        private void saveCharItemsButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string name = saveFileDialog1.FileName; //nazwa pliku do zapisu

            tempString2.Add(nameBox.Text);
            tempString2.Add(levelBox.Text);
            tempString2.Add(strength_before.ToString());
            tempString2.Add(defence_before.ToString());
            tempString2.Add(magic_before.ToString());
            tempString2.Add(capacityBox.Text);
            tempString2.Add(classBox.Text);
            tempString2.Add(descriptionBox.Text);

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
            
            foreach (string s in read.Skip(8))
            {
                if (counter != 7)
                {
                    temp[counter] = s;
                    counter++;
                }
                else
                {
                    var newItem = new Item(temp[0], temp[1], temp[2], int.Parse(temp[3]), temp[4], int.Parse(temp[5]), temp[6]);
                    itemsList.Add(newItem);
                    int j = itemsList.Count - 1;
                    addingItemBox.Items.Add(newItem.Name);
                    form3.selectedItemComboBox.Items.Add(newItem.Name);
                    capacityBox.Text = (int.Parse(capacityBox.Text) + itemsList[j].Weight).ToString();
                    counter = 0;
                    Array.Clear(temp, 0, temp.Length);
                }
            }


            
            

            

            



        }
    }
}
