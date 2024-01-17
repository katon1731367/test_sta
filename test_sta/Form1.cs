using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_sta
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=CHOWDERDANGER;Initial Catalog=test_sta;Integrated Security=True";
        private SqlConnection con = new SqlConnection("Data Source=CHOWDERDANGER;Initial Catalog=test_sta;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_karyawan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Karyawan", con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgv_karyawan.DataSource = dataTable;
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                StringBuilder filterQuery = new StringBuilder("SELECT * FROM Karyawan WHERE 1 = 1");

                if (!string.IsNullOrEmpty(txt_filterNamaStart.Text))
                {
                    filterQuery.Append($" AND NmKaryawan LIKE '{txt_filterNamaStart.Text}%'");
                }

                if (!string.IsNullOrEmpty(txt_filterNamaEnd.Text))
                {
                    filterQuery.Append($" AND NmKaryawan LIKE '%{txt_filterNamaEnd.Text}'");
                }


                if (!string.IsNullOrEmpty(txt_filterUsiaStart.Text))
                {
                    filterQuery.Append($" AND Usia >= {int.Parse(txt_filterUsiaStart.Text)}");
                }
                if (!string.IsNullOrEmpty(txt_filterUsiaEnd.Text))
                {
                    filterQuery.Append($" AND Usia <= {int.Parse(txt_filterUsiaEnd.Text)}");
                }

                if (txt_tglMasukKerjaStart.Text != null)
                {
                    if (DateTime.TryParse(txt_tglMasukKerjaStart.Text, out DateTime result))
                    {
                        string tglMasukKerjaStart = result.ToString("yyyy-MM-dd HH:mm:ss");
                        filterQuery.Append($" AND TglMasukKerja >= '{tglMasukKerjaStart}'");
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format");
                    }
                }
                if (txt_tglMasukKerjaEnd.Text != null)
                {
                    if (DateTime.TryParse(txt_tglMasukKerjaEnd.Text, out DateTime result))
                    {
                        string tglMasukKerjaStart = result.ToString("yyyy-MM-dd HH:mm:ss");
                        filterQuery.Append($" AND TglMasukKerja >= '{txt_tglMasukKerjaEnd}'");
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format");
                    }
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(filterQuery.ToString(), con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgv_karyawan.DataSource = dataTable;
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.DataUpdated += Form2_DataUpdated;
            form2.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgv_karyawan.CurrentRow;

            if (selectedRow != null)
            {
                string idKaryawan = selectedRow.Cells["iDKaryawanDataGridViewTextBoxColumn"].Value.ToString();
                string namaKaryawan = selectedRow.Cells["nmKaryawanDataGridViewTextBoxColumn"].Value.ToString();
                string tglMasukKerja = selectedRow.Cells["tglMasukKerjaDataGridViewTextBoxColumn"].Value.ToString();
                string usia = selectedRow.Cells["usiaDataGridViewTextBoxColumn"].Value.ToString();

                Form2 form2 = new Form2(idKaryawan, namaKaryawan, tglMasukKerja, usia, true);

                form2.DataUpdated += Form2_DataUpdated;

                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin diedit dari DataGridView.");
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_karyawan.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_karyawan.SelectedRows[0];
                string idKaryawan = selectedRow.Cells["iDKaryawanDataGridViewTextBoxColumn"].Value.ToString();

                DialogResult result = MessageBox.Show($"Apakah Anda yakin ingin menghapus data dengan ID Karyawan {idKaryawan}?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand("DELETE FROM Karyawan WHERE IDKaryawan = @ID", con))
                    {
                        con.Open();
                        command.Parameters.AddWithValue("@ID", idKaryawan);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data berhasil dihapus dari database.");

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Karyawan", con);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dgv_karyawan.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin dihapus dari DataGridView.");
            }
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btn_resetFilter_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Karyawan", con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgv_karyawan.DataSource = dataTable;

                txt_filterNamaStart.Text = string.Empty;
                txt_filterNamaEnd.Text = string.Empty;
                txt_filterUsiaStart.Text = string.Empty;
                txt_filterUsiaEnd.Text = string.Empty;

                txt_tglMasukKerjaStart.Text = string.Empty;
                txt_tglMasukKerjaEnd.Text = string.Empty;
            }
        }

        private void Form2_DataUpdated(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Karyawan", con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dgv_karyawan.DataSource = dataTable;
        }

    }
}
