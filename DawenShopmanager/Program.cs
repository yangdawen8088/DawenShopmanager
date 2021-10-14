using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DawenShopmanager
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form_Main());


            //首先载入登录窗体实例
            Form_Login frmLogin = new Form_Login();
            DialogResult loginResult = frmLogin.ShowDialog();
            //若登录成功则加载主窗体
            if (loginResult == DialogResult.OK)
            {
                Application.Run(new Form_Main());
            }
            else
            {
                //登录失败则关闭当前程序进程
                Application.Exit();
            }
        }
    }
}
