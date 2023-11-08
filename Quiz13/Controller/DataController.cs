using MySqlConnector;
using Quiz13.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quiz13.Model;

namespace Quiz13.Controller
{
    internal class DataController : Model.Connection
    {
        Connection Koneksi = new Connection();

        public DataTable SelectPegawai(MySqlCommand command)
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM Pegawai";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public DataTable searchPegawai(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand
                    ("SELECT * FROM Pegawai WHERE CONCAT(Id,Nama,Alamat,Agama,Umur)LIKE '%" + search + "%'", Koneksi.GetConn());
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }

        public DataTable searchAgama(string agama)
        {
            DataTable table = new DataTable();
            if(agama == "All")
            {
                MySqlCommand cmd = new MySqlCommand
                   ("SELECT * FROM Pegawai", Koneksi.GetConn());
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(table);
            }
            try
            {
                MySqlCommand cmd = new MySqlCommand
                    ("SELECT * FROM Pegawai WHERE Agama='" + agama + "'", Koneksi.GetConn());
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }

        public void hapusPegawai(string idpegawai)
        {
            string hapus = "DELETE FROM Pegawai WHERE Id=" + idpegawai;

            try
            {
                cmd = new MySqlConnector.MySqlCommand(hapus, GetConn());
                cmd.Parameters.Add("@Id", MySqlConnector.MySqlDbType.VarChar).Value = idpegawai;
                cmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Delete Data Pegawai Gagal" + ex.Message);
            }
        }
    }
}
