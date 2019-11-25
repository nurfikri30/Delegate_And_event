namespace DelevCal
{
    partial class FrmHasil
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
            this.Hasil = new System.Windows.Forms.ListBox();
            this.btn_hitung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hasil
            // 
            this.Hasil.FormattingEnabled = true;
            this.Hasil.ItemHeight = 20;
            this.Hasil.Location = new System.Drawing.Point(12, 51);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(586, 264);
            this.Hasil.TabIndex = 0;
            // 
            // btn_hitung
            // 
            this.btn_hitung.Location = new System.Drawing.Point(12, 332);
            this.btn_hitung.Name = "btn_hitung";
            this.btn_hitung.Size = new System.Drawing.Size(586, 37);
            this.btn_hitung.TabIndex = 1;
            this.btn_hitung.Text = "Hitung";
            this.btn_hitung.UseVisualStyleBackColor = true;
            this.btn_hitung.Click += new System.EventHandler(this.btn_hitung_Click);
            // 
            // FrmHasil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 391);
            this.Controls.Add(this.btn_hitung);
            this.Controls.Add(this.Hasil);
            this.Name = "FrmHasil";
            this.Text = "Hasil Perhitungan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Hasil;
        private System.Windows.Forms.Button btn_hitung;
    }
}

