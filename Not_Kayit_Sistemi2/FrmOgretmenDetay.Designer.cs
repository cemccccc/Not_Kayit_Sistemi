namespace Not_Kayit_Sistemi2
{
	partial class FrmOgretmenDetay
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.TxtSoyad = new System.Windows.Forms.TextBox();
			this.TxtAd = new System.Windows.Forms.TextBox();
			this.MskNumara = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.TxtSinav3 = new System.Windows.Forms.TextBox();
			this.TxtSinav1 = new System.Windows.Forms.TextBox();
			this.TxtSinav2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.LblKalanSayisi = new System.Windows.Forms.Label();
			this.LblGecenSayisi = new System.Windows.Forms.Label();
			this.LblOrtalama = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.oGRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.oGRNUMARADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.oGRADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.oGRSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.oGRS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.oGRS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.oGRS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.oRTALAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dURUMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.tBLDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dbNotKayitDataSet = new Not_Kayit_Sistemi2.DbNotKayitDataSet();
			this.tBLDERSTableAdapter = new Not_Kayit_Sistemi2.DbNotKayitDataSetTableAdapters.TBLDERSTableAdapter();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBLDERSBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.TxtSoyad);
			this.groupBox1.Controls.Add(this.TxtAd);
			this.groupBox1.Controls.Add(this.MskNumara);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(245, 213);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Öğrenci Ekle";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(85, 143);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(126, 34);
			this.button1.TabIndex = 4;
			this.button1.Text = "Öğrenci Kaydet";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// TxtSoyad
			// 
			this.TxtSoyad.Location = new System.Drawing.Point(85, 101);
			this.TxtSoyad.Name = "TxtSoyad";
			this.TxtSoyad.Size = new System.Drawing.Size(126, 26);
			this.TxtSoyad.TabIndex = 3;
			// 
			// TxtAd
			// 
			this.TxtAd.Location = new System.Drawing.Point(85, 72);
			this.TxtAd.Name = "TxtAd";
			this.TxtAd.Size = new System.Drawing.Size(126, 26);
			this.TxtAd.TabIndex = 2;
			// 
			// MskNumara
			// 
			this.MskNumara.Location = new System.Drawing.Point(85, 42);
			this.MskNumara.Mask = "0000";
			this.MskNumara.Name = "MskNumara";
			this.MskNumara.Size = new System.Drawing.Size(126, 26);
			this.MskNumara.TabIndex = 1;
			this.MskNumara.ValidatingType = typeof(int);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 18);
			this.label3.TabIndex = 0;
			this.label3.Text = "Soyad:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "Ad:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Numara:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.TxtSinav3);
			this.groupBox2.Controls.Add(this.TxtSinav1);
			this.groupBox2.Controls.Add(this.TxtSinav2);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(264, 13);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(245, 213);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Sınav Notları";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(85, 143);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(126, 34);
			this.button2.TabIndex = 8;
			this.button2.Text = "Güncelle";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// TxtSinav3
			// 
			this.TxtSinav3.Location = new System.Drawing.Point(85, 100);
			this.TxtSinav3.Name = "TxtSinav3";
			this.TxtSinav3.Size = new System.Drawing.Size(126, 26);
			this.TxtSinav3.TabIndex = 7;
			// 
			// TxtSinav1
			// 
			this.TxtSinav1.Location = new System.Drawing.Point(85, 42);
			this.TxtSinav1.Name = "TxtSinav1";
			this.TxtSinav1.Size = new System.Drawing.Size(126, 26);
			this.TxtSinav1.TabIndex = 5;
			// 
			// TxtSinav2
			// 
			this.TxtSinav2.Location = new System.Drawing.Point(85, 71);
			this.TxtSinav2.Name = "TxtSinav2";
			this.TxtSinav2.Size = new System.Drawing.Size(126, 26);
			this.TxtSinav2.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 18);
			this.label4.TabIndex = 0;
			this.label4.Text = "Sınav3:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 75);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 18);
			this.label5.TabIndex = 0;
			this.label5.Text = "Sınav2:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 45);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 18);
			this.label6.TabIndex = 0;
			this.label6.Text = "Sınav1:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.LblKalanSayisi);
			this.groupBox3.Controls.Add(this.LblGecenSayisi);
			this.groupBox3.Controls.Add(this.LblOrtalama);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Location = new System.Drawing.Point(515, 13);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(245, 213);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "İstatistik";
			// 
			// LblKalanSayisi
			// 
			this.LblKalanSayisi.AutoSize = true;
			this.LblKalanSayisi.Location = new System.Drawing.Point(160, 109);
			this.LblKalanSayisi.Name = "LblKalanSayisi";
			this.LblKalanSayisi.Size = new System.Drawing.Size(28, 18);
			this.LblKalanSayisi.TabIndex = 1;
			this.LblKalanSayisi.Text = "00";
			// 
			// LblGecenSayisi
			// 
			this.LblGecenSayisi.AutoSize = true;
			this.LblGecenSayisi.Location = new System.Drawing.Point(160, 80);
			this.LblGecenSayisi.Name = "LblGecenSayisi";
			this.LblGecenSayisi.Size = new System.Drawing.Size(28, 18);
			this.LblGecenSayisi.TabIndex = 1;
			this.LblGecenSayisi.Text = "00";
			// 
			// LblOrtalama
			// 
			this.LblOrtalama.AutoSize = true;
			this.LblOrtalama.Location = new System.Drawing.Point(160, 50);
			this.LblOrtalama.Name = "LblOrtalama";
			this.LblOrtalama.Size = new System.Drawing.Size(28, 18);
			this.LblOrtalama.TabIndex = 1;
			this.LblOrtalama.Text = "00";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(52, 109);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(98, 18);
			this.label7.TabIndex = 0;
			this.label7.Text = "Kalan Sayısı:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(52, 80);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(102, 18);
			this.label8.TabIndex = 0;
			this.label8.Text = "Geçen Sayısı:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(52, 50);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 18);
			this.label9.TabIndex = 0;
			this.label9.Text = "Ortalama:";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dataGridView1);
			this.groupBox4.Location = new System.Drawing.Point(13, 233);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(747, 218);
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Öğrenci Bilgileri";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oGRIDDataGridViewTextBoxColumn,
            this.oGRNUMARADataGridViewTextBoxColumn,
            this.oGRADDataGridViewTextBoxColumn,
            this.oGRSOYADDataGridViewTextBoxColumn,
            this.oGRS1DataGridViewTextBoxColumn,
            this.oGRS2DataGridViewTextBoxColumn,
            this.oGRS3DataGridViewTextBoxColumn,
            this.oRTALAMADataGridViewTextBoxColumn,
            this.dURUMDataGridViewCheckBoxColumn});
			this.dataGridView1.DataSource = this.tBLDERSBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 22);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(741, 193);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// oGRIDDataGridViewTextBoxColumn
			// 
			this.oGRIDDataGridViewTextBoxColumn.DataPropertyName = "OGRID";
			this.oGRIDDataGridViewTextBoxColumn.HeaderText = "OGRID";
			this.oGRIDDataGridViewTextBoxColumn.Name = "oGRIDDataGridViewTextBoxColumn";
			this.oGRIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// oGRNUMARADataGridViewTextBoxColumn
			// 
			this.oGRNUMARADataGridViewTextBoxColumn.DataPropertyName = "OGRNUMARA";
			this.oGRNUMARADataGridViewTextBoxColumn.HeaderText = "OGRNUMARA";
			this.oGRNUMARADataGridViewTextBoxColumn.Name = "oGRNUMARADataGridViewTextBoxColumn";
			// 
			// oGRADDataGridViewTextBoxColumn
			// 
			this.oGRADDataGridViewTextBoxColumn.DataPropertyName = "OGRAD";
			this.oGRADDataGridViewTextBoxColumn.HeaderText = "OGRAD";
			this.oGRADDataGridViewTextBoxColumn.Name = "oGRADDataGridViewTextBoxColumn";
			// 
			// oGRSOYADDataGridViewTextBoxColumn
			// 
			this.oGRSOYADDataGridViewTextBoxColumn.DataPropertyName = "OGRSOYAD";
			this.oGRSOYADDataGridViewTextBoxColumn.HeaderText = "OGRSOYAD";
			this.oGRSOYADDataGridViewTextBoxColumn.Name = "oGRSOYADDataGridViewTextBoxColumn";
			// 
			// oGRS1DataGridViewTextBoxColumn
			// 
			this.oGRS1DataGridViewTextBoxColumn.DataPropertyName = "OGRS1";
			this.oGRS1DataGridViewTextBoxColumn.HeaderText = "OGRS1";
			this.oGRS1DataGridViewTextBoxColumn.Name = "oGRS1DataGridViewTextBoxColumn";
			// 
			// oGRS2DataGridViewTextBoxColumn
			// 
			this.oGRS2DataGridViewTextBoxColumn.DataPropertyName = "OGRS2";
			this.oGRS2DataGridViewTextBoxColumn.HeaderText = "OGRS2";
			this.oGRS2DataGridViewTextBoxColumn.Name = "oGRS2DataGridViewTextBoxColumn";
			// 
			// oGRS3DataGridViewTextBoxColumn
			// 
			this.oGRS3DataGridViewTextBoxColumn.DataPropertyName = "OGRS3";
			this.oGRS3DataGridViewTextBoxColumn.HeaderText = "OGRS3";
			this.oGRS3DataGridViewTextBoxColumn.Name = "oGRS3DataGridViewTextBoxColumn";
			// 
			// oRTALAMADataGridViewTextBoxColumn
			// 
			this.oRTALAMADataGridViewTextBoxColumn.DataPropertyName = "ORTALAMA";
			this.oRTALAMADataGridViewTextBoxColumn.HeaderText = "ORTALAMA";
			this.oRTALAMADataGridViewTextBoxColumn.Name = "oRTALAMADataGridViewTextBoxColumn";
			// 
			// dURUMDataGridViewCheckBoxColumn
			// 
			this.dURUMDataGridViewCheckBoxColumn.DataPropertyName = "DURUM";
			this.dURUMDataGridViewCheckBoxColumn.HeaderText = "DURUM";
			this.dURUMDataGridViewCheckBoxColumn.Name = "dURUMDataGridViewCheckBoxColumn";
			// 
			// tBLDERSBindingSource
			// 
			this.tBLDERSBindingSource.DataMember = "TBLDERS";
			this.tBLDERSBindingSource.DataSource = this.dbNotKayitDataSet;
			// 
			// dbNotKayitDataSet
			// 
			this.dbNotKayitDataSet.DataSetName = "DbNotKayitDataSet";
			this.dbNotKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tBLDERSTableAdapter
			// 
			this.tBLDERSTableAdapter.ClearBeforeFill = true;
			// 
			// FrmOgretmenDetay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Salmon;
			this.ClientSize = new System.Drawing.Size(770, 463);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmOgretmenDetay";
			this.Text = "FrmOgretmenDetay";
			this.Load += new System.EventHandler(this.FrmOgretmenDetay_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBLDERSBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox TxtSoyad;
		private System.Windows.Forms.TextBox TxtAd;
		private System.Windows.Forms.MaskedTextBox MskNumara;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox TxtSinav3;
		private System.Windows.Forms.TextBox TxtSinav1;
		private System.Windows.Forms.TextBox TxtSinav2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label LblKalanSayisi;
		private System.Windows.Forms.Label LblGecenSayisi;
		private System.Windows.Forms.Label LblOrtalama;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView dataGridView1;
		private DbNotKayitDataSet dbNotKayitDataSet;
		private System.Windows.Forms.BindingSource tBLDERSBindingSource;
		private DbNotKayitDataSetTableAdapters.TBLDERSTableAdapter tBLDERSTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn oGRIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn oGRNUMARADataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn oGRADDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn oGRSOYADDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn oGRS1DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn oGRS2DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn oGRS3DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn oRTALAMADataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dURUMDataGridViewCheckBoxColumn;
	}
}