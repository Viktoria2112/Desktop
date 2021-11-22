namespace Лабораторная_работа__1
{
    partial class Zadanie3
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
            this.SlovaSKnopok = new System.Windows.Forms.Label();
            this.Privet = new System.Windows.Forms.Button();
            this.DoSvidaniya = new System.Windows.Forms.Button();
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
            // SlovaSKnopok
            // 
            this.SlovaSKnopok.AutoSize = true;
            this.SlovaSKnopok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SlovaSKnopok.Location = new System.Drawing.Point(214, 67);
            this.SlovaSKnopok.Name = "SlovaSKnopok";
            this.SlovaSKnopok.Size = new System.Drawing.Size(192, 25);
            this.SlovaSKnopok.TabIndex = 11;
            this.SlovaSKnopok.Text = "Нажми на кнопку!";
            // 
            // Privet
            // 
            this.Privet.Location = new System.Drawing.Point(41, 179);
            this.Privet.Name = "Privet";
            this.Privet.Size = new System.Drawing.Size(227, 64);
            this.Privet.TabIndex = 12;
            this.Privet.Text = "Привет";
            this.Privet.UseVisualStyleBackColor = true;
            this.Privet.Click += new System.EventHandler(this.Privet_Click);
            // 
            // DoSvidaniya
            // 
            this.DoSvidaniya.Location = new System.Drawing.Point(333, 179);
            this.DoSvidaniya.Name = "DoSvidaniya";
            this.DoSvidaniya.Size = new System.Drawing.Size(227, 64);
            this.DoSvidaniya.TabIndex = 13;
            this.DoSvidaniya.Text = "До свидания";
            this.DoSvidaniya.UseVisualStyleBackColor = true;
            this.DoSvidaniya.Click += new System.EventHandler(this.DoSvidaniya_Click);
            // 
            // Zadanie3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 370);
            this.Controls.Add(this.DoSvidaniya);
            this.Controls.Add(this.Privet);
            this.Controls.Add(this.SlovaSKnopok);
            this.Controls.Add(this.Nazad);
            this.Name = "Zadanie3";
            this.Text = "Zadanie3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Label SlovaSKnopok;
        private System.Windows.Forms.Button Privet;
        private System.Windows.Forms.Button DoSvidaniya;
    }
}