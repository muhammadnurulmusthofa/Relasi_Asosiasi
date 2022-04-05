using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier("112Y", " Yuna", "jalan Bangka", "089900097890");

            supplier.tambahProduk(new Produk("2000", "Hyuna bag Charm", "Accesories", 0888909000));
            supplier.tambahProduk(new Produk("2001", "thofe", "ccccc", 23000));
            supplier.tambahProduk(new Produk("2002", " bag ", "aaaa", 22000));
            supplier.tambahProduk(new Produk("2003", "charm", "eeeee", 24000));

            Hasil.Text = supplier.tampil();
        }
    }
}
