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
    public partial class HalamanKonfirmasi : Form
    {
        public HalamanKonfirmasi(string namaPelanggan, string jenisKendaraan, int harga, DateTime tanggalBooking)
        {
            InitializeComponent();

            // Tampilkan data booking
            lblKonfirmasi.Text = $"Terima kasih {namaPelanggan},\nBooking {jenisKendaraan} Anda untuk tanggal {tanggalBooking.ToShortDateString()} " +
                                 $" telah diterima.";
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            // Kembali ke halaman utama
            Form1 halamanUtama = new Form1();
            halamanUtama.Show();
            this.Close();  // Tutup halaman konfirmasi
        }
    }
}
