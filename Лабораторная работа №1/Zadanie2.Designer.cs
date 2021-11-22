namespace Лабораторная_работа__1
{
    partial class Zadanie2
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
            this.Zeltiy = new System.Windows.Forms.Button();
            this.Zeleniy = new System.Windows.Forms.Button();
            this.Siniy = new System.Windows.Forms.Button();
            this.Krasniy = new System.Windows.Forms.Button();
            this.Nazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Zeltiy
            // 
            this.Zeltiy.Location = new System.Drawing.Point(336, 188);
            this.Zeltiy.Name = "Zeltiy";
            this.Zeltiy.Size = new System.Drawing.Size(196, 37);
            this.Zeltiy.TabIndex = 8;
            this.Zeltiy.Text = "Желтый";
            this.Zeltiy.UseVisualStyleBackColor = true;
            this.Zeltiy.Click += new System.EventHandler(this.Zeltiy_Click);
            // 
            // Zeleniy
            // 
            this.Zeleniy.Location = new System.Drawing.Point(336, 119);
            this.Zeleniy.Name = "Zeleniy";
            this.Zeleniy.Size = new System.Drawing.Size(196, 37);
            this.Zeleniy.TabIndex = 7;
            this.Zeleniy.Text = "Зеленый";
            this.Zeleniy.UseVisualStyleBackColor = true;
            this.Zeleniy.Click += new System.EventHandler(this.Zeleniy_Click);
            // 
            // Siniy
            // 
            this.Siniy.Location = new System.Drawing.Point(83, 188);
            this.Siniy.Name = "Siniy";
            this.Siniy.Size = new System.Drawing.Size(196, 37);
            this.Siniy.TabIndex = 6;
            this.Siniy.Text = "Синий";
            this.Siniy.UseVisualStyleBackColor = true;
            this.Siniy.Click += new System.EventHandler(this.Siniy_Click);
            // 
            // Krasniy
            // 
            this.Krasniy.Location = new System.Drawing.Point(83, 119);
            this.Krasniy.Name = "Krasniy";
            this.Krasniy.Size = new System.Drawing.Size(196, 37);
            this.Krasniy.TabIndex = 5;
            this.Krasniy.Text = "Красный";
            this.Krasniy.UseVisualStyleBackColor = true;
            this.Krasniy.Click += new System.EventHandler(this.Krasniy_Click);
            // 
            // Nazad
            // 
            this.Nazad.Location = new System.Drawing.Point(13, 13);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(75, 23);
            this.Nazad.TabIndex = 9;
            this.Nazad.Text = "Назад";
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // Zadanie2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 370);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.Zeltiy);
            this.Controls.Add(this.Zeleniy);
            this.Controls.Add(this.Siniy);
            this.Controls.Add(this.Krasniy);
            this.Name = "Zadanie2";
            this.Text = "Zadanie2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Zeltiy;
        private System.Windows.Forms.Button Zeleniy;
        private System.Windows.Forms.Button Siniy;
        private System.Windows.Forms.Button Krasniy;
        private System.Windows.Forms.Button Nazad;
    }
}