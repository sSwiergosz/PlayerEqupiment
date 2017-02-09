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
    public partial class Form2 : Form
    {
        private readonly Form1 frm1;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ukrywanie okna
            Hide();
            e.Cancel = true;
        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e) { }

        private void readButton_Click(object sender, EventArgs e)
        {
            var read = new string[8]; //do tej tablicy wczytujemy wartosci z pliku
            var result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = this.openFileDialog1.FileName;
                try
                {
                    read = File.ReadAllLines(file); //wczytywanie z pliku linia po linii
                }
                catch (IOException) { }
            }

            //tworzenie obiektu klasy Character
            var newCharacter = new Character(read[0], int.Parse(read[1]),
                Convert.ToDouble(read[2]), Convert.ToDouble(read[3]), int.Parse(read[4]),
                Convert.ToDouble(read[5]), read[6], read[7]);

            double lvl = int.Parse(read[2]) * 1.05; //zwiekszanie wartosci bazowych - 5% co lvl
            newCharacter.GiveBonus(lvl);

            //dodawanie stworzonej postaci do listy wszystkich postaci
            frm1.charactersList.Add(newCharacter);

            //dodawanie postaci do comboboxa w Form1
            frm1.characterBox.Items.Add(newCharacter.Name + ", level: " + newCharacter.Level + ", klasa: " + read[7]);

            //Domyslne wybranie z comboboxa ostatniego wczytanego obiektu
            frm1.characterBox.SelectedIndex = frm1.characterBox.Items.Count - 1;
        }

        private void eCharacterButton_Click(object sender, EventArgs e)
        {
            int i = frm1.characterBox.SelectedIndex;

            frm1.charactersList[i].Name = cCharNameBox.Text;
            frm1.charactersList[i].Level = int.Parse(cCharLevelBox.Text);
            frm1.charactersList[i].Strength = int.Parse(cCharStrengthBox.Text);
            frm1.charactersList[i].Defence = int.Parse(cCharDefenceBox.Text);
            frm1.charactersList[i].Magic = int.Parse(cCharMagicBox.Text);
            frm1.charactersList[i].Capacity = int.Parse(cCharCapacityBox.Text);
            frm1.charactersList[i].Description = cCharDescriptBox.Text;
            frm1.charactersList[i].ClassOption = cCharClassBox.Text;

            //aktualizacja wyswietlania postaci w comboBoxie
            frm1.characterBox.Items.Add(frm1.charactersList[i].Name + ", level: " + frm1.charactersList[i].Level + ", klasa: " + frm1.charactersList[i].ClassOption);
            frm1.characterBox.Items.RemoveAt(i);
            frm1.characterBox.SelectedIndex = frm1.characterBox.Items.Count - 1;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            int i = frm1.characterBox.SelectedIndex;

            string name = saveFileDialog1.FileName; //nazwa pliku do zapisu
            File.WriteAllText(name, frm1.charactersList[i].Name + Environment.NewLine + frm1.charactersList[i].Level);
        }

        private void dCharacterButton_Click(object sender, EventArgs e)
        {
            int i = frm1.characterBox.SelectedIndex;

            frm1.charactersList.RemoveAt(i); //usuwanie postaci z listy
            frm1.characterBox.Items.RemoveAt(i); //usuwanie postaci z comboBoxa
            frm1.clearTextBoxes();

            if (frm1.charactersList.Count == 0)
            {
                frm1.characterBox.Text = "";
            }
        }

        private void createCharButton_Click(object sender, EventArgs e)
        {
            var newCharacter = new Character(cCharNameBox.Text, int.Parse(cCharLevelBox.Text),
                Convert.ToDouble(cCharStrengthBox.Text), Convert.ToDouble(cCharDefenceBox.Text), 
                int.Parse(cCharMagicBox.Text), Convert.ToDouble(cCharCapacityBox.Text), 
                cCharClassBox.Text, cCharDescriptBox.Text);

            double lvl = int.Parse(cCharLevelBox.Text) * 1.05; //zwiekszanie wartosci bazowych o 5%
            newCharacter.GiveBonus(lvl);

            frm1.charactersList.Add(newCharacter);
            frm1.characterBox.Items.Add(newCharacter.Name + ", level: " + newCharacter.Level + ", klasa: " + 
                newCharacter.ClassOption);
        }
    }
}
