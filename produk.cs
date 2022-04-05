using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Produk
    {
        string id, nama, kategori;
        double harga;

        public Produk() { }

        public Produk(string id, string nama, string kategori, double harga)
        {
            this.Id = id;
            this.Nama = nama;
            this.Kategori = kategori;
            this.Harga = harga;
        }

        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Kategori { get => kategori; set => kategori = value; }
        public double Harga { get => harga; set => harga = value; }
    }
}
