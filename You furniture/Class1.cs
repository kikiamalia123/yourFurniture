using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace You_furniture
{
    internal abstract class sql
    {
        protected NpgsqlConnection connect;
        internal sql()
        {
            string db = "Host=localhost;Database=yourFurniture;username=postgres;password=12345678";
            connect = new NpgsqlConnection(db);
        }
    }

    internal class project : sql
    {
        internal string[][] getdata(string query)
        {
            List<string[]> list = new List<string[]>();

            connect.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, connect);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id_barang = reader.GetInt32(0);
                string nama_barang = reader.GetString(1);
                string deskripsi = reader.GetString(2);
                int harga = reader.GetInt32(3);

                list.Add(new string[] { Convert.ToString(id_barang), nama_barang, deskripsi, Convert.ToString(harga)});
            }
            connect.Close();
            return list.ToArray();
        }

        internal string[][] getTransaksi(string query)
        {
            List<string[]> list = new List<string[]>();

            connect.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, connect);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id_transaksi = reader.GetInt32(0);
                string nama_kasir = reader.GetString(1);
                string barang = reader.GetString(2);
                string warna = reader.GetString(3);
                int total_harga = reader.GetInt32(4);
                int jumlah_barang = reader.GetInt32(5);

                list.Add(new string[] { Convert.ToString(id_transaksi), nama_kasir, barang, warna, Convert.ToString(total_harga), Convert.ToString(jumlah_barang)});
            }
            connect.Close();
            return list.ToArray();
        }
    }
}


