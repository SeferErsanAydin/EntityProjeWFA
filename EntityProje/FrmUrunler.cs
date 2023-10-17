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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Listele()
        {
            dataGridView1.DataSource = (from x in db.TblUrunler
                                        select new
                                        {
                                            x.UrunID,
                                            x.UrunAd,
                                            x.UrunMarka,
                                            x.UrunStok,
                                            x.UrunFiyat,
                                            x.TblKategoriler.KategoriAd,
                                            x.UrunDurum,
                                        }).ToList();
        }

        private void Temizle()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            //CmbKategoriler e Kategorileri getirir
            var kategori = (from x in db.TblKategoriler
                               select new
                               {
                                   x.KategoriID,
                                   x.KategoriAd
                               }).ToList();
            CmbKategoriler.ValueMember = "KategoriID";
            CmbKategoriler.DisplayMember = "KategoriAd";
            CmbKategoriler.DataSource = kategori;

            Temizle();
            Listele();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Temizle();
            Listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
           
            TblUrunler urun = new TblUrunler()
            {
                UrunAd = TxtUrunAdi.Text,
                UrunMarka = TxtUrunMarka.Text,
                UrunStok = Convert.ToInt16(TxtUrunStok.Text),
                UrunFiyat = Convert.ToDecimal(TxtUrunFiyat.Text),
                UrunDurum = Convert.ToBoolean(TxtUrunDurum.Text),
                UrunKategori = Convert.ToInt16(CmbKategoriler.SelectedValue.ToString()),
            };
            db.TblUrunler.Add(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Kaydedildi.");
            Temizle();
            Listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtUrunID.Text);
            TblUrunler silinecekUrun = db.TblUrunler.Find(x);
            db.TblUrunler.Remove(silinecekUrun);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi");
            Temizle();
            Listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtUrunID.Text);
            TblUrunler guncellenecekUrun = db.TblUrunler.Find(x);
            guncellenecekUrun.UrunAd = TxtUrunAdi.Text;
            guncellenecekUrun.UrunMarka = TxtUrunMarka.Text;
            guncellenecekUrun.UrunStok = Convert.ToInt16(TxtUrunStok.Text);
            guncellenecekUrun.UrunFiyat = Convert.ToDecimal(TxtUrunFiyat.Text);
            guncellenecekUrun.UrunKategori = Convert.ToInt16(CmbKategoriler.SelectedValue.ToString());
            guncellenecekUrun.UrunDurum = Convert.ToBoolean(TxtUrunDurum.Text);
            db.SaveChanges();
            MessageBox.Show("Urun Guncellendi");
            Temizle();
            Listele();
        }

        private void BtnCikis_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           TxtUrunID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
           TxtUrunMarka.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
           TxtUrunAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
           TxtUrunStok.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
           TxtUrunFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
           CmbKategoriler.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
           TxtUrunDurum.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
