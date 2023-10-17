using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProje
{
    public partial class FrmKategoriler : Form
    {
        public FrmKategoriler()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }
        private void Temizle()
        {
            TxtKategoriAdi.Text = string.Empty;
            TxtKategoriID.Text = string.Empty;
        }
        private void Listele()
        {
            List<TblKategoriler> kategoriler = db.TblKategoriler.ToList();
            dataGridView1.DataSource = kategoriler;
            dataGridView1.Columns["TblUrunler"].Visible = false;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblKategoriler kategori = new TblKategoriler();
            kategori.KategoriAd = TxtKategoriAdi.Text;
            db.TblKategoriler.Add(kategori);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi");
            Temizle();
            Listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtKategoriID.Text);
            TblKategoriler silinecekKategori = db.TblKategoriler.Find(id);
            db.TblKategoriler.Remove(silinecekKategori);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi");
            Temizle();
            Listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtKategoriID.Text);
            TblKategoriler guncellenecekKategori = db.TblKategoriler.Find(id);

            guncellenecekKategori.KategoriAd = TxtKategoriAdi.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi");
            Listele();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmKategoriler_Load(object sender, EventArgs e)
        {
            Temizle();
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtKategoriID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtKategoriAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
