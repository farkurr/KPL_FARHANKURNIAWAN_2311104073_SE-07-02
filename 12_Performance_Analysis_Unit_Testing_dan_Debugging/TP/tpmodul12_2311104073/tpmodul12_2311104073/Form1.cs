using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpmodul12_2311104073
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string CariTandaBilangan(int a)
        {
            if (a < 0) return "Negatif";
            else if (a > 0) return "Positif";
            else return "Nol";
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int nilai))
            {
                string hasil = CariTandaBilangan(nilai);
                lblHasil.Text = hasil;
            }
            else
            {
                lblHasil.Text = "Input tidak valid!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Kosongkan atau isi jika perlu
        }

        private void lblHasil_Click(object sender, EventArgs e)
        {

        }
    }
}
