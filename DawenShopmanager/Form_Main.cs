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
using SystemBusiness.Ydw.Main;
using SystemBusiness.Ydw.Models;

namespace DawenShopmanager
{
    public partial class Form_Main : UIHeaderAsideMainFooterFrame
    {
        public Form_Main()
        {
            InitializeComponent();
            XMLHelp xMLHelp = new XMLHelp();
            string autoLoginToken = publicUtility.DESDecrypt(xMLHelp.getValue("UserID"), ConfigurationManager.AppSettings["systemdata"]);
            IMain main = new MainAccomplish();
            Users users = main.GetUsers(new Guid(autoLoginToken.Split('|')[0]));
            uiLabel_UserName.Text = users.UserName;
            uiLabel_LoginDate.Text = DateTime.Now.ToString();
            uiAvatar_UserAvatar.Image = main.GetUserAvatar(users.Avatar);
            this.Text = publicUtility.DESDecrypt(ConfigurationManager.AppSettings["systemName"], ConfigurationManager.AppSettings["systemdata"]);
        }

        private void 退出登录ToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ILogin login = new LoginAccomplish();
            login.SignOut();
            Application.Restart();//退出登录
        }

        private void 窗口置顶ToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (窗口置顶ToolStripMenuItem.Text.Equals("窗口置顶"))
            {
                this.TopMost = true;
                窗口置顶ToolStripMenuItem.Text = "取消置顶";
                窗口置顶ToolStripMenuItem.Image = Properties.Resources.top;
            }
            else
            {
                this.TopMost = false;
                窗口置顶ToolStripMenuItem.Text = "窗口置顶";
                窗口置顶ToolStripMenuItem.Image = Properties.Resources.nottop;
            }
        }

        private void uiPanel_UserInfo_MouseMove(object sender, MouseEventArgs e)
        {
            uiPanel_UserInfo.FillColor = Color.FromArgb(118, 210, 255);
        }

        private void uiPanel_UserInfo_MouseLeave(object sender, EventArgs e)
        {
            uiPanel_UserInfo.FillColor = Color.Transparent;
        }

        private void uiHeaderButton_HomePage_Click(object sender, EventArgs e)
        {
            ChangePage(((dynamic)sender).Name);
        }

        private void uiHeaderButton_Invoicing_Click(object sender, EventArgs e)
        {
            ChangePage(((dynamic)sender).Name);

        }

        private void uiHeaderButton_member_Click(object sender, EventArgs e)
        {
            ChangePage(((dynamic)sender).Name);

        }

        private void uiHeaderButton_OA_Click(object sender, EventArgs e)
        {
            ChangePage(((dynamic)sender).Name);

        }

        private void uiHeaderButton_Report_Click(object sender, EventArgs e)
        {
            ChangePage(((dynamic)sender).Name);

        }
        private void ChangePage(string ComponentType)
        {
            if (ComponentType.Equals("uiHeaderButton_HomePage"))
            {
                Aside.Visible = false;
                Footer.Visible = false;
            }
            else
            {
                Aside.Visible = true;
                Footer.Visible = true;
            }
        }
    }
}
