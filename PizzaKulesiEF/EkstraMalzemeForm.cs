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

    
    public partial class EkstraMalzemeForm : Form
    {
        public event EventHandler MalzemeDuzenlendi;
        PizzaKulesiContext db = new PizzaKulesiContext();
        
        public EkstraMalzemeForm()
        {
            InitializeComponent();
            MalzemeleriListele();
        }

        protected virtual void MalzemelerDuzenlendiginde(EventArgs args) 
        {
            if (MalzemeDuzenlendi!=null)
            {
                MalzemeDuzenlendi(this, args);
            }
        }

        private void MalzemeleriListele()
        {
            lstEkstraMalzemeler.DataSource = db.EkstraMalzemeler.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstEkstraMalzemeler.SelectedIndex < 0)
            {
                return;
            }

            EkstraMalzeme secilen = lstEkstraMalzemeler.SelectedItem as EkstraMalzeme;

            foreach (var item in db.Siparisler.ToList())
            {
                if (item.EkstraMalzemeler.Any(x=>x.Id==secilen.Id))
                {
                    MessageBox.Show("Bu malzemeyi kullanan sipariş var.");
                    return;
                }
            }
            db.EkstraMalzemeler.Remove(secilen);
            db.SaveChanges();
            MalzemeleriListele();
            MalzemelerDuzenlendiginde(EventArgs.Empty);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtMalzemeAd.Text=="")
            {
                MessageBox.Show("Malzeme adı giriniz.");
                return;
            }

            db.EkstraMalzemeler.Add(new EkstraMalzeme { MalzemeAd = txtMalzemeAd.Text });
            db.SaveChanges();
            MalzemeleriListele();
            MalzemelerDuzenlendiginde(EventArgs.Empty);
            txtMalzemeAd.Clear();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            btnSil.Enabled = false;
            btnDuzenle.Enabled = false;
            btnIptal.Visible = true;
            btnKaydet.Visible = true;
            btnEkle.Visible = false;
            txtMalzemeAd.Text = lstEkstraMalzemeler.SelectedItem.ToString();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DuzenlemeModundanCik();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtMalzemeAd.Text=="")
            {
                MessageBox.Show("Malzeme Adı boş bırakılamaz.");
                return;
            }

            EkstraMalzeme secilen = lstEkstraMalzemeler.SelectedItem as EkstraMalzeme;
            secilen.MalzemeAd = txtMalzemeAd.Text;
            db.SaveChanges();
            MalzemelerDuzenlendiginde(EventArgs.Empty);
            DuzenlemeModundanCik();
            MalzemeleriListele();
        }
        private void DuzenlemeModundanCik()
        {
            btnEkle.Visible = true;
            btnIptal.Visible = false;
            btnKaydet.Visible = false;
            btnSil.Enabled = true;
            btnDuzenle.Enabled = true;
            txtMalzemeAd.Clear();

        }

        private void lstEkstraMalzemeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            DuzenlemeModundanCik();
        }
    }
}
