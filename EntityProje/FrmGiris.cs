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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            //var sorgu = from x in db.TblAdminler where x.KullaniciIsim == TxtKullaniciAd.Text && x.KullaniciSifre == TxtSifre.Text select x;
            //if (sorgu.Any())
            //{
            //    FrmAnaForm frm = new FrmAnaForm();
            //    frm.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Hatalı Giriş");
            //}

            if (db.TblAdminler.Where(x => x.KullaniciIsim == TxtKullaniciAd.Text && x.KullaniciSifre == TxtSifre.Text).FirstOrDefault() != null)
            {
                FrmAnaForm frm = new FrmAnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }

        DbEntityUrunEntities db;

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            db = new DbEntityUrunEntities();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
