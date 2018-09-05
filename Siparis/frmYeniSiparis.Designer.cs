namespace Siparis
{
    partial class frmYeniSiparis
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSiparisVeren = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSiparisDetayi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sipariş Veren";
            // 
            // txtSiparisVeren
            // 
            this.txtSiparisVeren.Location = new System.Drawing.Point(88, 9);
            this.txtSiparisVeren.Name = "txtSiparisVeren";
            this.txtSiparisVeren.Size = new System.Drawing.Size(196, 20);
            this.txtSiparisVeren.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sipariş Detayı";
            // 
            // txtSiparisDetayi
            // 
            this.txtSiparisDetayi.Location = new System.Drawing.Point(88, 38);
            this.txtSiparisDetayi.Multiline = true;
            this.txtSiparisDetayi.Name = "txtSiparisDetayi";
            this.txtSiparisDetayi.Size = new System.Drawing.Size(196, 112);
            this.txtSiparisDetayi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tarih";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(88, 157);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 5;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(88, 198);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmYeniSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 251);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSiparisDetayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSiparisVeren);
            this.Controls.Add(this.label1);
            this.Name = "frmYeniSiparis";
            this.Text = "frmYeniSiparis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSiparisVeren;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSiparisDetayi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnKaydet;
    }
}