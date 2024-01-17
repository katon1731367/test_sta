
namespace test_sta
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtp_tglMasukKerja = new System.Windows.Forms.DateTimePicker();
            this.lbl_filterTglMasukKerja = new System.Windows.Forms.Label();
            this.lbl_UsiaKaryawan = new System.Windows.Forms.Label();
            this.txt_usiaKaryawan = new System.Windows.Forms.TextBox();
            this.lbl_NamaKaryawan = new System.Windows.Forms.Label();
            this.txt_namaKaryawan = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_IDKaryawan = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_tglMasukKerja
            // 
            this.dtp_tglMasukKerja.Location = new System.Drawing.Point(511, 62);
            this.dtp_tglMasukKerja.Name = "dtp_tglMasukKerja";
            this.dtp_tglMasukKerja.Size = new System.Drawing.Size(200, 20);
            this.dtp_tglMasukKerja.TabIndex = 20;
            // 
            // lbl_filterTglMasukKerja
            // 
            this.lbl_filterTglMasukKerja.AutoSize = true;
            this.lbl_filterTglMasukKerja.Location = new System.Drawing.Point(385, 62);
            this.lbl_filterTglMasukKerja.Name = "lbl_filterTglMasukKerja";
            this.lbl_filterTglMasukKerja.Size = new System.Drawing.Size(108, 13);
            this.lbl_filterTglMasukKerja.TabIndex = 19;
            this.lbl_filterTglMasukKerja.Text = "Tanggal Masuk Kerja";
            // 
            // lbl_UsiaKaryawan
            // 
            this.lbl_UsiaKaryawan.AutoSize = true;
            this.lbl_UsiaKaryawan.Location = new System.Drawing.Point(385, 36);
            this.lbl_UsiaKaryawan.Name = "lbl_UsiaKaryawan";
            this.lbl_UsiaKaryawan.Size = new System.Drawing.Size(28, 13);
            this.lbl_UsiaKaryawan.TabIndex = 18;
            this.lbl_UsiaKaryawan.Text = "Usia";
            // 
            // txt_usiaKaryawan
            // 
            this.txt_usiaKaryawan.Location = new System.Drawing.Point(511, 33);
            this.txt_usiaKaryawan.Name = "txt_usiaKaryawan";
            this.txt_usiaKaryawan.Size = new System.Drawing.Size(200, 20);
            this.txt_usiaKaryawan.TabIndex = 17;
            // 
            // lbl_NamaKaryawan
            // 
            this.lbl_NamaKaryawan.AutoSize = true;
            this.lbl_NamaKaryawan.Location = new System.Drawing.Point(33, 58);
            this.lbl_NamaKaryawan.Name = "lbl_NamaKaryawan";
            this.lbl_NamaKaryawan.Size = new System.Drawing.Size(85, 13);
            this.lbl_NamaKaryawan.TabIndex = 16;
            this.lbl_NamaKaryawan.Text = "Nama Karyawan";
            // 
            // txt_namaKaryawan
            // 
            this.txt_namaKaryawan.Location = new System.Drawing.Point(159, 55);
            this.txt_namaKaryawan.Name = "txt_namaKaryawan";
            this.txt_namaKaryawan.Size = new System.Drawing.Size(200, 20);
            this.txt_namaKaryawan.TabIndex = 15;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(33, 32);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 22;
            this.lbl_id.Text = "ID";
            // 
            // txt_IDKaryawan
            // 
            this.txt_IDKaryawan.Location = new System.Drawing.Point(159, 29);
            this.txt_IDKaryawan.Name = "txt_IDKaryawan";
            this.txt_IDKaryawan.ReadOnly = true;
            this.txt_IDKaryawan.Size = new System.Drawing.Size(200, 20);
            this.txt_IDKaryawan.TabIndex = 21;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(636, 109);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 160);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_IDKaryawan);
            this.Controls.Add(this.dtp_tglMasukKerja);
            this.Controls.Add(this.lbl_filterTglMasukKerja);
            this.Controls.Add(this.lbl_UsiaKaryawan);
            this.Controls.Add(this.txt_usiaKaryawan);
            this.Controls.Add(this.lbl_NamaKaryawan);
            this.Controls.Add(this.txt_namaKaryawan);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_tglMasukKerja;
        private System.Windows.Forms.Label lbl_filterTglMasukKerja;
        private System.Windows.Forms.Label lbl_UsiaKaryawan;
        private System.Windows.Forms.TextBox txt_usiaKaryawan;
        private System.Windows.Forms.Label lbl_NamaKaryawan;
        private System.Windows.Forms.TextBox txt_namaKaryawan;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_IDKaryawan;
        private System.Windows.Forms.Button btn_save;
    }
}