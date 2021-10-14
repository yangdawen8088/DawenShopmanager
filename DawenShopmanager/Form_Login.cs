using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ShowWarningTip("轻便消息提示框 - 警告");
            //验证输入合法性....

            //验证用户信息....

            this.DialogResult = DialogResult.OK;
        }

        private void uiSymbolButton_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Environment.Exit(0);
        }
    }
}
