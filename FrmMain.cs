using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class FrmMain : Form
    {
        private int childFormNumber = 0;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
      
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAboutBox frm = new FrmAboutBox();
            frm.ShowDialog();
        }

        private void kullanıcıTanımlamalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKullanici frm = new FrmKullanici();
            frm.ShowDialog();
        }

        private void bölümTanımlamalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolum frm = new FrmBolum();
            frm.ShowDialog();
        }

        private void rafTanımlamalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRaf frm = new FrmRaf();
            frm.ShowDialog();

        }

        private void konuTanımlamalarıToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmKategori frm = new FrmKategori();
            frm.ShowDialog();

        }

        private void yayıncıTanımlamalarıToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmYayinci frm = new FrmYayinci();
            frm.ShowDialog();
        }

        private void yazarTanımlamalarıToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmDilTanimi frm = new FrmDilTanimi();
            frm.ShowDialog();

        }

      

        private void üyeTürüTanımlamalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUyeTuru frm = new FrmUyeTuru();
            frm.ShowDialog();

        }

        private void üyeTanımlamalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
          FrmUye  frm = new FrmUye();
            frm.ShowDialog();
        }

        private void kitapTanımlamalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {    FrmKitap  frm = new FrmKitap();
            frm.ShowDialog();

        }

        private void optionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
     
        }

        private void yabancıDilTanımlamalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
        FrmYazar frm = new FrmYazar();
            frm.ShowDialog();
        }

        private void kitapTürüTanımlamalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmTur frm = new FrmTur();
            frm.ShowDialog();
        }

        private void kullanıcıTürüTanımlamalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKullaniciTuru frm = new FrmKullaniciTuru();
            frm.ShowDialog();
        }

 
        private void üyeÖdemeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUyeOdeme frm = new FrmUyeOdeme();
            frm.ShowDialog();
        }
         private void iadeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOduncAlma frm = new FrmOduncAlma();
            frm.ShowDialog();
        }

        private void cezaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUyeCeza frm = new FrmUyeCeza();
            frm.ShowDialog();
        }

        private void ödünçVermeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUyeBorcDurumu  frm = new FrmUyeBorcDurumu();
            frm.ShowDialog();
        }

        private void cezaİşlemleriToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmUyeCeza frm = new FrmUyeCeza();
            frm.ShowDialog();
        }
    }
    }
