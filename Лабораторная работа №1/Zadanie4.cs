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
    public partial class Zadanie4 : Form
    {
        public Zadanie4()
        {
            InitializeComponent();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            GlavnoeMenu gl = new GlavnoeMenu();
            gl.Show();
            this.Hide();
        }

        private void VvodSlovaA_Click(object sender, EventArgs e)
        {
            VvodimoeSlovo.Text = SlovoA.Text;
        }

        private void VvodSlovaB_Click(object sender, EventArgs e)
        {
            VvodimoeSlovo.Text = SlovoB.Text;
        }

        private void VvodSlovaC_Click(object sender, EventArgs e)
        {
            VvodimoeSlovo.Text = SlovoC.Text;
        }

        private void VvodSlovaD_Click(object sender, EventArgs e)
        {
            VvodimoeSlovo.Text = SlovoD.Text;
        }

        private void Zadanie4_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            VvodimoeSlovo.Text = "Введи слово и нажми кнопку";
        }
    }
}
