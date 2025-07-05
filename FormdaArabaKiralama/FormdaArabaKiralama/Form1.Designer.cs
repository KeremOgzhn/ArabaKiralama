namespace FormdaArabaKiralama
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtUretimYili = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtYakitTuru = new System.Windows.Forms.TextBox();
            this.txtKiraUcreti = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblUretimYili = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblRenk = new System.Windows.Forms.Label();
            this.lblYakitTuru = new System.Windows.Forms.Label();
            this.lblKiraUcreti = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(100, 20);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(150, 22);
            this.txtPlaka.TabIndex = 1;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(100, 50);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(150, 22);
            this.txtModel.TabIndex = 2;
            // 
            // txtUretimYili
            // 
            this.txtUretimYili.Location = new System.Drawing.Point(100, 80);
            this.txtUretimYili.Name = "txtUretimYili";
            this.txtUretimYili.Size = new System.Drawing.Size(150, 22);
            this.txtUretimYili.TabIndex = 3;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(100, 110);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(150, 22);
            this.txtKm.TabIndex = 4;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(370, 20);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(150, 22);
            this.txtRenk.TabIndex = 5;
            // 
            // txtYakitTuru
            // 
            this.txtYakitTuru.Location = new System.Drawing.Point(370, 50);
            this.txtYakitTuru.Name = "txtYakitTuru";
            this.txtYakitTuru.Size = new System.Drawing.Size(150, 22);
            this.txtYakitTuru.TabIndex = 6;
            // 
            // txtKiraUcreti
            // 
            this.txtKiraUcreti.Location = new System.Drawing.Point(370, 80);
            this.txtKiraUcreti.Name = "txtKiraUcreti";
            this.txtKiraUcreti.Size = new System.Drawing.Size(150, 22);
            this.txtKiraUcreti.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(550, 20);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 30);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(550, 60);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 30);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(550, 100);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 30);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(20, 23);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(44, 17);
            this.lblPlaka.TabIndex = 11;
            this.lblPlaka.Text = "Plaka:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(20, 53);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(47, 17);
            this.lblModel.TabIndex = 12;
            this.lblModel.Text = "Model:";
            // 
            // lblUretimYili
            // 
            this.lblUretimYili.AutoSize = true;
            this.lblUretimYili.Location = new System.Drawing.Point(20, 83);
            this.lblUretimYili.Name = "lblUretimYili";
            this.lblUretimYili.Size = new System.Drawing.Size(81, 17);
            this.lblUretimYili.TabIndex = 13;
            this.lblUretimYili.Text = "Üretim Yılı:";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(20, 113);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(32, 17);
            this.lblKm.TabIndex = 14;
            this.lblKm.Text = "KM:";
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Location = new System.Drawing.Point(290, 23);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(44, 17);
            this.lblRenk.TabIndex = 15;
            this.lblRenk.Text = "Renk:";
            // 
            // lblYakitTuru
            // 
            this.lblYakitTuru.AutoSize = true;
            this.lblYakitTuru.Location = new System.Drawing.Point(290, 53);
            this.lblYakitTuru.Name = "lblYakitTuru";
            this.lblYakitTuru.Size = new System.Drawing.Size(78, 17);
            this.lblYakitTuru.TabIndex = 16;
            this.lblYakitTuru.Text = "Yakıt Türü:";
            // 
            // lblKiraUcreti
            // 
            this.lblKiraUcreti.AutoSize = true;
            this.lblKiraUcreti.Location = new System.Drawing.Point(290, 83);
            this.lblKiraUcreti.Name = "lblKiraUcreti";
            this.lblKiraUcreti.Size = new System.Drawing.Size(85, 17);
            this.lblKiraUcreti.TabIndex = 17;
            this.lblKiraUcreti.Text = "Kira Ücreti:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.lblKiraUcreti);
            this.Controls.Add(this.lblYakitTuru);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblUretimYili);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtKiraUcreti);
            this.Controls.Add(this.txtYakitTuru);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtUretimYili);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Araba Kiralama";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtUretimYili;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtYakitTuru;
        private System.Windows.Forms.TextBox txtKiraUcreti;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblUretimYili;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Label lblYakitTuru;
        private System.Windows.Forms.Label lblKiraUcreti;
    }
}

