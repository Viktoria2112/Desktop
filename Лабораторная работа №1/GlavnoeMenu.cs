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
    public partial class GlavnoeMenu : Form
    {
        public GlavnoeMenu()
        {
            InitializeComponent();
        }

        private void Zadanie2_Click(object sender, EventArgs e)
        {
            Zadanie2 zd2 = new Zadanie2();
            this.Hide();
            zd2.Show();
        }

        private void Zadanie3_Click(object sender, EventArgs e)
        {
            Zadanie3 zd3 = new Zadanie3();
            this.Hide();
            zd3.Show();
        }

        private void Zadanie4_Click(object sender, EventArgs e)
        {
            Zadanie4 zd4 = new Zadanie4();
            this.Hide();
            zd4.Show();
        }

        private void Zadanie5_Click(object sender, EventArgs e)
        {
            Zadanie5 zd5 = new Zadanie5();
            this.Hide();
            zd5.Show();
        }

        private void Zadanie6_Click(object sender, EventArgs e)
        {
            Zadanie6 zd6 = new Zadanie6();
            this.Hide();
            zd6.Show();
        }
    }
}
