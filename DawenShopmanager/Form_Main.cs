using Basiclibrarycode.Ydw;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBusiness.Ydw.Login;

namespace DawenShopmanager
{
    public partial class Form_Main : UIHeaderAsideMainFooterFrame
    {
        public Form_Main()
        {
            InitializeComponent();
            XMLHelp xMLHelp = new XMLHelp();
            string autoLoginToken = publicUtility.DESDecrypt(xMLHelp.getValue("UserID"), ConfigurationManager.AppSettings["aeskey"]);
            uiLabel1.Text = autoLoginToken.Split('|')[0];
        }

        private void 退出登录ToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ILogin login = new LoginAccomplish();
                login.SignOut();
                Application.Restart();//退出登录
            }
        }
    }
}
