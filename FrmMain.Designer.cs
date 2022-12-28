namespace Kutuphane
{
    partial class FrmMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.islemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.iadeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uyeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeTanımlamalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeTürüTanımlamalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cezaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeÖdemeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödünçVermeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapTanımlamalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konuTanımlamalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yayıncıTanımlamalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarTanımlamalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapTürüTanımlamalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıTanımlamalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıTürüTanımlamalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametreMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümTanımlamalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rafTanımlamalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.islemMenu,
            this.uyeMenu,
            this.kitapToolStripMenuItem,
            this.kullaniciMenu,
            this.parametreMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(843, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // islemMenu
            // 
            this.islemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.iadeİşlemleriToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.islemMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.islemMenu.Name = "islemMenu";
            this.islemMenu.Size = new System.Drawing.Size(64, 24);
            this.islemMenu.Text = "&Dosya";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(283, 6);
            // 
            // iadeİşlemleriToolStripMenuItem
            // 
            this.iadeİşlemleriToolStripMenuItem.Name = "iadeİşlemleriToolStripMenuItem";
            this.iadeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.iadeİşlemleriToolStripMenuItem.Text = "Ödünç Alma ve İade İşlemleri";
            this.iadeİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.iadeİşlemleriToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(283, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.exitToolStripMenuItem.Text = "Ç&ıkış";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // uyeMenu
            // 
            this.uyeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeTanımlamalarıToolStripMenuItem,
            this.üyeTürüTanımlamalarıToolStripMenuItem,
            this.cezaİşlemleriToolStripMenuItem,
            this.üyeÖdemeİşlemleriToolStripMenuItem,
            this.ödünçVermeİşlemleriToolStripMenuItem});
            this.uyeMenu.Name = "uyeMenu";
            this.uyeMenu.Size = new System.Drawing.Size(48, 24);
            this.uyeMenu.Text = "&Üye";
            // 
            // üyeTanımlamalarıToolStripMenuItem
            // 
            this.üyeTanımlamalarıToolStripMenuItem.Name = "üyeTanımlamalarıToolStripMenuItem";
            this.üyeTanımlamalarıToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.üyeTanımlamalarıToolStripMenuItem.Text = "Üye Tanımlamaları";
            this.üyeTanımlamalarıToolStripMenuItem.Click += new System.EventHandler(this.üyeTanımlamalarıToolStripMenuItem_Click);
            // 
            // üyeTürüTanımlamalarıToolStripMenuItem
            // 
            this.üyeTürüTanımlamalarıToolStripMenuItem.Name = "üyeTürüTanımlamalarıToolStripMenuItem";
            this.üyeTürüTanımlamalarıToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.üyeTürüTanımlamalarıToolStripMenuItem.Text = "Üye Türü Tanımlamaları";
            this.üyeTürüTanımlamalarıToolStripMenuItem.Click += new System.EventHandler(this.üyeTürüTanımlamalarıToolStripMenuItem_Click);
            // 
            // cezaİşlemleriToolStripMenuItem
            // 
            this.cezaİşlemleriToolStripMenuItem.Name = "cezaİşlemleriToolStripMenuItem";
            this.cezaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.cezaİşlemleriToolStripMenuItem.Text = "Üye Ceza Bilgileri";
            this.cezaİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.cezaİşlemleriToolStripMenuItem_Click_1);
            // 
            // üyeÖdemeİşlemleriToolStripMenuItem
            // 
            this.üyeÖdemeİşlemleriToolStripMenuItem.Name = "üyeÖdemeİşlemleriToolStripMenuItem";
            this.üyeÖdemeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.üyeÖdemeİşlemleriToolStripMenuItem.Text = "Üye Ödeme İşlemleri";
            this.üyeÖdemeİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.üyeÖdemeİşlemleriToolStripMenuItem_Click);
            // 
            // ödünçVermeİşlemleriToolStripMenuItem
            // 
            this.ödünçVermeİşlemleriToolStripMenuItem.Name = "ödünçVermeİşlemleriToolStripMenuItem";
            this.ödünçVermeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.ödünçVermeİşlemleriToolStripMenuItem.Text = "Üye Borç Durumu";
            this.ödünçVermeİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.ödünçVermeİşlemleriToolStripMenuItem_Click);
            // 
            // kitapToolStripMenuItem
            // 
            this.kitapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapTanımlamalarıToolStripMenuItem,
            this.konuTanımlamalarıToolStripMenuItem,
            this.toolStripMenuItem1,
            this.yayıncıTanımlamalarıToolStripMenuItem,
            this.yazarTanımlamalarıToolStripMenuItem,
            this.kitapTürüTanımlamalarıToolStripMenuItem});
            this.kitapToolStripMenuItem.Name = "kitapToolStripMenuItem";
            this.kitapToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.kitapToolStripMenuItem.Text = "Kitap";
            // 
            // kitapTanımlamalarıToolStripMenuItem
            // 
            this.kitapTanımlamalarıToolStripMenuItem.Name = "kitapTanımlamalarıToolStripMenuItem";
            this.kitapTanımlamalarıToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.kitapTanımlamalarıToolStripMenuItem.Text = "Kitap Tanımlamaları";
            this.kitapTanımlamalarıToolStripMenuItem.Click += new System.EventHandler(this.kitapTanımlamalarıToolStripMenuItem_Click);
            // 
            // konuTanımlamalarıToolStripMenuItem
            // 
            this.konuTanımlamalarıToolStripMenuItem.Name = "konuTanımlamalarıToolStripMenuItem";
            this.konuTanımlamalarıToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.konuTanımlamalarıToolStripMenuItem.Text = "Kategori Tanımlamaları";
            this.konuTanımlamalarıToolStripMenuItem.Click += new System.EventHandler(this.konuTanımlamalarıToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(257, 26);
            this.toolStripMenuItem1.Text = "Yazar Tanımlamaları";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // yayıncıTanımlamalarıToolStripMenuItem
            // 
            this.yayıncıTanımlamalarıToolStripMenuItem.Name = "yayıncıTanımlamalarıToolStripMenuItem";
            this.yayıncıTanımlamalarıToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.yayıncıTanımlamalarıToolStripMenuItem.Text = "Yayıncı Tanımlamaları";
            this.yayıncıTanımlamalarıToolStripMenuItem.Click += new System.EventHandler(this.yayıncıTanımlamalarıToolStripMenuItem_Click_1);
            // 
            // yazarTanımlamalarıToolStripMenuItem
            // 
            this.yazarTanımlamalarıToolStripMenuItem.Name = "yazarTanımlamalarıToolStripMenuItem";
            this.yazarTanımlamalarıToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.yazarTanımlamalarıToolStripMenuItem.Text = "Dil Tanımlamaları";
            this.yazarTanımlamalarıToolStripMenuItem.Click += new System.EventHandler(this.yazarTanımlamalarıToolStripMenuItem_Click_1);
            // 
            // kitapTürüTanımlamalarıToolStripMenuItem
            // 
            this.kitapTürüTanımlamalarıToolStripMenuItem.Name = "kitapTürüTanımlamalarıToolStripMenuItem";
            this.kitapTürüTanımlamalarıToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.kitapTürüTanımlamalarıToolStripMenuItem.Text = "Kitap Türü Tanımlamaları";
            this.kitapTürüTanımlamalarıToolStripMenuItem.Click += new System.EventHandler(this.kitapTürüTanımlamalarıToolStripMenuItem_Click);
            // 
            // kullaniciMenu
            // 
            this.kullaniciMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıTanımlamalarıToolStripMenuItem,
            this.kullanıcıTürüTanımlamalarıToolStripMenuItem});
            this.kullaniciMenu.Name = "kullaniciMenu";
            this.kullaniciMenu.Size = new System.Drawing.Size(79, 24);
            this.kullaniciMenu.Text = "&Kullanici";
            // 
            // kullanıcıTanımlamalarıToolStripMenuItem
            // 
            this.kullanıcıTanımlamalarıToolStripMenuItem.Name = "kullanıcıTanımlamalarıToolStripMenuItem";
            this.kullanıcıTanımlamalarıToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.kullanıcıTanımlamalarıToolStripMenuItem.Text = "Kullanıcı Tanımlamaları";
            this.kullanıcıTanımlamalarıToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıTanımlamalarıToolStripMenuItem_Click);
            // 
            // kullanıcıTürüTanımlamalarıToolStripMenuItem
            // 
            this.kullanıcıTürüTanımlamalarıToolStripMenuItem.Name = "kullanıcıTürüTanımlamalarıToolStripMenuItem";
            this.kullanıcıTürüTanımlamalarıToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.kullanıcıTürüTanımlamalarıToolStripMenuItem.Text = "Kullanıcı Türü Tanımlamaları";
            this.kullanıcıTürüTanımlamalarıToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıTürüTanımlamalarıToolStripMenuItem_Click);
            // 
            // parametreMenu
            // 
            this.parametreMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bölümTanımlamalarıToolStripMenuItem,
            this.rafTanımlamalarıToolStripMenuItem});
            this.parametreMenu.Name = "parametreMenu";
            this.parametreMenu.Size = new System.Drawing.Size(107, 24);
            this.parametreMenu.Text = "&Parametreler";
            // 
            // bölümTanımlamalarıToolStripMenuItem
            // 
            this.bölümTanımlamalarıToolStripMenuItem.Name = "bölümTanımlamalarıToolStripMenuItem";
            this.bölümTanımlamalarıToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.bölümTanımlamalarıToolStripMenuItem.Text = "Bölüm Tanımlamaları";
            this.bölümTanımlamalarıToolStripMenuItem.Click += new System.EventHandler(this.bölümTanımlamalarıToolStripMenuItem_Click);
            // 
            // rafTanımlamalarıToolStripMenuItem
            // 
            this.rafTanımlamalarıToolStripMenuItem.Name = "rafTanımlamalarıToolStripMenuItem";
            this.rafTanımlamalarıToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.rafTanımlamalarıToolStripMenuItem.Text = "Raf Tanımlamaları";
            this.rafTanımlamalarıToolStripMenuItem.Click += new System.EventHandler(this.rafTanımlamalarıToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(69, 24);
            this.helpMenu.Text = "&Yardım";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(177, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.aboutToolStripMenuItem.Text = "&Hakkında ... ...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 671);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel.Text = "Durum";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 697);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Bilgi Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem islemMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uyeMenu;
        private System.Windows.Forms.ToolStripMenuItem kullaniciMenu;
        private System.Windows.Forms.ToolStripMenuItem parametreMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem bölümTanımlamalarıToolStripMenuItem;
        private ToolStripMenuItem kullanıcıTanımlamalarıToolStripMenuItem;
        private ToolStripMenuItem rafTanımlamalarıToolStripMenuItem;
        private ToolStripMenuItem üyeTanımlamalarıToolStripMenuItem;
        private ToolStripMenuItem üyeTürüTanımlamalarıToolStripMenuItem;
        private ToolStripMenuItem kitapToolStripMenuItem;
        private ToolStripMenuItem konuTanımlamalarıToolStripMenuItem;
        private ToolStripMenuItem yayıncıTanımlamalarıToolStripMenuItem;
        private ToolStripMenuItem yazarTanımlamalarıToolStripMenuItem;
        private ToolStripMenuItem kitapTanımlamalarıToolStripMenuItem;
        private ToolStripMenuItem iadeİşlemleriToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem kitapTürüTanımlamalarıToolStripMenuItem;
        private ToolStripMenuItem kullanıcıTürüTanımlamalarıToolStripMenuItem;
        private ToolStripMenuItem üyeÖdemeİşlemleriToolStripMenuItem;
        private ToolStripMenuItem cezaİşlemleriToolStripMenuItem;
        private ToolStripMenuItem ödünçVermeİşlemleriToolStripMenuItem;
    }
}



