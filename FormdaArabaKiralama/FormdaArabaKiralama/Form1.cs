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



namespace FormdaArabaKiralama
{
    public partial class Form1 : Form
    {
        private SqlConnection con;
        private SqlDataAdapter da;
        private SqlCommand cmd;
        private DataSet ds;

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("server=.;initial catalog=ArabaKiralama;integrated security=sspi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM araba", con);
            ds = new DataSet();
            da.Fill(ds, "araba");
            dataGridView1.DataSource = ds.Tables["araba"];
            con.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO araba (plaka, model, uretimYili, km, renk, yakitTuru, kiraUcreti) VALUES (@plaka, @model, @uretimYili, @km, @renk, @yakitTuru, @kiraUcreti)", con);
            cmd.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            cmd.Parameters.AddWithValue("@model", txtModel.Text);
            cmd.Parameters.AddWithValue("@uretimYili", int.Parse(txtUretimYili.Text));
            cmd.Parameters.AddWithValue("@km", int.Parse(txtKm.Text));
            cmd.Parameters.AddWithValue("@renk", txtRenk.Text);
            cmd.Parameters.AddWithValue("@yakitTuru", txtYakitTuru.Text);
            cmd.Parameters.AddWithValue("@kiraUcreti", decimal.Parse(txtKiraUcreti.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncellenecek kayıt seçilmedi.");
                return;
            }

            int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

            con.Open();
            cmd = new SqlCommand("UPDATE araba SET plaka=@plaka, model=@model, uretimYili=@uretimYili, km=@km, renk=@renk, yakitTuru=@yakitTuru, kiraUcreti=@kiraUcreti WHERE id=@id", con);
            cmd.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            cmd.Parameters.AddWithValue("@model", txtModel.Text);
            cmd.Parameters.AddWithValue("@uretimYili", int.Parse(txtUretimYili.Text));
            cmd.Parameters.AddWithValue("@km", int.Parse(txtKm.Text));
            cmd.Parameters.AddWithValue("@renk", txtRenk.Text);
            cmd.Parameters.AddWithValue("@yakitTuru", txtYakitTuru.Text);
            cmd.Parameters.AddWithValue("@kiraUcreti", decimal.Parse(txtKiraUcreti.Text));
            cmd.Parameters.AddWithValue("@id", selectedId);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek kayıt seçilmedi.");
                return;
            }
            int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            con.Open();
            cmd = new SqlCommand("DELETE FROM araba WHERE id=@id", con);
            cmd.Parameters.AddWithValue("@id", selectedId);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtPlaka.Text = row.Cells["plaka"].Value.ToString();
                txtModel.Text = row.Cells["model"].Value.ToString();
                txtUretimYili.Text = row.Cells["uretimYili"].Value.ToString();
                txtKm.Text = row.Cells["km"].Value.ToString();
                txtRenk.Text = row.Cells["renk"].Value.ToString();
                txtYakitTuru.Text = row.Cells["yakitTuru"].Value.ToString();
                txtKiraUcreti.Text = row.Cells["kiraUcreti"].Value.ToString();
            }
        }
    }
}

