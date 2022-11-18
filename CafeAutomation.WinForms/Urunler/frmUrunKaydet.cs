using CafeAutomation.Entities.DAL;
using CafeAutomation.Entities.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeAutomation.WinForms.Urunler
{
    public partial class frmUrunKaydet : DevExpress.XtraEditors.XtraForm
    {
        private MenuDal menuDal = new MenuDal();
        private CafeContext context = new CafeContext();
        private Urun _entity;
        private UrunDal urunDal = new UrunDal();
        public bool kaydet = false;

        public frmUrunKaydet(Urun entity)
        {
            InitializeComponent();
            _entity = entity;
            lookUpMenu.Properties.DataSource = menuDal.GetAll(context);
            lookUpMenu.DataBindings.Add("EditValue", _entity, "MenuId");
            txtUrunAdi.DataBindings.Add("Text", _entity, "UrunAdi");
            txtUrunKodu.DataBindings.Add("Text", _entity, "UrunKodu");
            calcBirimFiyati1.DataBindings.Add("Text", _entity, "BirimFiyati1",true);
            calcBirimFiyati2.DataBindings.Add("Text", _entity, "BirimFiyati2",true);
            calcBirimFiyati3.DataBindings.Add("Text", _entity, "BirimFiyati3",true);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
            dateEdit1.DataBindings.Add("Text", _entity, "Tarih",true);
            if (_entity.Id != 0)
            {
                if (_entity.Resim != null)
                {
                    pictureEdit1.EditValue = Image.FromFile(_entity.Resim);
                }
            }
        }
        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            if (pictureEdit1.GetLoadedImageLocation() != "")
            {
                string hedef = $"{Application.StartupPath}\\Image\\{txtUrunAdi.Text}-{txtUrunKodu.Text}.png";
                File.Copy(pictureEdit1.GetLoadedImageLocation(), hedef);
                _entity.Resim = $"Image\\{txtUrunAdi.Text}-{txtUrunKodu.Text}.png";
            }
            if (urunDal.AddOrUpdate(context, _entity))
            {
                urunDal.Save(context);
                kaydet = true;
                this.Close();
            }
        }

        private void frmUrunKaydet_Load(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void calcBirimFiyati3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void calcBirimFiyati2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void calcBirimFiyati1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lookUpMenu_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}