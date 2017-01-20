using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerEq
{
    public partial class Form1 : Form
    {
        public List<Character> charactersList = new List<Character>(); //tworzenie listy wszystkich postaci

        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void characterWindowOpen(object sender, EventArgs e)
        {
            if (form2 == null)
                form2 = new Form2(this);
            form2.Show();
        }

        private void characterChoice(object sender, EventArgs e)
        {
            nameBox.Text = charactersList[comboBox1.SelectedIndex].Name;
            levelBox.Text = charactersList[comboBox1.SelectedIndex].Level.ToString();
            strengthBox.Text = charactersList[comboBox1.SelectedIndex].Strength.ToString();
            defenceBox.Text = charactersList[comboBox1.SelectedIndex].Defence.ToString();
            magicBox.Text = charactersList[comboBox1.SelectedIndex].Magic.ToString();
            capacityBox.Text = charactersList[comboBox1.SelectedIndex].Capacity.ToString();
            descriptionBox.Text = charactersList[comboBox1.SelectedIndex].Description;
        }


    }
}
