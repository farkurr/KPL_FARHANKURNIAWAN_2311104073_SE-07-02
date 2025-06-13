using System;
using System.Windows.Forms;
using tpmodul12_2311104041;
using tpmodul12_2311104073;

namespace tpmodul12_2311104073
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labelOutput.Text = "Hasil Output";
        }

        public string CariTandaBilangan(int a)
        {
            if (a < 0) return "Negatif";
            else if (a > 0) return "Positif";
            else return "Nol";
        }

        private void buttonCek_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxInput.Text, out int input))
            {
                string hasil = Helper.CariTandaBilangan(input);
                labelOutput.Text = $"Hasil Output : {hasil}";
            }
            else
            {
                labelOutput.Text = "Hasil Output: Input tidak valid!";
            }
        }


        private void labelOutput_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSign_Click(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}