namespace BookingCarWashApp
{
    partial class Form1
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
            this.namaPelanggan = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cmbJenisKendaraan = new System.Windows.Forms.ComboBox();
            this.dtpTanggalBooking = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProses = new System.Windows.Forms.Button();
            this.cmbLayananCuci = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // namaPelanggan
            // 
            this.namaPelanggan.AutoSize = true;
            this.namaPelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaPelanggan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.namaPelanggan.Location = new System.Drawing.Point(183, 168);
            this.namaPelanggan.Name = "namaPelanggan";
            this.namaPelanggan.Size = new System.Drawing.Size(150, 20);
            this.namaPelanggan.TabIndex = 0;
            this.namaPelanggan.Text = "Nama Pelanggan";
            this.namaPelanggan.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(392, 166);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(238, 22);
            this.txtNama.TabIndex = 2;
            // 
            // cmbJenisKendaraan
            // 
            this.cmbJenisKendaraan.BackColor = System.Drawing.SystemColors.Window;
            this.cmbJenisKendaraan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJenisKendaraan.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmbJenisKendaraan.FormattingEnabled = true;
            this.cmbJenisKendaraan.Location = new System.Drawing.Point(187, 222);
            this.cmbJenisKendaraan.Name = "cmbJenisKendaraan";
            this.cmbJenisKendaraan.Size = new System.Drawing.Size(158, 24);
            this.cmbJenisKendaraan.TabIndex = 3;
            this.cmbJenisKendaraan.Text = "Jenis Kendaraan";
            // 
            // dtpTanggalBooking
            // 
            this.dtpTanggalBooking.CalendarForeColor = System.Drawing.SystemColors.MenuText;
            this.dtpTanggalBooking.Location = new System.Drawing.Point(392, 292);
            this.dtpTanggalBooking.Name = "dtpTanggalBooking";
            this.dtpTanggalBooking.Size = new System.Drawing.Size(238, 22);
            this.dtpTanggalBooking.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Location = new System.Drawing.Point(539, 356);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 42);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(181, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "AutoWash Booking System";
            // 
            // btnProses
            // 
            this.btnProses.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnProses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProses.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProses.Location = new System.Drawing.Point(392, 356);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(91, 42);
            this.btnProses.TabIndex = 9;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = false;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // cmbLayananCuci
            // 
            this.cmbLayananCuci.BackColor = System.Drawing.SystemColors.Window;
            this.cmbLayananCuci.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLayananCuci.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmbLayananCuci.FormattingEnabled = true;
            this.cmbLayananCuci.Location = new System.Drawing.Point(392, 222);
            this.cmbLayananCuci.Name = "cmbLayananCuci";
            this.cmbLayananCuci.Size = new System.Drawing.Size(238, 24);
            this.cmbLayananCuci.TabIndex = 10;
            this.cmbLayananCuci.Text = "Layanan Cuci";
            this.cmbLayananCuci.SelectedIndexChanged += new System.EventHandler(this.cmbLayananCuci_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(183, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tanggal Booking";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbLayananCuci);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dtpTanggalBooking);
            this.Controls.Add(this.cmbJenisKendaraan);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.namaPelanggan);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namaPelanggan;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cmbJenisKendaraan;
        private System.Windows.Forms.DateTimePicker dtpTanggalBooking;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.ComboBox cmbLayananCuci;
        private System.Windows.Forms.Label label3;
    }
}

