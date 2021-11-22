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
    public partial class Zadanie2 : Form
    {
        public Zadanie2()
        {
            InitializeComponent();
        }

        private void Krasniy_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void Zeleniy_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void Siniy_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void Zeltiy_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            GlavnoeMenu gl = new GlavnoeMenu();
            gl.Show();
            this.Hide();
        }
    }
}
