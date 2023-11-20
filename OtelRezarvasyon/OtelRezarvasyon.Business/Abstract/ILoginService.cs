using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezarvasyon.Entities;
using OtelRezarvasyon.Entities.Abstract;
using OtelRezarvasyon.Entities.Concrete;

namespace OtelRezarvasyon.Business.Abstract
{
    public interface ILoginService
    {
        // burada giris için ve yeni kayıt bölümü
        bool Verification(string userName, string password); // şifre doğrulama 
        void Add(Login login); // yeni kayıt için 
        List<Login> GetAll(int loginId);  // kişisel bilgileri görüntülesin. 
        List<Login> GetPasswordsByUserName(string loginPassword);
        void Update(Login login); // kişisel bilgiler düzeltilsin.

    } 
}
