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
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("");
            this.namaPelanggan = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cmbJenisKendaraan = new System.Windows.Forms.ComboBox();
            this.dtpTanggalBooking = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProses = new System.Windows.Forms.Button();
            this.cmbLayananCuci = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtTanggalbooking = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTanggalbooking = new System.Windows.Forms.Label();
            this.lblNamapelanggan = new System.Windows.Forms.Label();
            this.txtNamapelanggan = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // namaPelanggan
            // 
            this.namaPelanggan.AutoSize = true;
            this.namaPelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaPelanggan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.namaPelanggan.Location = new System.Drawing.Point(17, 64);
            this.namaPelanggan.Name = "namaPelanggan";
            this.namaPelanggan.Size = new System.Drawing.Size(150, 20);
            this.namaPelanggan.TabIndex = 0;
            this.namaPelanggan.Text = "Nama Pelanggan";
            this.namaPelanggan.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNama
            // 
            this.txtNama.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNama.Location = new System.Drawing.Point(214, 64);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(220, 22);
            this.txtNama.TabIndex = 2;
            // 
            // cmbJenisKendaraan
            // 
            this.cmbJenisKendaraan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbJenisKendaraan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJenisKendaraan.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmbJenisKendaraan.FormattingEnabled = true;
            this.cmbJenisKendaraan.Location = new System.Drawing.Point(21, 181);
            this.cmbJenisKendaraan.Name = "cmbJenisKendaraan";
            this.cmbJenisKendaraan.Size = new System.Drawing.Size(318, 28);
            this.cmbJenisKendaraan.TabIndex = 3;
            this.cmbJenisKendaraan.Text = "Jenis Kendaraan";
            this.cmbJenisKendaraan.SelectedIndexChanged += new System.EventHandler(this.cmbJenisKendaraan_SelectedIndexChanged);
            // 
            // dtpTanggalBooking
            // 
            this.dtpTanggalBooking.CalendarForeColor = System.Drawing.SystemColors.MenuText;
            this.dtpTanggalBooking.Location = new System.Drawing.Point(214, 121);
            this.dtpTanggalBooking.Name = "dtpTanggalBooking";
            this.dtpTanggalBooking.Size = new System.Drawing.Size(220, 22);
            this.dtpTanggalBooking.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Location = new System.Drawing.Point(354, 356);
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
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "AutoWash Booking System";
            // 
            // btnProses
            // 
            this.btnProses.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnProses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProses.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProses.Location = new System.Drawing.Point(227, 356);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(91, 42);
            this.btnProses.TabIndex = 9;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = false;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // cmbLayananCuci
            // 
            this.cmbLayananCuci.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbLayananCuci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLayananCuci.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmbLayananCuci.FormattingEnabled = true;
            this.cmbLayananCuci.Location = new System.Drawing.Point(21, 254);
            this.cmbLayananCuci.Name = "cmbLayananCuci";
            this.cmbLayananCuci.Size = new System.Drawing.Size(318, 28);
            this.cmbLayananCuci.TabIndex = 10;
            this.cmbLayananCuci.Text = "Layanan Cuci";
            this.cmbLayananCuci.SelectedIndexChanged += new System.EventHandler(this.cmbLayananCuci_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(19, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tanggal Booking";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(42, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(880, 457);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.namaPelanggan);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dtpTanggalBooking);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtNama);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.cmbJenisKendaraan);
            this.tabPage1.Controls.Add(this.btnProses);
            this.tabPage1.Controls.Add(this.cmbLayananCuci);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(872, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Booking";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.txtStatus);
            this.tabPage2.Controls.Add(this.txtTanggalbooking);
            this.tabPage2.Controls.Add(this.lblStatus);
            this.tabPage2.Controls.Add(this.lblTanggalbooking);
            this.tabPage2.Controls.Add(this.lblNamapelanggan);
            this.tabPage2.Controls.Add(this.txtNamapelanggan);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(872, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Riwayat";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem13,
            listViewItem14,
            listViewItem15});
            this.listView1.Location = new System.Drawing.Point(49, 221);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(406, 170);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtStatus.Location = new System.Drawing.Point(285, 144);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(170, 22);
            this.txtStatus.TabIndex = 19;
            // 
            // txtTanggalbooking
            // 
            this.txtTanggalbooking.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtTanggalbooking.Location = new System.Drawing.Point(285, 92);
            this.txtTanggalbooking.Name = "txtTanggalbooking";
            this.txtTanggalbooking.Size = new System.Drawing.Size(170, 22);
            this.txtTanggalbooking.TabIndex = 18;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(83, 146);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 20);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Status";
            // 
            // lblTanggalbooking
            // 
            this.lblTanggalbooking.AutoSize = true;
            this.lblTanggalbooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalbooking.Location = new System.Drawing.Point(45, 92);
            this.lblTanggalbooking.Name = "lblTanggalbooking";
            this.lblTanggalbooking.Size = new System.Drawing.Size(148, 20);
            this.lblTanggalbooking.TabIndex = 16;
            this.lblTanggalbooking.Text = "Tanggal Booking";
            this.lblTanggalbooking.Click += new System.EventHandler(this.lblTanggalbooking_Click);
            // 
            // lblNamapelanggan
            // 
            this.lblNamapelanggan.AutoSize = true;
            this.lblNamapelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamapelanggan.Location = new System.Drawing.Point(45, 39);
            this.lblNamapelanggan.Name = "lblNamapelanggan";
            this.lblNamapelanggan.Size = new System.Drawing.Size(150, 20);
            this.lblNamapelanggan.TabIndex = 15;
            this.lblNamapelanggan.Text = "Nama Pelanggan";
            // 
            // txtNamapelanggan
            // 
            this.txtNamapelanggan.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNamapelanggan.Location = new System.Drawing.Point(285, 37);
            this.txtNamapelanggan.Name = "txtNamapelanggan";
            this.txtNamapelanggan.Size = new System.Drawing.Size(170, 22);
            this.txtNamapelanggan.TabIndex = 14;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(872, 428);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pengaturan";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookingCarWashApp.Properties.Resources.c56d129633347ad70c0fe8308485a157;
            this.pictureBox1.Location = new System.Drawing.Point(473, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1028, 531);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtNamapelanggan;
        private System.Windows.Forms.Label lblTanggalbooking;
        private System.Windows.Forms.Label lblNamapelanggan;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtTanggalbooking;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

