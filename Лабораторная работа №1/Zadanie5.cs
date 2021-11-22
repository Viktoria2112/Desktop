using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Лабораторная_работа__1
{
    public partial class Zadanie5 : Form
    {
        public Zadanie5()
        {
            InitializeComponent();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            GlavnoeMenu gl = new GlavnoeMenu();
            gl.Show();
            this.Hide();
        }

        private void VSlovoA_Click(object sender, EventArgs e)
        {
            VSlovoA.Text = Slovo.Text;
        }

        private void VSlovoB_Click(object sender, EventArgs e)
        {
            VSlovoB.Text = Slovo.Text;
        }

        private void VSlovoC_Click(object sender, EventArgs e)
        {
            VSlovoC.Text = Slovo.Text;
        }

        private void VSlovoD_Click(object sender, EventArgs e)
        {
            VSlovoD.Text = Slovo.Text;
        }
    }
}
