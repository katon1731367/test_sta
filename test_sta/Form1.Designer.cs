
namespace test_sta
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgv_karyawan = new System.Windows.Forms.DataGridView();
            this.iDKaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmKaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglMasukKerjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.karyawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test_staDataSet = new test_sta.test_staDataSet();
            this.karyawanTableAdapter = new test_sta.test_staDataSetTableAdapters.KaryawanTableAdapter();
            this.lbl_filter_title = new System.Windows.Forms.Label();
            this.txt_filterNamaStart = new System.Windows.Forms.TextBox();
            this.lbl_filterNama = new System.Windows.Forms.Label();
            this.lbl_filterUsia = new System.Windows.Forms.Label();
            this.txt_filterUsiaStart = new System.Windows.Forms.TextBox();
            this.lbl_filterTglMasukKerjaStart = new System.Windows.Forms.Label();
            this.lbl_sdNama = new System.Windows.Forms.Label();
            this.lbl_sdUsia = new System.Windows.Forms.Label();
            this.lbl_sdtglMasukKerja = new System.Windows.Forms.Label();
            this.txt_filterUsiaEnd = new System.Windows.Forms.TextBox();
            this.txt_filterNamaEnd = new System.Windows.Forms.TextBox();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_resetFilter = new System.Windows.Forms.Button();
            this.txt_tglMasukKerjaStart = new System.Windows.Forms.TextBox();
            this.txt_tglMasukKerjaEnd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_karyawan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_staDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_karyawan
            // 
            this.dgv_karyawan.AllowUserToAddRows = false;
            this.dgv_karyawan.AllowUserToDeleteRows = false;
            this.dgv_karyawan.AutoGenerateColumns = false;
            this.dgv_karyawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_karyawan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKaryawanDataGridViewTextBoxColumn,
            this.nmKaryawanDataGridViewTextBoxColumn,
            this.tglMasukKerjaDataGridViewTextBoxColumn,
            this.usiaDataGridViewTextBoxColumn});
            this.dgv_karyawan.DataSource = this.karyawanBindingSource;
            this.dgv_karyawan.Location = new System.Drawing.Point(71, 185);
            this.dgv_karyawan.MultiSelect = false;
            this.dgv_karyawan.Name = "dgv_karyawan";
            this.dgv_karyawan.Size = new System.Drawing.Size(562, 150);
            this.dgv_karyawan.TabIndex = 0;
            // 
            // iDKaryawanDataGridViewTextBoxColumn
            // 
            this.iDKaryawanDataGridViewTextBoxColumn.DataPropertyName = "IDKaryawan";
            this.iDKaryawanDataGridViewTextBoxColumn.HeaderText = "IDKaryawan";
            this.iDKaryawanDataGridViewTextBoxColumn.Name = "iDKaryawanDataGridViewTextBoxColumn";
            this.iDKaryawanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nmKaryawanDataGridViewTextBoxColumn
            // 
            this.nmKaryawanDataGridViewTextBoxColumn.DataPropertyName = "NmKaryawan";
            this.nmKaryawanDataGridViewTextBoxColumn.HeaderText = "NmKaryawan";
            this.nmKaryawanDataGridViewTextBoxColumn.Name = "nmKaryawanDataGridViewTextBoxColumn";
            this.nmKaryawanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tglMasukKerjaDataGridViewTextBoxColumn
            // 
            this.tglMasukKerjaDataGridViewTextBoxColumn.DataPropertyName = "TglMasukKerja";
            this.tglMasukKerjaDataGridViewTextBoxColumn.HeaderText = "TglMasukKerja";
            this.tglMasukKerjaDataGridViewTextBoxColumn.Name = "tglMasukKerjaDataGridViewTextBoxColumn";
            this.tglMasukKerjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usiaDataGridViewTextBoxColumn
            // 
            this.usiaDataGridViewTextBoxColumn.DataPropertyName = "Usia";
            this.usiaDataGridViewTextBoxColumn.HeaderText = "Usia";
            this.usiaDataGridViewTextBoxColumn.Name = "usiaDataGridViewTextBoxColumn";
            this.usiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // karyawanBindingSource
            // 
            this.karyawanBindingSource.DataMember = "Karyawan";
            this.karyawanBindingSource.DataSource = this.test_staDataSet;
            // 
            // test_staDataSet
            // 
            this.test_staDataSet.DataSetName = "test_staDataSet";
            this.test_staDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // karyawanTableAdapter
            // 
            this.karyawanTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_filter_title
            // 
            this.lbl_filter_title.AutoSize = true;
            this.lbl_filter_title.Location = new System.Drawing.Point(68, 61);
            this.lbl_filter_title.Name = "lbl_filter_title";
            this.lbl_filter_title.Size = new System.Drawing.Size(58, 13);
            this.lbl_filter_title.TabIndex = 1;
            this.lbl_filter_title.Text = "Filter Data:";
            // 
            // txt_filterNamaStart
            // 
            this.txt_filterNamaStart.Location = new System.Drawing.Point(194, 88);
            this.txt_filterNamaStart.Name = "txt_filterNamaStart";
            this.txt_filterNamaStart.Size = new System.Drawing.Size(200, 20);
            this.txt_filterNamaStart.TabIndex = 2;
            // 
            // lbl_filterNama
            // 
            this.lbl_filterNama.AutoSize = true;
            this.lbl_filterNama.Location = new System.Drawing.Point(68, 91);
            this.lbl_filterNama.Name = "lbl_filterNama";
            this.lbl_filterNama.Size = new System.Drawing.Size(85, 13);
            this.lbl_filterNama.TabIndex = 3;
            this.lbl_filterNama.Text = "Nama Karyawan";
            // 
            // lbl_filterUsia
            // 
            this.lbl_filterUsia.AutoSize = true;
            this.lbl_filterUsia.Location = new System.Drawing.Point(68, 117);
            this.lbl_filterUsia.Name = "lbl_filterUsia";
            this.lbl_filterUsia.Size = new System.Drawing.Size(28, 13);
            this.lbl_filterUsia.TabIndex = 5;
            this.lbl_filterUsia.Text = "Usia";
            // 
            // txt_filterUsiaStart
            // 
            this.txt_filterUsiaStart.Location = new System.Drawing.Point(194, 114);
            this.txt_filterUsiaStart.Name = "txt_filterUsiaStart";
            this.txt_filterUsiaStart.Size = new System.Drawing.Size(200, 20);
            this.txt_filterUsiaStart.TabIndex = 4;
            // 
            // lbl_filterTglMasukKerjaStart
            // 
            this.lbl_filterTglMasukKerjaStart.AutoSize = true;
            this.lbl_filterTglMasukKerjaStart.Location = new System.Drawing.Point(68, 143);
            this.lbl_filterTglMasukKerjaStart.Name = "lbl_filterTglMasukKerjaStart";
            this.lbl_filterTglMasukKerjaStart.Size = new System.Drawing.Size(108, 13);
            this.lbl_filterTglMasukKerjaStart.TabIndex = 7;
            this.lbl_filterTglMasukKerjaStart.Text = "Tanggal Masuk Kerja";
            // 
            // lbl_sdNama
            // 
            this.lbl_sdNama.AutoSize = true;
            this.lbl_sdNama.Location = new System.Drawing.Point(404, 91);
            this.lbl_sdNama.Name = "lbl_sdNama";
            this.lbl_sdNama.Size = new System.Drawing.Size(23, 13);
            this.lbl_sdNama.TabIndex = 8;
            this.lbl_sdNama.Text = "s/d";
            // 
            // lbl_sdUsia
            // 
            this.lbl_sdUsia.AutoSize = true;
            this.lbl_sdUsia.Location = new System.Drawing.Point(404, 117);
            this.lbl_sdUsia.Name = "lbl_sdUsia";
            this.lbl_sdUsia.Size = new System.Drawing.Size(23, 13);
            this.lbl_sdUsia.TabIndex = 9;
            this.lbl_sdUsia.Text = "s/d";
            // 
            // lbl_sdtglMasukKerja
            // 
            this.lbl_sdtglMasukKerja.AutoSize = true;
            this.lbl_sdtglMasukKerja.Location = new System.Drawing.Point(404, 143);
            this.lbl_sdtglMasukKerja.Name = "lbl_sdtglMasukKerja";
            this.lbl_sdtglMasukKerja.Size = new System.Drawing.Size(23, 13);
            this.lbl_sdtglMasukKerja.TabIndex = 10;
            this.lbl_sdtglMasukKerja.Text = "s/d";
            // 
            // txt_filterUsiaEnd
            // 
            this.txt_filterUsiaEnd.Location = new System.Drawing.Point(433, 114);
            this.txt_filterUsiaEnd.Name = "txt_filterUsiaEnd";
            this.txt_filterUsiaEnd.Size = new System.Drawing.Size(200, 20);
            this.txt_filterUsiaEnd.TabIndex = 12;
            // 
            // txt_filterNamaEnd
            // 
            this.txt_filterNamaEnd.Location = new System.Drawing.Point(433, 88);
            this.txt_filterNamaEnd.Name = "txt_filterNamaEnd";
            this.txt_filterNamaEnd.Size = new System.Drawing.Size(200, 20);
            this.txt_filterNamaEnd.TabIndex = 11;
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(667, 107);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(75, 23);
            this.btn_filter.TabIndex = 16;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(71, 362);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 17;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(166, 362);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 18;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(263, 362);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(364, 362);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 20;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_resetFilter
            // 
            this.btn_resetFilter.Location = new System.Drawing.Point(667, 136);
            this.btn_resetFilter.Name = "btn_resetFilter";
            this.btn_resetFilter.Size = new System.Drawing.Size(75, 23);
            this.btn_resetFilter.TabIndex = 21;
            this.btn_resetFilter.Text = "Reset Filter";
            this.btn_resetFilter.UseVisualStyleBackColor = true;
            this.btn_resetFilter.Click += new System.EventHandler(this.btn_resetFilter_Click);
            // 
            // txt_tglMasukKerjaStart
            // 
            this.txt_tglMasukKerjaStart.Location = new System.Drawing.Point(194, 143);
            this.txt_tglMasukKerjaStart.Name = "txt_tglMasukKerjaStart";
            this.txt_tglMasukKerjaStart.Size = new System.Drawing.Size(200, 20);
            this.txt_tglMasukKerjaStart.TabIndex = 22;
            // 
            // txt_tglMasukKerjaEnd
            // 
            this.txt_tglMasukKerjaEnd.Location = new System.Drawing.Point(433, 143);
            this.txt_tglMasukKerjaEnd.Name = "txt_tglMasukKerjaEnd";
            this.txt_tglMasukKerjaEnd.Size = new System.Drawing.Size(200, 20);
            this.txt_tglMasukKerjaEnd.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_tglMasukKerjaEnd);
            this.Controls.Add(this.txt_tglMasukKerjaStart);
            this.Controls.Add(this.btn_resetFilter);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.txt_filterUsiaEnd);
            this.Controls.Add(this.txt_filterNamaEnd);
            this.Controls.Add(this.lbl_sdtglMasukKerja);
            this.Controls.Add(this.lbl_sdUsia);
            this.Controls.Add(this.lbl_sdNama);
            this.Controls.Add(this.lbl_filterTglMasukKerjaStart);
            this.Controls.Add(this.lbl_filterUsia);
            this.Controls.Add(this.txt_filterUsiaStart);
            this.Controls.Add(this.lbl_filterNama);
            this.Controls.Add(this.txt_filterNamaStart);
            this.Controls.Add(this.lbl_filter_title);
            this.Controls.Add(this.dgv_karyawan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_karyawan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_staDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_karyawan;
        private test_staDataSet test_staDataSet;
        private System.Windows.Forms.BindingSource karyawanBindingSource;
        private test_staDataSetTableAdapters.KaryawanTableAdapter karyawanTableAdapter;
        private System.Windows.Forms.Label lbl_filter_title;
        private System.Windows.Forms.TextBox txt_filterNamaStart;
        private System.Windows.Forms.Label lbl_filterNama;
        private System.Windows.Forms.Label lbl_filterUsia;
        private System.Windows.Forms.TextBox txt_filterUsiaStart;
        private System.Windows.Forms.Label lbl_filterTglMasukKerjaStart;
        private System.Windows.Forms.Label lbl_sdNama;
        private System.Windows.Forms.Label lbl_sdUsia;
        private System.Windows.Forms.Label lbl_sdtglMasukKerja;
        private System.Windows.Forms.TextBox txt_filterUsiaEnd;
        private System.Windows.Forms.TextBox txt_filterNamaEnd;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_resetFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmKaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglMasukKerjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_tglMasukKerjaStart;
        private System.Windows.Forms.TextBox txt_tglMasukKerjaEnd;
    }
}

