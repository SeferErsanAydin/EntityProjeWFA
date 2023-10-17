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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            LblKategoriSayi.Text = db.TblKategoriler.Count().ToString();
            LblUrunSayi.Text = db.TblUrunler.Count().ToString();

            LblAktifMusteri.Text = db.TblMusteriler.Count(x => x.MusteriDurum == true).ToString();
            LblPasifMusteri.Text = db.TblMusteriler.Count(x => x.MusteriDurum == false).ToString();

            LblBeyazesyaSayisi.Text = db.TblUrunler.Count(x=> x.UrunKategori == 1).ToString();
            LblToplamBuzdolabiSayisi.Text = db.TblUrunler.Count(x=>x.UrunAd == "Buzdolabı").ToString();

            LblToplamStok.Text = db.TblUrunler.Sum(x => x.UrunStok).ToString();

            LblEnYuksekFiyatliUrun.Text = (from x in db.TblUrunler orderby x.UrunFiyat descending select x.UrunAd).FirstOrDefault();
            LblEnDusukFiyatliUrun.Text = (from x in db.TblUrunler orderby x.UrunFiyat ascending select x.UrunAd).FirstOrDefault();

            LblKasaMiktar.Text = db.TblSatislar.Sum(x => x.ToplamFiyat).ToString() + "TL";
            LblSehirSayisi.Text = (from x in db.TblMusteriler select x.MusteriSehir).Distinct().Count().ToString();

            LblEnFazlaUrunluMarka.Text = db.MARKAGETIR().FirstOrDefault().ToString();
        }
    }
}
