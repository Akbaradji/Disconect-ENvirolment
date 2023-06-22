namespace Disconect_ENvirolment
{
    partial class Data_Status_Mahasiswa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbxNama = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.Label();
            this.cbxStatusMahasiswa = new System.Windows.Forms.Label();
            this.cbxTahunMasuk = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(127, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(485, 180);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbxNama
            // 
            this.cbxNama.AutoSize = true;
            this.cbxNama.Location = new System.Drawing.Point(161, 258);
            this.cbxNama.Name = "cbxNama";
            this.cbxNama.Size = new System.Drawing.Size(115, 16);
            this.cbxNama.TabIndex = 1;
            this.cbxNama.Text = "Nama Mahasiswa";
            // 
            // txtNIM
            // 
            this.txtNIM.AutoSize = true;
            this.txtNIM.Location = new System.Drawing.Point(161, 295);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(154, 16);
            this.txtNIM.TabIndex = 2;
            this.txtNIM.Text = "Nomer Induk Mahasiswa";
            // 
            // cbxStatusMahasiswa
            // 
            this.cbxStatusMahasiswa.AutoSize = true;
            this.cbxStatusMahasiswa.Location = new System.Drawing.Point(161, 332);
            this.cbxStatusMahasiswa.Name = "cbxStatusMahasiswa";
            this.cbxStatusMahasiswa.Size = new System.Drawing.Size(115, 16);
            this.cbxStatusMahasiswa.TabIndex = 3;
            this.cbxStatusMahasiswa.Text = "Status Mahasiswa";
            // 
            // cbxTahunMasuk
            // 
            this.cbxTahunMasuk.AutoSize = true;
            this.cbxTahunMasuk.Location = new System.Drawing.Point(161, 368);
            this.cbxTahunMasuk.Name = "cbxTahunMasuk";
            this.cbxTahunMasuk.Size = new System.Drawing.Size(88, 16);
            this.cbxTahunMasuk.TabIndex = 4;
            this.cbxTahunMasuk.Text = "Tahun Masuk";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(321, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(321, 324);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(162, 24);
            this.comboBox3.TabIndex = 7;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(321, 368);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(162, 24);
            this.comboBox4.TabIndex = 8;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(523, 311);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(73, 37);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(523, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 37);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(523, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 37);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(638, 36);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(86, 37);
            this.btnOpen.TabIndex = 14;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button3_Click);
            // 
            // Data_Status_Mahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbxTahunMasuk);
            this.Controls.Add(this.cbxStatusMahasiswa);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.cbxNama);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Data_Status_Mahasiswa";
            this.Text = "Data_Status_Mahasiswa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label cbxNama;
        private System.Windows.Forms.Label txtNIM;
        private System.Windows.Forms.Label cbxStatusMahasiswa;
        private System.Windows.Forms.Label cbxTahunMasuk;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
    }
}