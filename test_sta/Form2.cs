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
    public partial class Form2 : Form
    {
        private string connectionString = "Data Source=CHOWDERDANGER;Initial Catalog=test_sta;Integrated Security=True";
        public event EventHandler DataUpdated;
        private bool isEdit;

        public Form2()
        {
            InitializeComponent();

            string fullGuid = Guid.NewGuid().ToString();
            string truncatedGuid = fullGuid.Substring(0, 30);
            txt_IDKaryawan.Text = truncatedGuid;
        }


        public Form2(string idKaryawan, string namaKaryawan, string tglMasukKerja, string usia, bool isEdit)
        {
            InitializeComponent();

            this.isEdit = isEdit;

            txt_IDKaryawan.Text = idKaryawan;
            txt_namaKaryawan.Text = namaKaryawan;
            dtp_tglMasukKerja.Text = tglMasukKerja;
            txt_usiaKaryawan.Text = usia;

            if (isEdit)
            {
                this.Text = "Edit Karyawan";
                btn_save.Text = "Update";
            }
            else
            {
                this.Text = "Tambah Karyawan";
                btn_save.Text = "Simpan";
            }
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string idKaryawan = txt_IDKaryawan.Text;
                string namaKaryawan = txt_namaKaryawan.Text;
                string tglMasukKerja = dtp_tglMasukKerja.Value.ToString("yyyy-MM-dd");
                string usia = txt_usiaKaryawan.Text;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    if (isEdit)
                    {
                        string updateQuery = "UPDATE Karyawan SET NmKaryawan = @Nama, TglMasukKerja = @TglMasukKerja, Usia = @Usia WHERE IDKaryawan = @ID";

                        using (SqlCommand command = new SqlCommand(updateQuery, con))
                        {
                            command.Parameters.AddWithValue("@ID", idKaryawan);
                            command.Parameters.AddWithValue("@Nama", namaKaryawan);
                            command.Parameters.AddWithValue("@TglMasukKerja", tglMasukKerja);
                            command.Parameters.AddWithValue("@Usia", usia);

                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO Karyawan (IDKaryawan, NmKaryawan, TglMasukKerja, Usia) VALUES (@ID, @Nama, @TglMasukKerja, @Usia)";

                        using (SqlCommand command = new SqlCommand(insertQuery, con))
                        {
                            command.Parameters.AddWithValue("@ID", idKaryawan);
                            command.Parameters.AddWithValue("@Nama", namaKaryawan);
                            command.Parameters.AddWithValue("@TglMasukKerja", tglMasukKerja);
                            command.Parameters.AddWithValue("@Usia", usia);

                            command.ExecuteNonQuery();
                        }
                    }
                }

                OnDataUpdated();
                MessageBox.Show(isEdit ? "Data berhasil diupdate." : "Data berhasil disimpan ke database.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void OnDataUpdated()
        {
            DataUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnDataUpdated();
        }
    }
}
