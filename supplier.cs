using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Supplier
    {
        string id, nama, alamat, nomor;

        List<String> produk = new List<string>();

        string product;

        Produk[] list = new Produk[5];

        public Supplier() { }

        public Supplier(string id, string nama, string alamat, string nomor)
        {
            this.id = id;
            this.nama = nama;
            this.alamat = alamat;
            this.nomor = nomor;
        }

        static int jumlahProduk = 0;

        public void tambahProduk(Produk produk)
        {
            list[jumlahProduk] = produk;
            jumlahProduk++;
        }

        public string tampil()
        {
            var items = tampil_produk();
            product = tampil_supplier();
            foreach (var item in items)
            {
                product = product + "\n" + item;
            }
            return product;
        }

        public string tampil_supplier()
        {
            return "ID Supplier : " + id +
                "\n" + "Nama Supplier :" + nama +
                "\n" + "Alamat Supplier :" + alamat +
                "\n" + "Nomor HandPhone :" + nomor +
                "\n" + "Daftar Produk :" + "\n";
        }
        public List<String> tampil_produk()
        {
            int i;

            for (i = 0; i < jumlahProduk; i++)
            {
                produk.Add(list[i].Id + " " + list[i].Nama + " - " + list[i].Kategori + " = " + list[i].Harga);
            }

            return produk;
        }
    }
}
