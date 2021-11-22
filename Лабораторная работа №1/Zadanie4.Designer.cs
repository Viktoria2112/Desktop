namespace Лабораторная_работа__1
{
    partial class Zadanie4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nazad = new System.Windows.Forms.Button();
            this.VvodSlovaA = new System.Windows.Forms.Button();
            this.VvodSlovaB = new System.Windows.Forms.Button();
            this.VvodSlovaC = new System.Windows.Forms.Button();
            this.VvodSlovaD = new System.Windows.Forms.Button();
            this.SlovoA = new System.Windows.Forms.TextBox();
            this.SlovoB = new System.Windows.Forms.TextBox();
            this.SlovoC = new System.Windows.Forms.TextBox();
            this.SlovoD = new System.Windows.Forms.TextBox();
            this.VvodimoeSlovo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nazad
            // 
            this.Nazad.Location = new System.Drawing.Point(12, 12);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(75, 23);
            this.Nazad.TabIndex = 10;
            this.Nazad.Text = "Назад";
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // VvodSlovaA
            // 
            this.VvodSlovaA.Location = new System.Drawing.Point(132, 123);
            this.VvodSlovaA.Name = "VvodSlovaA";
            this.VvodSlovaA.Size = new System.Drawing.Size(136, 32);
            this.VvodSlovaA.TabIndex = 11;
            this.VvodSlovaA.Text = "Вывод";
            this.VvodSlovaA.UseVisualStyleBackColor = true;
            this.VvodSlovaA.Click += new System.EventHandler(this.VvodSlovaA_Click);
            // 
            // VvodSlovaB
            // 
            this.VvodSlovaB.Location = new System.Drawing.Point(132, 179);
            this.VvodSlovaB.Name = "VvodSlovaB";
            this.VvodSlovaB.Size = new System.Drawing.Size(136, 32);
            this.VvodSlovaB.TabIndex = 12;
            this.VvodSlovaB.Text = "Вывод";
            this.VvodSlovaB.UseVisualStyleBackColor = true;
            this.VvodSlovaB.Click += new System.EventHandler(this.VvodSlovaB_Click);
            // 
            // VvodSlovaC
            // 
            this.VvodSlovaC.Location = new System.Drawing.Point(132, 235);
            this.VvodSlovaC.Name = "VvodSlovaC";
            this.VvodSlovaC.Size = new System.Drawing.Size(136, 32);
            this.VvodSlovaC.TabIndex = 13;
            this.VvodSlovaC.Text = "Вывод";
            this.VvodSlovaC.UseVisualStyleBackColor = true;
            this.VvodSlovaC.Click += new System.EventHandler(this.VvodSlovaC_Click);
            // 
            // VvodSlovaD
            // 
            this.VvodSlovaD.Location = new System.Drawing.Point(132, 289);
            this.VvodSlovaD.Name = "VvodSlovaD";
            this.VvodSlovaD.Size = new System.Drawing.Size(136, 32);
            this.VvodSlovaD.TabIndex = 14;
            this.VvodSlovaD.Text = "Вывод";
            this.VvodSlovaD.UseVisualStyleBackColor = true;
            this.VvodSlovaD.Click += new System.EventHandler(this.VvodSlovaD_Click);
            // 
            // SlovoA
            // 
            this.SlovoA.Location = new System.Drawing.Point(301, 130);
            this.SlovoA.Name = "SlovoA";
            this.SlovoA.Size = new System.Drawing.Size(190, 20);
            this.SlovoA.TabIndex = 15;
            // 
            // SlovoB
            // 
            this.SlovoB.Location = new System.Drawing.Point(301, 186);
            this.SlovoB.Name = "SlovoB";
            this.SlovoB.Size = new System.Drawing.Size(190, 20);
            this.SlovoB.TabIndex = 16;
            // 
            // SlovoC
            // 
            this.SlovoC.Location = new System.Drawing.Point(301, 242);
            this.SlovoC.Name = "SlovoC";
            this.SlovoC.Size = new System.Drawing.Size(190, 20);
            this.SlovoC.TabIndex = 17;
            // 
            // SlovoD
            // 
            this.SlovoD.Location = new System.Drawing.Point(301, 296);
            this.SlovoD.Name = "SlovoD";
            this.SlovoD.Size = new System.Drawing.Size(190, 20);
            this.SlovoD.TabIndex = 18;
            // 
            // VvodimoeSlovo
            // 
            this.VvodimoeSlovo.AutoSize = true;
            this.VvodimoeSlovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VvodimoeSlovo.Location = new System.Drawing.Point(162, 60);
            this.VvodimoeSlovo.Name = "VvodimoeSlovo";
            this.VvodimoeSlovo.Size = new System.Drawing.Size(0, 25);
            this.VvodimoeSlovo.TabIndex = 19;
            // 
            // Zadanie4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 370);
            this.Controls.Add(this.VvodimoeSlovo);
            this.Controls.Add(this.SlovoD);
            this.Controls.Add(this.SlovoC);
            this.Controls.Add(this.SlovoB);
            this.Controls.Add(this.SlovoA);
            this.Controls.Add(this.VvodSlovaD);
            this.Controls.Add(this.VvodSlovaC);
            this.Controls.Add(this.VvodSlovaB);
            this.Controls.Add(this.VvodSlovaA);
            this.Controls.Add(this.Nazad);
            this.Name = "Zadanie4";
            this.Text = "Zadanie4";
            this.Load += new System.EventHandler(this.Zadanie4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Button VvodSlovaA;
        private System.Windows.Forms.Button VvodSlovaB;
        private System.Windows.Forms.Button VvodSlovaC;
        private System.Windows.Forms.Button VvodSlovaD;
        private System.Windows.Forms.TextBox SlovoA;
        private System.Windows.Forms.TextBox SlovoB;
        private System.Windows.Forms.TextBox SlovoC;
        private System.Windows.Forms.TextBox SlovoD;
        private System.Windows.Forms.Label VvodimoeSlovo;
    }
}