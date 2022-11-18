using CafeAutomation.Entities.DAL;
using CafeAutomation.Entities.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//GARSON-BAŞ GARSON ŞARMAAŞIKLIĞI VE HATALARI EN AZA İNDİRGEMEK AMACIYLA
//REZERVASYON, DURUM KISIMLARI KULLANICI ERİSİMİNE GORE DEGISTIRILEBILECEK SEKILDE AYARLADIM
namespace CafeAutomation.WinForms.Masalar
{
    public partial class frmMasalar : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MasalarDal masaDal = new MasalarDal();

        public frmMasalar()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            gridControl1.DataSource = masaDal.MasaListeleme(context);
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            frmMasaKaydet frm = new frmMasaKaydet(new Entities.Models.Masalar());
            frm.ShowDialog();
            if (frm.kaydet)
            {
                Listele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            var masa = masaDal.GetByFilter(context, m => m.Id == secilen);
            frmMasaKaydet frm = new frmMasaKaydet(masa);
            frm.ShowDialog();
            if (frm.kaydet)
            {
                Listele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));//secilen=silinecek olan urunun id'sini temsil eder
            if (MessageBox.Show("Seçilen masanın silinmesini onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                masaDal.Delete(context, m => m.Id == secilen);
                masaDal.Save(context);
                Listele();//ekranı yenileme yapar
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(gridView1.SelectedRowsCount > 0){
                int secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                var masa = masaDal.GetByFilter(context, m => m.Id == secilen);
                if(masa.Durumu)
                {
                    masa.Durumu = false;
                }
                else if (!masa.Durumu)
                {
                    masa.Durumu = true;
                }
                masaDal.Save(context);
                Listele();
            }
        }

        private void btnRezerve_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                int secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                var masa = masaDal.GetByFilter(context, m => m.Id == secilen);
                if (masa.RezerveMi)
                {
                    masa.RezerveMi = false;
                }
                else if (!masa.RezerveMi)
                {
                    masa.RezerveMi = true;
                }
                masaDal.Save(context);
                Listele();
            }
        }
    }
}