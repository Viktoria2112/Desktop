namespace Лабораторная_работа__1
{
    partial class Zadanie5
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
            this.VSlovoA = new System.Windows.Forms.Button();
            this.VSlovoB = new System.Windows.Forms.Button();
            this.VSlovoC = new System.Windows.Forms.Button();
            this.VSlovoD = new System.Windows.Forms.Button();
            this.Slovo = new System.Windows.Forms.TextBox();
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
            // VSlovoA
            // 
            this.VSlovoA.Location = new System.Drawing.Point(123, 68);
            this.VSlovoA.Name = "VSlovoA";
            this.VSlovoA.Size = new System.Drawing.Size(153, 30);
            this.VSlovoA.TabIndex = 11;
            this.VSlovoA.UseVisualStyleBackColor = true;
            this.VSlovoA.Click += new System.EventHandler(this.VSlovoA_Click);
            // 
            // VSlovoB
            // 
            this.VSlovoB.Location = new System.Drawing.Point(123, 125);
            this.VSlovoB.Name = "VSlovoB";
            this.VSlovoB.Size = new System.Drawing.Size(153, 30);
            this.VSlovoB.TabIndex = 12;
            this.VSlovoB.UseVisualStyleBackColor = true;
            this.VSlovoB.Click += new System.EventHandler(this.VSlovoB_Click);
            // 
            // VSlovoC
            // 
            this.VSlovoC.Location = new System.Drawing.Point(123, 185);
            this.VSlovoC.Name = "VSlovoC";
            this.VSlovoC.Size = new System.Drawing.Size(153, 30);
            this.VSlovoC.TabIndex = 13;
            this.VSlovoC.UseVisualStyleBackColor = true;
            this.VSlovoC.Click += new System.EventHandler(this.VSlovoC_Click);
            // 
            // VSlovoD
            // 
            this.VSlovoD.Location = new System.Drawing.Point(123, 249);
            this.VSlovoD.Name = "VSlovoD";
            this.VSlovoD.Size = new System.Drawing.Size(153, 30);
            this.VSlovoD.TabIndex = 14;
            this.VSlovoD.UseVisualStyleBackColor = true;
            this.VSlovoD.Click += new System.EventHandler(this.VSlovoD_Click);
            // 
            // Slovo
            // 
            this.Slovo.Location = new System.Drawing.Point(360, 153);
            this.Slovo.Name = "Slovo";
            this.Slovo.Size = new System.Drawing.Size(190, 20);
            this.Slovo.TabIndex = 16;
            // 
            // Zadanie5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 370);
            this.Controls.Add(this.Slovo);
            this.Controls.Add(this.VSlovoD);
            this.Controls.Add(this.VSlovoC);
            this.Controls.Add(this.VSlovoB);
            this.Controls.Add(this.VSlovoA);
            this.Controls.Add(this.Nazad);
            this.Name = "Zadanie5";
            this.Text = "Zadanie5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Button VSlovoA;
        private System.Windows.Forms.Button VSlovoB;
        private System.Windows.Forms.Button VSlovoC;
        private System.Windows.Forms.Button VSlovoD;
        private System.Windows.Forms.TextBox Slovo;
    }
}