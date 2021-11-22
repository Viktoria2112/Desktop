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
    public partial class Zadanie3 : Form
    {
        public Zadanie3()
        {
            InitializeComponent();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            GlavnoeMenu gl = new GlavnoeMenu();
            gl.Show();
            this.Hide();
        }

        private void Privet_Click(object sender, EventArgs e)
        {
            SlovaSKnopok.Text = "Привет";
        }

        private void DoSvidaniya_Click(object sender, EventArgs e)
        {
            SlovaSKnopok.Text = "До свидания";
        }
    }
}
