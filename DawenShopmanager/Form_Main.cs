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
        /// <summary>
        /// 主页点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiHeaderButton_HomePage_Click(object sender, EventArgs e)
        {
            ChangePage(((dynamic)sender).Name);
        }
        TreeNode treeNode = new TreeNode();
        /// <summary>
        /// 进销存点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiHeaderButton_Invoicing_Click(object sender, EventArgs e)
        {
            int pageIndex = 1000;
            treeNode = Aside.CreateNode("控件", 61451, 24, pageIndex);
            Aside.CreateChildNode(treeNode, "测试"+DateTime.Now.ToString(), ++pageIndex);
            //treeNode = Aside.CreateNode("控制台", 61451, pageIndex);
            //treeNode = Aside.CreateNode("首页", 61452, (pageIndex+1));
            ChangePage(((dynamic)sender).Name);

        }
        /// <summary>
        /// 会员管理点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiHeaderButton_member_Click(object sender, EventArgs e)
        {
            treeNode.Remove();
            ChangePage(((dynamic)sender).Name);

        }
        /// <summary>
        /// 系统 OA 点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiHeaderButton_OA_Click(object sender, EventArgs e)
        {
            treeNode.Nodes.Clear();
            ChangePage(((dynamic)sender).Name);

        }
        /// <summary>
        /// 数据报表点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
