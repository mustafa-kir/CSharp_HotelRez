using OtelRezarvasyon.Business.Abstract;
using OtelRezarvasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
///  burada sadece tasarım kodları olsun iş katmanında doğrulama veri katmanında da veriler çekilsin
/// </summary>
namespace OtelRezarvasyon
{

    /// <summary>
    ///  kullanıcı id alıp bir 
    /// </summary>
    public partial class LoginPage : UserControl
    {
        string GirisKullaniciAdi,GirisSifre;
        string UyeOlKullaniciAdi,UyeOlSifre;
        string sifreGoster;
        string KulaniciAdi,ab;

        private ILoginService _loginService;
        public LoginPage()
        {
            InitializeComponent();
        }
        //sifre gösterme yeri
        private void btnSifreGoster_Click(object sender, EventArgs e)
        {
            sifreGoster = tBKullaniciAdi3.Text;
            lblSifreGosterilecekYer.Text = Convert.ToString(_loginService.GetPasswordsByUserName(sifreGoster));        
        }
        // kayıt olma yeri
        private void btnUyeOl_Click(object sender, EventArgs e)
        {
           
            _loginService.Add(new Login
            {
                UserName = tBKulaniciAdi2.Text,
                UserPassword = tBSifre2.Text,
                Assignment = cBoxMission.Text,
            });
        }
        // giriş yeri.
        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            GirisKullaniciAdi = Convert.ToString(tBKullaniciAdi1.Text);
            GirisSifre = Convert.ToString(tBSifre1.Text);
           
             
            if (_loginService.Verification(GirisKullaniciAdi, GirisSifre))
            {

                // yönlendirme yapılacak kullanıcıya göre. buda kullanıcının görevindeki index sayısı (ör: patron 1 index, calısan 2 index ) burada ki sayıyı alıp yönlendirilecek olan sayıya eşitle 
               // burada birde kullanıcının idsini gönder.
            }
            else
            {
                toolStripStatusLbl.Text = "Kulanıcı adı ve/veya sifre yanlıs";
            }
        }
    }
}
