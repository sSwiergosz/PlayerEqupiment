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
        public string chrClass;

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
            var read = new string[9]; //do tej tablicy wczytujemy wartosci z pliku
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
            textBoxName.Text = read[1];
            textBoxLevel.Text = read[2];
            textBoxStrength.Text = read[3];
            textBoxDefence.Text = read[4];
            textBoxMagic.Text = read[5];
            textBoxCapacity.Text = read[6];
            textBoxClass.Text = read[7];
            textBoxDescription.Text = read[8];

            //tworzenie obiektu klasy Character
            var newCharacter = new Character(1, textBoxName.Text, int.Parse(textBoxLevel.Text),
                int.Parse(textBoxStrength.Text), int.Parse(textBoxDefence.Text), int.Parse(textBoxMagic.Text),
                int.Parse(textBoxCapacity.Text), textBoxClass.Text, textBoxDescription.Text);

            frm1.charactersList.Add(newCharacter); //dodawanie stworzonej postaci do listy wszystkich postaci

            //dodawanie postaci do comboboxa w Form1
            frm1.characterBox.Items.Add(newCharacter.Name + ", level: " + newCharacter.Level + ", klasa: " + read[7]);
            chrClass = read[7];

            //Domyslne wybranie z comboboxa ostatniego wczytanego obiektu
            frm1.characterBox.SelectedIndex = frm1.characterBox.Items.Count - 1;
        }

        private void eCharacterButton_Click(object sender, EventArgs e)
        {
            textBoxName.Text = eTextBoxName.Text;
            textBoxLevel.Text = eTextBoxLevel.Text;
            textBoxStrength.Text = eTextBoxStrength.Text;
            textBoxDefence.Text = eTextBoxDefence.Text;
            textBoxMagic.Text = eTextBoxMagic.Text;
            textBoxCapacity.Text = eTextBoxCapacity.Text;
            textBoxClass.Text = eTextBoxClass.Text;
            textBoxDescription.Text = eTextBoxDescription.Text;

            int i = frm1.characterBox.SelectedIndex;

            frm1.charactersList[i].Name = eTextBoxName.Text;
            frm1.charactersList[i].Level = int.Parse(eTextBoxLevel.Text);
            frm1.charactersList[i].Strength = int.Parse(eTextBoxStrength.Text);
            frm1.charactersList[i].Defence = int.Parse(eTextBoxDefence.Text);
            frm1.charactersList[i].Magic = int.Parse(eTextBoxMagic.Text);
            frm1.charactersList[i].Capacity = int.Parse(eTextBoxCapacity.Text);
            frm1.charactersList[i].Description = eTextBoxDescription.Text;


            frm1.characterBox.Items.Add(frm1.charactersList[i].Name + ", level: " + frm1.charactersList[i].Level + ", klasa: " + textBoxClass.Text);
            frm1.characterBox.Items.RemoveAt(i);
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
    }
}
