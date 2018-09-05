namespace Siparis
{
    partial class frmSiparisler
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
            this.siparislerDbDataSet = new Siparis.SiparislerDbDataSet();
            this.siparislerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparislerTableAdapter = new Siparis.SiparislerDbDataSetTableAdapters.SiparislerTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisVerenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisDetayiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparislerDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparislerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.siparisVerenDataGridViewTextBoxColumn,
            this.siparisDetayiDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.siparislerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // siparislerDbDataSet
            // 
            this.siparislerDbDataSet.DataSetName = "SiparislerDbDataSet";
            this.siparislerDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparislerBindingSource
            // 
            this.siparislerBindingSource.DataMember = "Siparisler";
            this.siparislerBindingSource.DataSource = this.siparislerDbDataSet;
            // 
            // siparislerTableAdapter
            // 
            this.siparislerTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siparisVerenDataGridViewTextBoxColumn
            // 
            this.siparisVerenDataGridViewTextBoxColumn.DataPropertyName = "SiparisVeren";
            this.siparisVerenDataGridViewTextBoxColumn.HeaderText = "SiparisVeren";
            this.siparisVerenDataGridViewTextBoxColumn.Name = "siparisVerenDataGridViewTextBoxColumn";
            // 
            // siparisDetayiDataGridViewTextBoxColumn
            // 
            this.siparisDetayiDataGridViewTextBoxColumn.DataPropertyName = "SiparisDetayi";
            this.siparisDetayiDataGridViewTextBoxColumn.HeaderText = "SiparisDetayi";
            this.siparisDetayiDataGridViewTextBoxColumn.Name = "siparisDetayiDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // frmSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSiparisler";
            this.Text = "Tüm Siparişler";
            this.Load += new System.EventHandler(this.frmSiparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparislerDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparislerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SiparislerDbDataSet siparislerDbDataSet;
        private System.Windows.Forms.BindingSource siparislerBindingSource;
        private SiparislerDbDataSetTableAdapters.SiparislerTableAdapter siparislerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisVerenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisDetayiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
    }
}