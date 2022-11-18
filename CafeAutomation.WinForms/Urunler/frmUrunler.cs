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

namespace CafeAutomation.WinForms.Urunler
{
    public partial class frmUrunler : DevExpress.XtraEditors.XtraForm

    {//ILGILI ALANLARDAN NESNE TANIMLAMA:
        private CafeContext context = new CafeContext();
        private UrunDal urunDal = new UrunDal();
        public frmUrunler()//URUN ANA FORMU
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            gridControl1.DataSource = urunDal.UrunListele(context);
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnYeni_Click(object sender, EventArgs e)//YENI URUN EKLEME
        {
            frmUrunKaydet frm = new frmUrunKaydet(new Urun());
            frm.ShowDialog();
            if (frm.kaydet)
            {
                Listele();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDuzenle_Click(object sender, EventArgs e)//URUN DUZENLEME
        {
            int cid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));//düzenlenecek olan urunun id'sidir
            frmUrunKaydet frm = new frmUrunKaydet(urunDal.GetByFilter(context, u => u.Id == cid));
            frm.ShowDialog();
            if (frm.kaydet)
            {
                Listele();
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)//YENİLEME YAPAR
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)//FRM KAPATMA
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)//URUN SİLME
        {
            int secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));//secilen=silinecek olan urunun id'sini temsil eder
            if (MessageBox.Show("Seçilen ürünün silinmesini onaylıyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                urunDal.Delete(context,u=>u.Id==secilen);
                urunDal.Save(context);
                Listele();//ekranı yenileme yapar
            }
        }

        private void labelControl1_Click_1(object sender, EventArgs e)
        {

        }
    }
}