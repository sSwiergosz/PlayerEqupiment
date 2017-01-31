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
            var newItem = new Item(id, readItem[0], readItem[1], readItem[2], Convert.ToDouble(readItem[3]),
                                    readItem[4], Convert.ToDouble(readItem[5]), readItem[6]);

            //dodawanie obiektu do listy wszystkich itemow
            frm1.itemsList.Add(newItem);

            //wyswietlanie itemow w comboboxie
            frm1.comboBox1.Items.Add(newItem.Name);

            //TODO - zapisywanie do pliku, usuwanie i edycja itemu
        }

    }
}
