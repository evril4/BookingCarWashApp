namespace BookingCarWashApp
{
    partial class HalamanKonfirmasi
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
            this.lblKonfirmasi = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKonfirmasi
            // 
            this.lblKonfirmasi.AutoSize = true;
            this.lblKonfirmasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKonfirmasi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKonfirmasi.Location = new System.Drawing.Point(12, 131);
            this.lblKonfirmasi.Name = "lblKonfirmasi";
            this.lblKonfirmasi.Size = new System.Drawing.Size(132, 20);
            this.lblKonfirmasi.TabIndex = 0;
            this.lblKonfirmasi.Text = "Detail Booking";
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKembali.Location = new System.Drawing.Point(12, 12);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(82, 42);
            this.btnKembali.TabIndex = 1;
            this.btnKembali.Text = "BACK";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // HalamanKonfirmasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.lblKonfirmasi);
            this.Name = "HalamanKonfirmasi";
            this.Text = "HalamanKonfirmasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKonfirmasi;
        private System.Windows.Forms.Button btnKembali;
    }
}