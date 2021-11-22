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
    public partial class Zadanie6 : Form
    {
        public Zadanie6()
        {
            InitializeComponent();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            GlavnoeMenu gl = new GlavnoeMenu();
            gl.Show();
            this.Hide();
        }

        private void ZamenaAB_Click(object sender, EventArgs e)
        {
            MenayA.BackColor = Color.Blue;
            MenayB.BackColor = Color.Blue;
        }

        private void ZamenaBC_Click(object sender, EventArgs e)
        {
            MenayC.BackColor = Color.Green;
            MenayB.BackColor = Color.Green;
        }

        private void ZamenaAC_Click(object sender, EventArgs e)
        {
            MenayA.BackColor = Color.Yellow;
            MenayC.BackColor = Color.Yellow;
        }

        private void Zadanie6_Click(object sender, EventArgs e)
        {
            MenayA.BackColor = Color.White;
            MenayB.BackColor = Color.White;
            MenayC.BackColor = Color.White;
        }
    }
}
