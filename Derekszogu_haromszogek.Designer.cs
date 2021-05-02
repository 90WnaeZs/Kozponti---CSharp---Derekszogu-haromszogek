
namespace Haromszogek
{
    partial class Derekszogu_haromszogek
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
            this.btnSzamol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.list_Hiba = new System.Windows.Forms.ListBox();
            this.list_Derekszogu = new System.Windows.Forms.ListBox();
            this.list_Kivalasztott = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(22, 22);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(182, 44);
            this.btnSzamol.TabIndex = 0;
            this.btnSzamol.Text = "Adatok betöltése";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(22, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hibák a kiválasztott állományban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(22, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Derékszögű háromszögek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(371, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kiválasztott derékszögű háromszög adatai";
            // 
            // list_Hiba
            // 
            this.list_Hiba.FormattingEnabled = true;
            this.list_Hiba.Location = new System.Drawing.Point(22, 96);
            this.list_Hiba.Name = "list_Hiba";
            this.list_Hiba.Size = new System.Drawing.Size(754, 134);
            this.list_Hiba.TabIndex = 7;
            // 
            // list_Derekszogu
            // 
            this.list_Derekszogu.FormattingEnabled = true;
            this.list_Derekszogu.Location = new System.Drawing.Point(22, 278);
            this.list_Derekszogu.Name = "list_Derekszogu";
            this.list_Derekszogu.Size = new System.Drawing.Size(330, 251);
            this.list_Derekszogu.TabIndex = 8;
            this.list_Derekszogu.SelectedIndexChanged += new System.EventHandler(this.list_Derekszogu_SelectedIndexChanged);
            // 
            // list_Kivalasztott
            // 
            this.list_Kivalasztott.FormattingEnabled = true;
            this.list_Kivalasztott.Location = new System.Drawing.Point(374, 278);
            this.list_Kivalasztott.Name = "list_Kivalasztott";
            this.list_Kivalasztott.Size = new System.Drawing.Size(402, 251);
            this.list_Kivalasztott.TabIndex = 9;
            // 
            // Derekszogu_haromszogek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.list_Kivalasztott);
            this.Controls.Add(this.list_Derekszogu);
            this.Controls.Add(this.list_Hiba);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSzamol);
            this.Name = "Derekszogu_haromszogek";
            this.Text = "Derékszögű háromszögek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox list_Hiba;
        private System.Windows.Forms.ListBox list_Derekszogu;
        private System.Windows.Forms.ListBox list_Kivalasztott;
    }
}