using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBusiness.Ydw.Login
{
    public interface ILogin
    {
        int Login(string loginAccount, string loginPassword,out string autoLoginTOken, out string msg);
        bool AddOrEditAutoLoginToken(string autoLoginToken);
        bool AutoLogin();
        void SignOut();
    }
}
