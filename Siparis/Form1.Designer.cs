﻿namespace Siparis
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümSiparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniSiparişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümÜrünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÜrünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişlerToolStripMenuItem,
            this.ürünlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparişlerToolStripMenuItem
            // 
            this.siparişlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümSiparişlerToolStripMenuItem,
            this.yeniSiparişToolStripMenuItem});
            this.siparişlerToolStripMenuItem.Name = "siparişlerToolStripMenuItem";
            this.siparişlerToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.siparişlerToolStripMenuItem.Text = "Siparişler";
            // 
            // tümSiparişlerToolStripMenuItem
            // 
            this.tümSiparişlerToolStripMenuItem.Name = "tümSiparişlerToolStripMenuItem";
            this.tümSiparişlerToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.tümSiparişlerToolStripMenuItem.Text = "Tüm Siparişler";
            this.tümSiparişlerToolStripMenuItem.Click += new System.EventHandler(this.tümSiparişlerToolStripMenuItem_Click);
            // 
            // yeniSiparişToolStripMenuItem
            // 
            this.yeniSiparişToolStripMenuItem.Name = "yeniSiparişToolStripMenuItem";
            this.yeniSiparişToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.yeniSiparişToolStripMenuItem.Text = "Yeni Sipariş";
            this.yeniSiparişToolStripMenuItem.Click += new System.EventHandler(this.yeniSiparişToolStripMenuItem_Click);
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümÜrünlerToolStripMenuItem,
            this.yeniÜrünToolStripMenuItem});
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            // 
            // tümÜrünlerToolStripMenuItem
            // 
            this.tümÜrünlerToolStripMenuItem.Name = "tümÜrünlerToolStripMenuItem";
            this.tümÜrünlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tümÜrünlerToolStripMenuItem.Text = "Tüm Ürünler";
            this.tümÜrünlerToolStripMenuItem.Click += new System.EventHandler(this.tümÜrünlerToolStripMenuItem_Click);
            // 
            // yeniÜrünToolStripMenuItem
            // 
            this.yeniÜrünToolStripMenuItem.Name = "yeniÜrünToolStripMenuItem";
            this.yeniÜrünToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniÜrünToolStripMenuItem.Text = "Yeni Ürün";
            this.yeniÜrünToolStripMenuItem.Click += new System.EventHandler(this.yeniÜrünToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Sipariş Uygulaması";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümSiparişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniSiparişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümÜrünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniÜrünToolStripMenuItem;
    }
}

