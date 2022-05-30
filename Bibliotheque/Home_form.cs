using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bibliotheque
{
    public partial class BIBLIOTHEQUE : Form
    {
        public BIBLIOTHEQUE()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_affiche_MouseEnter(object sender, EventArgs e)
        {
            this.button_affiche.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_affiche.FlatAppearance.BorderSize = 4;
        }

        private void button_affiche_MouseLeave(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_aide_Click(object sender, EventArgs e)
        {

        }

        private void ajout_livre(object sender, EventArgs e)
        {
           
        }

        private void lister_livre(object sender, EventArgs e)
        {
            lister list = new lister();
            this.Hide();
            list.Show();
        }
    }
}
