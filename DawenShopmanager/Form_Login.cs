using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBusiness.Ydw.Login;

namespace DawenShopmanager
{
    public partial class Form_Login : UIForm
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void uiSymbolButton_Login_Click(object sender, EventArgs e)
        {
            string loginAccount = Regex.Replace(uiTextBox_LoginAccount.Text, @"\s", "");
            string loginPassword = Regex.Replace(uiTextBox_LoginPassword.Text, @"\s", "");
            if (loginAccount.Equals("") || loginPassword.Equals(""))
            {
                ShowWarningTip("账户或密码不能为空");
                return;
            }
            ILogin login = new LoginAccomplish();
            switch (login.Login(loginAccount, loginPassword,out string autoLoginToken, out string msg))
            {
                case -2:
                    ShowErrorDialog(msg);
                    break;
                case -1:
                    ShowWarningDialog(msg);
                    break;
                case 0:
                    ShowWarningTip(msg);
                    break;
                case 1:
                    ShowSuccessTip(msg);
                    if (uiCheckBox_AutoLogin.Checked&& autoLoginToken!="")
                    {
                        login.AddOrEditAutoLoginToken(autoLoginToken);
                    }
                    this.DialogResult = DialogResult.OK;
                    break;
            }
        }

        private void uiSymbolButton_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Environment.Exit(0);
        }

        private void uiTextBox_LoginAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || 
                (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || 
                (e.KeyChar >= '0' && e.KeyChar <= '9') || 
                (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
