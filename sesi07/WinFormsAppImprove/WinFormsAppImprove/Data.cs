using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsAppImprove
{
    public partial class Data : Form
    {
        Config db = new Config();
        public static int SetId;
        public Data()
        {
            InitializeComponent();
            db.Connect("data_staff");
        }

        private void Data_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Login.SetValueUsername;
            txtNamaLog.Text = Login.SetValueNameLogin;

            initializeForm();
            
        }

        private void initializeForm()
        {
            txtDataName.Text = "";
            txtDataAlamat.Text = "";
            txtDataNo.Text = "";

            txtUsername.ReadOnly = true;
            txtNamaLog.ReadOnly = true;
            dataGridView1.ReadOnly = true;

            txtDataName.ReadOnly = true;
            txtDataAlamat.ReadOnly = true;
            txtDataNo.ReadOnly = true;

            btnBatal.Enabled = false;
            btnSimpan.Enabled = false;
            btnHapus.Enabled = false;
            btnEdit.Enabled = false;

            dataGridView1.DataSource = GetDataList();
        }

        private void inputForm()
        {
            txtDataName.ReadOnly = false;
            txtDataAlamat.ReadOnly = false;
            txtDataNo.ReadOnly = false;

            
        }

        private DataTable GetDataList()
        {
            DataTable dtData = new DataTable();

            dtData.Load(db.getDatagrid());

            return dtData;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            inputForm();

            btnBatal.Enabled = true;
            btnSimpan.Enabled = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(txtDataName.Text == "")
            {
                MessageBox.Show("Masukkan Nama!");
            }
            else if(txtDataAlamat.Text == "")
            {
                MessageBox.Show("Masukkan Alamat!");
            }
            else if (txtDataNo.Text == "")
            {
                MessageBox.Show("Masukkan No Telp!");
            }
            else
            {
                db.Execute($"INSERT INTO `data_staff` (`id`,`nama`,`alamat`,`handphone`) VALUES (NULL, '{txtDataName.Text}', '{txtDataAlamat.Text}', '{txtDataNo.Text}')");

                MessageBox.Show("Berhasil!");
                
                initializeForm();

            }
           
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            initializeForm();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            inputForm();

            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
            btnBatal.Enabled = true;

            txtDataName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDataAlamat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDataNo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            SetId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtDataName.Text == "")
            {
                MessageBox.Show("Nama tidak boleh kosong!");
            }
            else if (txtDataAlamat.Text == "")
            {
                MessageBox.Show("Alamat Tidak boleh kosong!");
            }
            else if (txtDataNo.Text == "")
            {
                MessageBox.Show("Nomor Telp tidak boleh Kosong!");
            }
            else
            {
                db.Execute($"UPDATE `data_staff` SET nama= '{txtDataName.Text}',alamat= '{txtDataAlamat.Text}',handphone='{txtDataNo.Text}' WHERE id='{SetId}'");

                MessageBox.Show("Update Berhasil!");

                initializeForm();

            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            db.Execute($"DELETE FROM `data_staff` WHERE id='{SetId}'");

            MessageBox.Show("Delete Berhasil!");

            initializeForm();
        }
    }
}
