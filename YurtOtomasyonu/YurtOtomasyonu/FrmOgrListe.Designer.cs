namespace YurtOtomasyonu
{
    partial class FrmOgrListe
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciTableAdapter = new YurtOtomasyonu.YurtOtomasyonuDataSet9TableAdapters.OgrenciTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.ogrenciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter1 = new YurtOtomasyonu.YurtOtomasyonuDataSet16TableAdapters.OgrenciTableAdapter();
            this.yurtOtomasyonuDataSet17 = new YurtOtomasyonu.YurtOtomasyonuDataSet17();
            this.ogrenciBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter2 = new YurtOtomasyonu.YurtOtomasyonuDataSet17TableAdapters.OgrenciTableAdapter();
            this.yurtOtomasyonuDataSet18 = new YurtOtomasyonu.YurtOtomasyonuDataSet18();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter3 = new YurtOtomasyonu.YurtOtomasyonuDataSet18TableAdapters.OgrenciTableAdapter();
            this.ogrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciDogumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIDDataGridViewTextBoxColumn,
            this.ogrenciAdDataGridViewTextBoxColumn,
            this.ogrenciSoyadDataGridViewTextBoxColumn,
            this.ogrenciTCDataGridViewTextBoxColumn,
            this.ogrenciTelDataGridViewTextBoxColumn,
            this.odaNo,
            this.ogrenciDogumDataGridViewTextBoxColumn,
            this.ogrenciBolum,
            this.ogrenciMailDataGridViewTextBoxColumn,
            this.ogrenciAdresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1103, 325);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(281, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "~ Öğrencilerin Listesi ~";
            // 
            // ogrenciTableAdapter1
            // 
            this.ogrenciTableAdapter1.ClearBeforeFill = true;
            // 
            // yurtOtomasyonuDataSet17
            // 
            this.yurtOtomasyonuDataSet17.DataSetName = "YurtOtomasyonuDataSet17";
            this.yurtOtomasyonuDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBindingSource2
            // 
            this.ogrenciBindingSource2.DataMember = "Ogrenci";
            this.ogrenciBindingSource2.DataSource = this.yurtOtomasyonuDataSet17;
            this.ogrenciBindingSource2.CurrentChanged += new System.EventHandler(this.ogrenciBindingSource2_CurrentChanged);
            // 
            // ogrenciTableAdapter2
            // 
            this.ogrenciTableAdapter2.ClearBeforeFill = true;
            // 
            // yurtOtomasyonuDataSet18
            // 
            this.yurtOtomasyonuDataSet18.DataSetName = "YurtOtomasyonuDataSet18";
            this.yurtOtomasyonuDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurtOtomasyonuDataSet18;
            // 
            // ogrenciTableAdapter3
            // 
            this.ogrenciTableAdapter3.ClearBeforeFill = true;
            // 
            // ogrenciIDDataGridViewTextBoxColumn
            // 
            this.ogrenciIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrenciIDDataGridViewTextBoxColumn.DataPropertyName = "ogrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.HeaderText = "ogrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciIDDataGridViewTextBoxColumn.Name = "ogrenciIDDataGridViewTextBoxColumn";
            this.ogrenciIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrenciAdDataGridViewTextBoxColumn
            // 
            this.ogrenciAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrenciAdDataGridViewTextBoxColumn.DataPropertyName = "ogrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.HeaderText = "ogrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciAdDataGridViewTextBoxColumn.Name = "ogrenciAdDataGridViewTextBoxColumn";
            // 
            // ogrenciSoyadDataGridViewTextBoxColumn
            // 
            this.ogrenciSoyadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrenciSoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.HeaderText = "ogrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciSoyadDataGridViewTextBoxColumn.Name = "ogrenciSoyadDataGridViewTextBoxColumn";
            // 
            // ogrenciTCDataGridViewTextBoxColumn
            // 
            this.ogrenciTCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrenciTCDataGridViewTextBoxColumn.DataPropertyName = "ogrenciTC";
            this.ogrenciTCDataGridViewTextBoxColumn.HeaderText = "ogrenciTC";
            this.ogrenciTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciTCDataGridViewTextBoxColumn.Name = "ogrenciTCDataGridViewTextBoxColumn";
            // 
            // ogrenciTelDataGridViewTextBoxColumn
            // 
            this.ogrenciTelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrenciTelDataGridViewTextBoxColumn.DataPropertyName = "ogrenciTel";
            this.ogrenciTelDataGridViewTextBoxColumn.HeaderText = "ogrenciTel";
            this.ogrenciTelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciTelDataGridViewTextBoxColumn.Name = "ogrenciTelDataGridViewTextBoxColumn";
            // 
            // odaNo
            // 
            this.odaNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.odaNo.DataPropertyName = "odaNo";
            this.odaNo.HeaderText = "odaNo";
            this.odaNo.MinimumWidth = 6;
            this.odaNo.Name = "odaNo";
            // 
            // ogrenciDogumDataGridViewTextBoxColumn
            // 
            this.ogrenciDogumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrenciDogumDataGridViewTextBoxColumn.DataPropertyName = "ogrenciDogum";
            this.ogrenciDogumDataGridViewTextBoxColumn.HeaderText = "ogrenciDogum";
            this.ogrenciDogumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciDogumDataGridViewTextBoxColumn.Name = "ogrenciDogumDataGridViewTextBoxColumn";
            // 
            // ogrenciBolum
            // 
            this.ogrenciBolum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrenciBolum.DataPropertyName = "ogrenciBolum";
            this.ogrenciBolum.HeaderText = "ogrenciBolum";
            this.ogrenciBolum.MinimumWidth = 6;
            this.ogrenciBolum.Name = "ogrenciBolum";
            // 
            // ogrenciMailDataGridViewTextBoxColumn
            // 
            this.ogrenciMailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrenciMailDataGridViewTextBoxColumn.DataPropertyName = "ogrenciMail";
            this.ogrenciMailDataGridViewTextBoxColumn.HeaderText = "ogrenciMail";
            this.ogrenciMailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciMailDataGridViewTextBoxColumn.Name = "ogrenciMailDataGridViewTextBoxColumn";
            // 
            // ogrenciAdresDataGridViewTextBoxColumn
            // 
            this.ogrenciAdresDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrenciAdresDataGridViewTextBoxColumn.DataPropertyName = "ogrenciAdres";
            this.ogrenciAdresDataGridViewTextBoxColumn.HeaderText = "ogrenciAdres";
            this.ogrenciAdresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciAdresDataGridViewTextBoxColumn.Name = "ogrenciAdresDataGridViewTextBoxColumn";
            // 
            // FrmOgrListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(1103, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrListe";
            this.Text = "FrmOgrListe";
            this.Load += new System.EventHandler(this.FrmOgrListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet9TableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource ogrenciBindingSource1;
        private YurtOtomasyonuDataSet16TableAdapters.OgrenciTableAdapter ogrenciTableAdapter1;
        private YurtOtomasyonuDataSet17 yurtOtomasyonuDataSet17;
        private System.Windows.Forms.BindingSource ogrenciBindingSource2;
        private YurtOtomasyonuDataSet17TableAdapters.OgrenciTableAdapter ogrenciTableAdapter2;
        private YurtOtomasyonuDataSet18 yurtOtomasyonuDataSet18;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private YurtOtomasyonuDataSet18TableAdapters.OgrenciTableAdapter ogrenciTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciDogumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciBolum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdresDataGridViewTextBoxColumn;
    }
}