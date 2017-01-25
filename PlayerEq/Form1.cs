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
            nameBox.Text = charactersList[characterBox.SelectedIndex].Name;
            levelBox.Text = charactersList[characterBox.SelectedIndex].Level.ToString();
            strengthBox.Text = charactersList[characterBox.SelectedIndex].Strength.ToString();
            defenceBox.Text = charactersList[characterBox.SelectedIndex].Defence.ToString();
            magicBox.Text = charactersList[characterBox.SelectedIndex].Magic.ToString();
            capacityBoxMax.Text = charactersList[characterBox.SelectedIndex].Capacity.ToString();
            classBox.Text = form2.chrClass;
            descriptionBox.Text = charactersList[characterBox.SelectedIndex].Description;
        }


    }
}
