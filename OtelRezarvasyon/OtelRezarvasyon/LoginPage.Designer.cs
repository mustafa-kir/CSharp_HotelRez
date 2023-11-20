
namespace OtelRezarvasyon
{
    partial class LoginPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tBSifre1 = new System.Windows.Forms.TextBox();
            this.tBKullaniciAdi1 = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblSifreniz = new System.Windows.Forms.Label();
            this.lblKulaniciAdi1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cBoxMission = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBSifre2 = new System.Windows.Forms.TextBox();
            this.tBKulaniciAdi2 = new System.Windows.Forms.TextBox();
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKulaniciAdi2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tBKullaniciAdi3 = new System.Windows.Forms.TextBox();
            this.btnSifreGoster = new System.Windows.Forms.Button();
            this.lblSifreGosterilecekYer = new System.Windows.Forms.Label();
            this.lblKulaniciAdi3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 784);
            this.panel1.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 750);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1158, 34);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLbl
            // 
            this.toolStripStatusLbl.ForeColor = System.Drawing.Color.Crimson;
            this.toolStripStatusLbl.Name = "toolStripStatusLbl";
            this.toolStripStatusLbl.Size = new System.Drawing.Size(0, 28);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(284, 187);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(427, 238);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.tBSifre1);
            this.tabPage1.Controls.Add(this.tBKullaniciAdi1);
            this.tabPage1.Controls.Add(this.btnGiris);
            this.tabPage1.Controls.Add(this.lblSifreniz);
            this.tabPage1.Controls.Add(this.lblKulaniciAdi1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(419, 205);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Giriş";
            // 
            // tBSifre1
            // 
            this.tBSifre1.Location = new System.Drawing.Point(223, 84);
            this.tBSifre1.Name = "tBSifre1";
            this.tBSifre1.Size = new System.Drawing.Size(169, 27);
            this.tBSifre1.TabIndex = 4;
            // 
            // tBKullaniciAdi1
            // 
            this.tBKullaniciAdi1.Location = new System.Drawing.Point(223, 24);
            this.tBKullaniciAdi1.Name = "tBKullaniciAdi1";
            this.tBKullaniciAdi1.Size = new System.Drawing.Size(169, 27);
            this.tBKullaniciAdi1.TabIndex = 3;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(223, 137);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(169, 29);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giris Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblSifreniz
            // 
            this.lblSifreniz.Location = new System.Drawing.Point(22, 84);
            this.lblSifreniz.Name = "lblSifreniz";
            this.lblSifreniz.Size = new System.Drawing.Size(157, 20);
            this.lblSifreniz.TabIndex = 1;
            this.lblSifreniz.Text = "Sifrenizi Girin";
            // 
            // lblKulaniciAdi1
            // 
            this.lblKulaniciAdi1.Location = new System.Drawing.Point(22, 27);
            this.lblKulaniciAdi1.Name = "lblKulaniciAdi1";
            this.lblKulaniciAdi1.Size = new System.Drawing.Size(195, 27);
            this.lblKulaniciAdi1.TabIndex = 0;
            this.lblKulaniciAdi1.Text = "Kullanıcı Adını Giriniz";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.cBoxMission);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tBSifre2);
            this.tabPage2.Controls.Add(this.tBKulaniciAdi2);
            this.tabPage2.Controls.Add(this.btnUyeOl);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lblKulaniciAdi2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(419, 205);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Üye Ol";
            // 
            // cBoxMission
            // 
            this.cBoxMission.FormattingEnabled = true;
            this.cBoxMission.Location = new System.Drawing.Point(211, 111);
            this.cBoxMission.Name = "cBoxMission";
            this.cBoxMission.Size = new System.Drawing.Size(176, 28);
            this.cBoxMission.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Durumunuz";
            // 
            // tBSifre2
            // 
            this.tBSifre2.Location = new System.Drawing.Point(211, 70);
            this.tBSifre2.Name = "tBSifre2";
            this.tBSifre2.Size = new System.Drawing.Size(176, 27);
            this.tBSifre2.TabIndex = 4;
            // 
            // tBKulaniciAdi2
            // 
            this.tBKulaniciAdi2.Location = new System.Drawing.Point(211, 34);
            this.tBKulaniciAdi2.Name = "tBKulaniciAdi2";
            this.tBKulaniciAdi2.Size = new System.Drawing.Size(176, 27);
            this.tBKulaniciAdi2.TabIndex = 3;
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.Location = new System.Drawing.Point(211, 152);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(176, 29);
            this.btnUyeOl.TabIndex = 2;
            this.btnUyeOl.Text = "ÜYE OL";
            this.btnUyeOl.UseVisualStyleBackColor = true;
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sifrenizi Girin";
            // 
            // lblKulaniciAdi2
            // 
            this.lblKulaniciAdi2.Location = new System.Drawing.Point(15, 34);
            this.lblKulaniciAdi2.Name = "lblKulaniciAdi2";
            this.lblKulaniciAdi2.Size = new System.Drawing.Size(159, 27);
            this.lblKulaniciAdi2.TabIndex = 0;
            this.lblKulaniciAdi2.Text = "Kullanıcı Adınızı Girin";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.tBKullaniciAdi3);
            this.tabPage3.Controls.Add(this.btnSifreGoster);
            this.tabPage3.Controls.Add(this.lblSifreGosterilecekYer);
            this.tabPage3.Controls.Add(this.lblKulaniciAdi3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(419, 205);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Şifremi Unuttum";
            // 
            // tBKullaniciAdi3
            // 
            this.tBKullaniciAdi3.Location = new System.Drawing.Point(197, 30);
            this.tBKullaniciAdi3.Name = "tBKullaniciAdi3";
            this.tBKullaniciAdi3.Size = new System.Drawing.Size(199, 27);
            this.tBKullaniciAdi3.TabIndex = 3;
            // 
            // btnSifreGoster
            // 
            this.btnSifreGoster.Location = new System.Drawing.Point(197, 76);
            this.btnSifreGoster.Name = "btnSifreGoster";
            this.btnSifreGoster.Size = new System.Drawing.Size(199, 29);
            this.btnSifreGoster.TabIndex = 2;
            this.btnSifreGoster.Text = "Şifreyi Göster";
            this.btnSifreGoster.UseVisualStyleBackColor = true;
            this.btnSifreGoster.Click += new System.EventHandler(this.btnSifreGoster_Click);
            // 
            // lblSifreGosterilecekYer
            // 
            this.lblSifreGosterilecekYer.Location = new System.Drawing.Point(197, 128);
            this.lblSifreGosterilecekYer.Name = "lblSifreGosterilecekYer";
            this.lblSifreGosterilecekYer.Size = new System.Drawing.Size(199, 25);
            this.lblSifreGosterilecekYer.TabIndex = 1;
            this.lblSifreGosterilecekYer.Text = "Şifreniz Burada Gösterilecek";
            // 
            // lblKulaniciAdi3
            // 
            this.lblKulaniciAdi3.Location = new System.Drawing.Point(20, 33);
            this.lblKulaniciAdi3.Name = "lblKulaniciAdi3";
            this.lblKulaniciAdi3.Size = new System.Drawing.Size(171, 24);
            this.lblKulaniciAdi3.TabIndex = 0;
            this.lblKulaniciAdi3.Text = "Kullanıcı Adınızı Girin";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "LoginPage";
            this.Size = new System.Drawing.Size(1158, 786);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tBSifre1;
        private System.Windows.Forms.TextBox tBKullaniciAdi1;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblSifreniz;
        private System.Windows.Forms.Label lblKulaniciAdi1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tBSifre2;
        private System.Windows.Forms.TextBox tBKulaniciAdi2;
        private System.Windows.Forms.Button btnUyeOl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKulaniciAdi2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tBKullaniciAdi3;
        private System.Windows.Forms.Button btnSifreGoster;
        private System.Windows.Forms.Label lblSifreGosterilecekYer;
        private System.Windows.Forms.Label lblKulaniciAdi3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbl;
        private System.Windows.Forms.ComboBox cBoxMission;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
