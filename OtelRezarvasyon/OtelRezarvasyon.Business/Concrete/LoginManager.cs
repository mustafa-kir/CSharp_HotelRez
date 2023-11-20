using OtelRezarvasyon.Business.Abstract;
using OtelRezarvasyon.Business.DependencyResolvers.Ninject;
using OtelRezarvasyon.DataAccess.Abstract;
using OtelRezarvasyon.Entities.Abstract;
using OtelRezarvasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Business.Concrete
{
    public class LoginManager: ILoginService
    {
        /// <summary>
        /// boss ve kullanıcıya göre değişmesin hepsinde aynı olsun
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        
        private ILoginDal _loginDal;
        //List<System.Web.UI.WebControls.Panel> listPanel = new List<System.Web.UI.WebControls.Panel>();
        public LoginManager(ILoginDal loginDal)
        {
            _loginDal = loginDal;
        }

        public void Add(Login login)
        {
            _loginDal.Add(login);
        }

        public List<Login> GetPasswordsByUserName(string loginUserName)
        {
            
            
            if (_loginDal.GetAll(p => p.UserName.ToLower().Contains(loginUserName.ToLower())) != null)
            {
                return _loginDal.GetAll(p => p.UserPassword !=null);
                
            }
            return null;
        }

        public void Update(Login login)
        {
            _loginDal.Update(login);
        }

        public bool Verification(string userName, string password)
        {
            /* 
             if (_loginDal.GetAll(p => p.UserName.ToLower().Contains(userName.ToLower())) != null && _loginDal.GetAll(p => p.UserPassword.ToLower().Contains(password.ToLower())) != null)
             {
                 return true;
             }
             else
             {
                 return false;
             }
             */
            // yukarıda ki kod ile aynı ilevde
            return _loginDal.GetAll(p => p.UserName.ToLower().Contains(userName.ToLower())) != null && _loginDal.GetAll(p => p.UserPassword.ToLower().Contains(password.ToLower())) != null;

        }

        List<Login> ILoginService.GetAll(int loginId)
        {
            return _loginDal.GetAll(p => p.LoginId == loginId);
        }

       
    }
}
