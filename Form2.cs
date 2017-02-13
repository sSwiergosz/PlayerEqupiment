using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace PlayerEq
{
    public partial class Form2 : Form
    {
        private readonly Form1 _frm1;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 frm1)
        {
            InitializeComponent();
            _frm1 = frm1;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ukrywanie okna
            Hide();
            e.Cancel = true;
        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            var read = new string[8]; //do tej tablicy wczytujemy wartosci z pliku
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog1.FileName;
                try
                {
                    read = File.ReadAllLines(file); //wczytywanie z pliku linia po linii
                }
                catch (IOException)
                {
                    MessageBox.Show("Reading failed!");
                }
            }

            //tworzenie obiektu klasy Character
            _frm1.CharId++;
            var newCharacter = new Character(_frm1.CharId, read[0], int.Parse(read[1]),
                Convert.ToDouble(read[2]), Convert.ToDouble(read[3]), int.Parse(read[4]),
                Convert.ToDouble(read[5]), read[6], read[7]);

            var lvl = (1.05 * int.Parse(read[1])); //zwiekszanie wartosci bazowych
            newCharacter.GiveBonus(lvl);

            //dodawanie stworzonej postaci do listy wszystkich postaci
            _frm1.CharactersList.Add(newCharacter);

            //dodawanie postaci do comboboxa w Form1
            _frm1.characterBox.Items.Add(newCharacter.Name + ", level: " + newCharacter.Level + ", klasa: " + read[7]);

            //Domyslne wybranie z comboboxa ostatniego wczytanego obiektu
            _frm1.characterBox.SelectedIndex = _frm1.characterBox.Items.Count - 1;

            MessageBox.Show("Character read!");
        }

        private void eCharacterButton_Click(object sender, EventArgs e)
        {
            var i = _frm1.characterBox.SelectedIndex;

            _frm1.CharactersList[i].Name = cCharNameBox.Text;
            _frm1.CharactersList[i].Level = int.Parse(cCharLevelBox.Text);
            _frm1.CharactersList[i].Strength = int.Parse(cCharStrengthBox.Text);
            _frm1.CharactersList[i].Defence = int.Parse(cCharDefenceBox.Text);
            _frm1.CharactersList[i].Magic = int.Parse(cCharMagicBox.Text);
            _frm1.CharactersList[i].Capacity = int.Parse(cCharCapacityBox.Text);
            _frm1.CharactersList[i].Description = cCharDescriptBox.Text;
            _frm1.CharactersList[i].ClassOption = cCharClassBox.Text;

            //aktualizacja wyswietlania postaci w comboBoxie
            _frm1.characterBox.Items.Add(_frm1.CharactersList[i].Name + ", level: " + _frm1.CharactersList[i].Level +
                                        ", klasa: " + _frm1.CharactersList[i].ClassOption);
            _frm1.characterBox.Items.RemoveAt(i);
            _frm1.characterBox.SelectedIndex = _frm1.characterBox.Items.Count - 1;

            MessageBox.Show("Character edited!");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var i = _frm1.characterBox.SelectedIndex;

            var name = saveFileDialog1.FileName; //nazwa pliku do zapisu
            try
            {
                File.WriteAllText(name, _frm1.CharactersList[i].Name + Environment.NewLine +
                            _frm1.CharactersList[i].Level + Environment.NewLine + _frm1.CharactersList[i].Strength +
                            Environment.NewLine + _frm1.CharactersList[i].Defence + Environment.NewLine +
                            _frm1.CharactersList[i].Magic + Environment.NewLine + _frm1.CharactersList[i].Capacity +
                            Environment.NewLine + _frm1.CharactersList[i].ClassOption + Environment.NewLine +
                            _frm1.CharactersList[i].Description);
            }
            catch (IOException)
            {
                MessageBox.Show("Saving failed!");
            }
            
        }

        private void dCharacterButton_Click(object sender, EventArgs e)
        {
            var i = _frm1.characterBox.SelectedIndex;

            _frm1.CharactersList.RemoveAt(i); //usuwanie postaci z listy
            _frm1.characterBox.Items.RemoveAt(i); //usuwanie postaci z comboBoxa
            _frm1.ClearTextBoxes();

            if (_frm1.CharactersList.Count == 0)
                _frm1.characterBox.Text = "";

            MessageBox.Show("Item deleted!");
        }

        private void createCharButton_Click(object sender, EventArgs e)
        {
            _frm1.CharId++;
            var newCharacter = new Character(_frm1.CharId, cCharNameBox.Text, int.Parse(cCharLevelBox.Text),
                Convert.ToDouble(cCharStrengthBox.Text), Convert.ToDouble(cCharDefenceBox.Text),
                int.Parse(cCharMagicBox.Text), Convert.ToDouble(cCharCapacityBox.Text),
                cCharClassBox.Text, cCharDescriptBox.Text);

            var lvl = int.Parse(cCharLevelBox.Text) * 1.05; //zwiekszanie wartosci bazowych o 5%
            newCharacter.GiveBonus(lvl);

            _frm1.CharactersList.Add(newCharacter);
            _frm1.characterBox.Items.Add(newCharacter.Name + ", level: " + newCharacter.Level + ", klasa: " +
                                        newCharacter.ClassOption);

            MessageBox.Show("Character created!");
        }
    }
}