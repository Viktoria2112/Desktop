namespace Лабораторная_работа__1
{
    partial class Zadanie6
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
            this.ZamenaAC = new System.Windows.Forms.Button();
            this.ZamenaBC = new System.Windows.Forms.Button();
            this.ZamenaAB = new System.Windows.Forms.Button();
            this.MenayA = new System.Windows.Forms.Label();
            this.MenayB = new System.Windows.Forms.Label();
            this.MenayC = new System.Windows.Forms.Label();
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
            // ZamenaAC
            // 
            this.ZamenaAC.Location = new System.Drawing.Point(123, 216);
            this.ZamenaAC.Name = "ZamenaAC";
            this.ZamenaAC.Size = new System.Drawing.Size(153, 30);
            this.ZamenaAC.TabIndex = 17;
            this.ZamenaAC.Text = "Желтый";
            this.ZamenaAC.UseVisualStyleBackColor = true;
            this.ZamenaAC.Click += new System.EventHandler(this.ZamenaAC_Click);
            // 
            // ZamenaBC
            // 
            this.ZamenaBC.Location = new System.Drawing.Point(123, 156);
            this.ZamenaBC.Name = "ZamenaBC";
            this.ZamenaBC.Size = new System.Drawing.Size(153, 30);
            this.ZamenaBC.TabIndex = 16;
            this.ZamenaBC.Text = "Зеленый";
            this.ZamenaBC.UseVisualStyleBackColor = true;
            this.ZamenaBC.Click += new System.EventHandler(this.ZamenaBC_Click);
            // 
            // ZamenaAB
            // 
            this.ZamenaAB.Location = new System.Drawing.Point(123, 99);
            this.ZamenaAB.Name = "ZamenaAB";
            this.ZamenaAB.Size = new System.Drawing.Size(153, 30);
            this.ZamenaAB.TabIndex = 15;
            this.ZamenaAB.Text = "Синий";
            this.ZamenaAB.UseVisualStyleBackColor = true;
            this.ZamenaAB.Click += new System.EventHandler(this.ZamenaAB_Click);
            // 
            // MenayA
            // 
            this.MenayA.AutoSize = true;
            this.MenayA.Location = new System.Drawing.Point(397, 123);
            this.MenayA.Name = "MenayA";
            this.MenayA.Size = new System.Drawing.Size(33, 13);
            this.MenayA.TabIndex = 18;
            this.MenayA.Text = "    ‌‌‍‍";
            // 
            // MenayB
            // 
            this.MenayB.AutoSize = true;
            this.MenayB.Location = new System.Drawing.Point(397, 156);
            this.MenayB.Name = "MenayB";
            this.MenayB.Size = new System.Drawing.Size(33, 13);
            this.MenayB.TabIndex = 19;
            this.MenayB.Text = "    ‌‌‍‍";
            // 
            // MenayC
            // 
            this.MenayC.AutoSize = true;
            this.MenayC.Location = new System.Drawing.Point(397, 192);
            this.MenayC.Name = "MenayC";
            this.MenayC.Size = new System.Drawing.Size(33, 13);
            this.MenayC.TabIndex = 20;
            this.MenayC.Text = "    ‌‌‍‍";
            // 
            // Zadanie6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 370);
            this.Controls.Add(this.MenayC);
            this.Controls.Add(this.MenayB);
            this.Controls.Add(this.MenayA);
            this.Controls.Add(this.ZamenaAC);
            this.Controls.Add(this.ZamenaBC);
            this.Controls.Add(this.ZamenaAB);
            this.Controls.Add(this.Nazad);
            this.Name = "Zadanie6";
            this.Text = "Zadanie6";
            this.Click += new System.EventHandler(this.Zadanie6_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Button ZamenaAC;
        private System.Windows.Forms.Button ZamenaBC;
        private System.Windows.Forms.Button ZamenaAB;
        private System.Windows.Forms.Label MenayA;
        private System.Windows.Forms.Label MenayB;
        private System.Windows.Forms.Label MenayC;
    }
}