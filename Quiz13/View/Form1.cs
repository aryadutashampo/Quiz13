using Quiz13.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Drawing.Printing;

namespace Quiz13
{
    public partial class FormUtama : System.Windows.Forms.Form
    {
        DataController DCtrl;
        private string agama;
        public FormUtama()
        {
            DCtrl = new DataController();
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            ShowTable();
        }

        public void ShowTable()
        {
            dataGridViewMain.DataSource = DCtrl.SelectPegawai(new MySqlConnector.MySqlCommand("SELECT * FROM Pegawai"));
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtSearch.Clear();
            radioButtonAll.Checked = false;
            radioButtonISL.Checked = false;
            radioButtonKRS.Checked = false;
        }

        private void BtnSearchA_Click(object sender, EventArgs e)
        {
            dataGridViewMain.DataSource = DCtrl.searchPegawai(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowTable();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DCtrl.hapusPegawai(txtID.Text);
                MessageBox.Show("Data Pegawai Berhasil Dihapus", "Hapus Data Pegawai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            FormUtama fu = new FormUtama();
            fu.Show();
            this.Hide();
        }

        private void btnSearchB_Click(object sender, EventArgs e)
        {
            dataGridViewMain.DataSource = DCtrl.searchAgama(agama);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonAll.Checked)
            {
                agama = "All";
            }
            else if (radioButtonISL.Checked)
            {
                agama = "Islam";
            }
            else if (radioButtonKRS.Checked)
            {
                agama = "Kristen";
            }
        }
    }
}
