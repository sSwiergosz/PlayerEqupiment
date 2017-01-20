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

        private void button1_Click(object sender, EventArgs e)
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
            textBoxDescription.Text = read[8];
            textBoxCapacity.Text = read[7];
            textBoxClass.Text = read[6];

            //tworzenie obiektu klasy Character
            var newCharacter = new Character(1, textBoxName.Text, int.Parse(textBoxLevel.Text),
                int.Parse(textBoxStrength.Text), int.Parse(textBoxDefence.Text), int.Parse(textBoxMagic.Text),
                textBoxDescription.Text, int.Parse(textBoxCapacity.Text), textBoxClass.Text);

            frm1.charactersList.Add(newCharacter); //dodawanie stworzonej postaci do listy wszystkich postaci

            //dodawanie postaci do comboboxa w Form1
            frm1.comboBox1.Items.Add(newCharacter.Name + ", level: " + newCharacter.Level + ", klasa: " + read[8]);
        }
    }
}
