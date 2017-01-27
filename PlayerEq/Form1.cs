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
        {   //wypelnienie textBoxow wartosciami z listy postaci
            //index w ComboBoxie jest rowny indexowi na liscie
            int i = characterBox.SelectedIndex;

            nameBox.Text = charactersList[i].Name;
            levelBox.Text = charactersList[i].Level.ToString();
            strengthBox.Text = charactersList[i].Strength.ToString();
            defenceBox.Text = charactersList[i].Defence.ToString();
            magicBox.Text = charactersList[i].Magic.ToString();
            capacityBoxMax.Text = charactersList[i].Capacity.ToString();
            classBox.Text = charactersList[i].ClassOption;
            descriptionBox.Text = charactersList[i].Description;
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
    }
}
