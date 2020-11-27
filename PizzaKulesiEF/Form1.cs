using PizzaKulesiEF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaKulesiEF
{
    public partial class Form1 : Form
    {
        PizzaKulesiContext db = new PizzaKulesiContext();
        public Form1()
        {
            InitializeComponent();
            dgvSiparisler.AutoGenerateColumns = false;
            SiparisleriListele();
            PizzaCesitleriListele();
            EkstraMalzemelerListele();
        }

        private void EkstraMalzemelerListele()
        {
            clbEkstraMalzemeler.DataSource = db.EkstraMalzemeler.ToList();
            clbEkstraMalzemeler.DisplayMember = "MalzemeAd";
        }

        private void PizzaCesitleriListele()
        {
            cboPizzaCesidi.DataSource = db.PizzaCesitler.ToList();

        }

        private void SiparisleriListele()
        {
            dgvSiparisler.DataSource = db.Siparisler.ToList();

        }

        private void chkTeslimEdilenleriGizle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTeslimEdilenleriGizle.Checked)
                dgvSiparisler.DataSource = db.Siparisler.SqlQuery("SELECT * FROM Siparisler WHERE TeslimDurumu=0").ToList();
            else
                SiparisleriListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtMusteriAdSoyad.Text == "" || txtTeslimatAdresi.Text == "")
            {
                MessageBox.Show("Lütfen Ad ve Adres Giriniz");
                return;
            }

            bool teslimDurumu = chkTeslimEdildi.Checked;
            List<EkstraMalzeme> ekstralar = clbEkstraMalzemeler.CheckedItems.OfType<EkstraMalzeme>().ToList();


            db.Siparisler.Add(new Siparis
            {
                MusteriAdSoyad = txtMusteriAdSoyad.Text,
                Adres = txtTeslimatAdresi.Text,
                TeslimDurumu = teslimDurumu,
                PizzaCesitId = (int)cboPizzaCesidi.SelectedValue,
                EkstraMalzemeler = ekstralar
            });
            db.SaveChanges();
            SiparisleriListele();
            FormuTemizle();
        }

        private void FormuTemizle()
        {
            txtMusteriAdSoyad.Clear();
            txtTeslimatAdresi.Clear();
            clbEkstraMalzemeler.ClearSelected();
            chkTeslimEdildi.Checked = false;
            for (int i = 0; i < clbEkstraMalzemeler.Items.Count; i++)
                clbEkstraMalzemeler.SetItemChecked(i, false);
            cboPizzaCesidi.SelectedIndex = 0;
        }

        private void DuzenlemeModundanCik()
        {
            btnEkle.Visible = true;
            btnIptal.Visible = false;
            btnKaydet.Visible = false;
            btnSil.Enabled = true;
            btnDuzenle.Enabled = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvSiparisler.SelectedRows.Count<=0)
            {
                return;
            }
            int silinen =dgvSiparisler.SelectedRows[0].Index;
            db.Siparisler.Remove((Siparis)dgvSiparisler.SelectedRows[0].DataBoundItem);
            db.SaveChanges();
            SiparisleriListele();

            if (silinen < db.Siparisler.Count() )
            {
                dgvSiparisler.Rows[silinen].Selected = true;
            }
            else if(db.Siparisler.Count()>1)
            {
                dgvSiparisler.Rows[silinen-1].Selected = true;
            }
            
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvSiparisler.SelectedRows.Count <= 0)
            {
                return;
            }

            FormuTemizle();
            btnSil.Enabled = false;
            btnDuzenle.Enabled = false;
            btnIptal.Visible = true;
            btnKaydet.Visible = true;
            btnEkle.Visible = false;

            Siparis siparis = (Siparis)dgvSiparisler.SelectedRows[0].DataBoundItem;
            txtMusteriAdSoyad.Text = siparis.MusteriAdSoyad;
            txtTeslimatAdresi.Text = siparis.Adres;
            chkTeslimEdildi.Checked = siparis.TeslimDurumu;

            for (int i = 0; i < clbEkstraMalzemeler.Items.Count; i++)
            {
                EkstraMalzeme mal = (EkstraMalzeme)clbEkstraMalzemeler.Items[i];

                if (siparis.EkstraMalzemeler.Any(x => x.Id == mal.Id))
                    clbEkstraMalzemeler.SetItemChecked(i, true);
            }

            for (int i = 0; i < cboPizzaCesidi.Items.Count; i++)
            {
                cboPizzaCesidi.SelectedIndex = i;
                PizzaCesit piz = (PizzaCesit)cboPizzaCesidi.SelectedItem;
                if (piz.Id == siparis.PizzaCesitId)
                {
                    cboPizzaCesidi.SelectedIndex = i;
                    return; ;
                }
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtMusteriAdSoyad.Text == "" || txtTeslimatAdresi.Text == "")
            {
                MessageBox.Show("Lütfen Ad ve Adres Giriniz");
                return;
            }
            Siparis siparis = (Siparis)dgvSiparisler.SelectedRows[0].DataBoundItem;

            List<EkstraMalzeme> ekstralar = clbEkstraMalzemeler.CheckedItems.OfType<EkstraMalzeme>().ToList();

            siparis.MusteriAdSoyad = txtMusteriAdSoyad.Text;
            siparis.Adres = txtTeslimatAdresi.Text;
            siparis.TeslimDurumu = chkTeslimEdildi.Checked;
            siparis.EkstraMalzemeler = ekstralar;
            siparis.PizzaCesitId = (int)cboPizzaCesidi.SelectedValue;
            db.SaveChanges();


            FormuTemizle();
            DuzenlemeModundanCik();
            SiparisleriListele();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuTemizle();
            DuzenlemeModundanCik();
        }

        private void btnPizzaCesitEkle_Click(object sender, EventArgs e)
        {

            PizzaCesitForm pizzaFrm = new PizzaCesitForm();

            pizzaFrm.IcerikDuzenlendi += PizzaFrm_IcerikDuzenlendi;
            pizzaFrm.ShowDialog();

        }

        private void PizzaFrm_IcerikDuzenlendi(object sender, EventArgs e)
        {
            db.Dispose();
            db = new PizzaKulesiContext();

            FormuTemizle();
            SiparisleriListele();
            PizzaCesitleriListele();
            EkstraMalzemelerListele();
        }

        private void btnEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            EkstraMalzemeForm ekMalFrm = new EkstraMalzemeForm();
            ekMalFrm.MalzemeDuzenlendi += EkMalFrm_MalzemeDuzenlendi;
            ekMalFrm.ShowDialog();
        }

        private void EkMalFrm_MalzemeDuzenlendi(object sender, EventArgs e)
        {
            db.Dispose();
            db = new PizzaKulesiContext();

            FormuTemizle();
            SiparisleriListele();
            PizzaCesitleriListele();
            EkstraMalzemelerListele();
        }
    }
}
