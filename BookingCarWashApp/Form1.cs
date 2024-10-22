using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingCarWashApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            // Validasi input nama pelanggan
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama pelanggan tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi pilihan jenis kendaraan
            if (cmbJenisKendaraan.SelectedItem == null)
            {
                MessageBox.Show("Silakan pilih jenis kendaraan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi pilihan layanan cuci
            if (cmbLayananCuci.SelectedItem == null)
            {
                MessageBox.Show("Silakan pilih layanan cuci!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ambil harga berdasarkan layanan yang dipilih
            int harga = 0;
            switch (cmbLayananCuci.SelectedItem.ToString())
            {
                case "Cuci Mobil - Rp 100000":
                    harga = 50000;
                    break;
                case "Cuci Lengkap - Rp 100.000":
                    harga = 100000;
                    break;
                case "Cuci + Wax - Rp 150.000":
                    harga = 150000;
                    break;
            }

            // Ambil tanggal booking
            DateTime tanggalBooking = dtpTanggalBooking.Value;

            // Panggil halaman konfirmasi
            HalamanKonfirmasi halamanKonfirmasi = new HalamanKonfirmasi(txtNama.Text, cmbJenisKendaraan.SelectedItem.ToString(), harga, tanggalBooking);
            halamanKonfirmasi.Show();
            this.Hide();  // Sembunyikan halaman
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNama.Clear();
            cmbJenisKendaraan.SelectedItem = null;
            cmbLayananCuci.SelectedItem = null;
            dtpTanggalBooking.Value = DateTime.Now;  // Reset ke tanggal saat ini
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Menambahkan jenis kendaraan ke ComboBox
            cmbJenisKendaraan.Items.Add("Mobil");
            cmbJenisKendaraan.Items.Add("Motor");

            // Mengisi ComboBox dengan pilihan layanan cuci
            cmbLayananCuci.Items.Add("Cuci Mobil - 100000");
            cmbLayananCuci.Items.Add("Cuci Motor - 50000");
            cmbLayananCuci.Items.Add("Cuci Ekstra (Mobil) - 150000");
            cmbLayananCuci.Items.Add("Cuci Ekstra (Motor) - 100000");

            // Jika ingin memilih item default
            cmbLayananCuci.SelectedIndex = 0; // Memilih item pertama secara default

        }

        private void cmbLayananCuci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbJenisKendaraan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTanggalbooking_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Membersihkan item lama jika ada
            listView1.Items.Clear();

            // Tambahkan data riwayat booking
            ListViewItem booking1 = new ListViewItem("Andi");
            booking1.SubItems.Add("22 Oktober 2024");
            booking1.SubItems.Add("Sukses");
            booking1.ForeColor = Color.Green;  // Menggunakan warna hijau untuk sukses
            listView1.Items.Add(booking1);

            ListViewItem booking2 = new ListViewItem("Budi");
            booking2.SubItems.Add("23 Oktober 2024");
            booking2.SubItems.Add("Sedang Diproses");
            booking2.ForeColor = Color.Orange; // Menggunakan warna oranye untuk proses
            listView1.Items.Add(booking2);

            ListViewItem booking3 = new ListViewItem("Citra");
            booking3.SubItems.Add("21 Oktober 2024");
            booking3.SubItems.Add("Dibatalkan");
            booking3.ForeColor = Color.Red; // Menggunakan warna merah untuk dibatalkan
            listView1.Items.Add(booking3);
        }
    }
}
