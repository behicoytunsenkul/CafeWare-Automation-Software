﻿using CafeAutomation.Entities.DAL;
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

namespace CafeAutomation.WinForms.Masalar
{
    public partial class frmMasaKaydet : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MasalarDal masaDal = new MasalarDal();
        private Entities.Models.Masalar _entity;
        public bool kaydet = false;
        public frmMasaKaydet(Entities.Models.Masalar entity)
        {
            InitializeComponent();
            _entity = entity;
            txtMasaAdi.DataBindings.Add("Text", _entity, "MasaAdi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_entity.Id == 0)
            {
                _entity.Durumu = false;
                _entity.RezerveMi = false;
                _entity.EklenmeTarihi = DateTime.Now;//anlık tarihi ekler
                _entity.SonIslemTarihi = DateTime.Now;//anlık tarihi ekler
                _entity.Islem = "Yeni masa eklendi";
            }
            else if (_entity.Id != 0)
            {
                _entity.SonIslemTarihi = DateTime.Now;
                _entity.Islem = "Masa Guncellendi";
            }
            if (masaDal.AddOrUpdate(context, _entity))
            {
                masaDal.Save(context);
                kaydet = true;
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMasaKaydet_Load(object sender, EventArgs e)
        {

        }
    }
}