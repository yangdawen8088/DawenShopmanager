using Basiclibrarycode.Ydw;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBusiness.Ydw.Login
{
    public class LoginAccomplish : ILogin
    {
        private static int loginErr = 0;

        public bool AddOrEditAutoLoginToken(string autoLoginToken)
        {
            try
            {
                XMLHelp xMLHelp = new XMLHelp();
                if (xMLHelp.isXMLKeyNull("AutoLogin"))
                {
                    return xMLHelp.editXMLKsyForKey("AutoLogin", autoLoginToken);
                }
                else
                {
                    return xMLHelp.addXMLKsyForKey("AutoLogin", autoLoginToken);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AutoLogin()
        {
            XMLHelp xMLHelp = new XMLHelp();
            string path = AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.AppSettings["CachePath"];
            if (!File.Exists(path) || !xMLHelp.isXMLKeyNull("AutoLogin"))
            {
                return false;
            }
            string autoLoginToken = publicUtility.DESDecrypt(xMLHelp.getValue("AutoLogin"), ConfigurationManager.AppSettings["systemdata"]);
            string[] tokenValue = autoLoginToken.Split('|');
            SqlExec sqlExec = new SqlExec();
            string where = "AND (LoginAccount=@LoginAccount AND LoginPassword=@LoginPassword)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@LoginAccount", tokenValue[0]),
                new SqlParameter("@LoginPassword", tokenValue[1])
            };
            DataTable dataTable = sqlExec.Executiondatabase_R(0, 0, "*", "T_Users", "ID", where, parameters, out int count);
            if (count == 0)
            {
                return false;
            }
            if (!tokenValue[3].Equals(publicUtility.GetCPUUID()))
            {
                return false;
            }
            string userID = publicUtility.DESEncrypt(
                   dataTable.Rows[0]["ID"].ToString() + "|" + DateTime.Now.ToFileTime().ToString(),
                   ConfigurationManager.AppSettings["systemdata"]);
            if (xMLHelp.isXMLKeyNull("UserID"))
            {
                xMLHelp.editXMLKsyForKey("UserID", userID);
            }
            else
            {
                xMLHelp.addXMLKsyForKey("UserID", userID);
            }
            return true;
        }

        public int Login(string loginAccount, string loginPassword, out string autoLoginToken, out string msg)
        {
            try
            {
                loginPassword = publicUtility.GetMd5Str(loginPassword, 32, 1);
                SqlExec sqlExec = new SqlExec();
                string where = "AND (LoginAccount=@LoginAccount)";

                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@LoginAccount", loginAccount),
                new SqlParameter("@LoginPassword", loginPassword)
                };
                DataTable dataTable = sqlExec.Executiondatabase_R(0, 0, "*", "T_Users", "ID", where, parameters, out int count);
                if (count == 0)
                {
                    msg = "账户不存在";
                    autoLoginToken = "";
                    return 0;
                }
                //if (dataTable.Rows[0]["AccountStatus"].Equals("-1"))
                //{
                //    msg = "您已超过 3 次错误登录，账户被锁定，请联系管理员，核验解锁！";
                //    return -1;
                //}
                string userId = dataTable.Rows[0]["ID"].ToString();
                where = "AND (LoginAccount=@LoginAccount AND LoginPassword=@LoginPassword)";
                dataTable = new DataTable();
                dataTable = sqlExec.Executiondatabase_R(0, 0, "*", "T_Users", "ID", where, parameters, out count);
                if (count == 0)
                {
                    msg = "密码错误";
                    loginErr++;
                    if (loginErr >= 3)
                    {
                        //string sql = "";
                        //sql += "UPDATE [dbo].[T_Users] SET ";
                        //sql += "[AccountStatus] = @AccountStatus ";
                        //sql += " WHERE ID=@ID ";
                        //parameters = new SqlParameter[] {
                        //    new SqlParameter("@ID", userId),
                        //    new SqlParameter("@AccountStatus", "-1")
                        //};
                        //new SqlExec().Executiondatabase_CUD(sql, parameters);
                    }
                    autoLoginToken = "";
                    return 0;
                }
                msg = "登录成功";
                // 用户登录令牌由登录账户、登录密码加密、登录日期、计算机 Mac 地址组成：登录账户/登录密码加密/登录日期/计算机 Mac 地址
                autoLoginToken = dataTable.Rows[0]["LoginAccount"] +
                    "|" + dataTable.Rows[0]["LoginPassword"] +
                    "|" + DateTime.Now.ToLocalTime().ToString() +
                    "|" + publicUtility.GetCPUUID();
                autoLoginToken = publicUtility.DESEncrypt(autoLoginToken, ConfigurationManager.AppSettings["systemdata"]);
                XMLHelp xMLHelp = new XMLHelp();
                string userID = publicUtility.DESEncrypt(
                    dataTable.Rows[0]["ID"].ToString() + "|" + DateTime.Now.ToFileTime().ToString(),
                    ConfigurationManager.AppSettings["systemdata"]);
                if (xMLHelp.isXMLKeyNull("UserID"))
                {
                    xMLHelp.editXMLKsyForKey("UserID", userID);
                }
                else
                {
                    xMLHelp.addXMLKsyForKey("UserID", userID);
                }
                loginErr = 0;
                return 1;
                //switch (dataTable.Rows[0]["AccountStatus"])
                //{
                //    case "-1":
                //        msg = "账户已被锁定，请联系管理员";
                //        return 0;
                //    case "1":
                //        msg = "账户已被登录，请先退出另一个登录";
                //        return 0;
                //    default:
                //        string sql = "";
                //        sql += "UPDATE [dbo].[T_Users] SET ";
                //        sql += "[AccountStatus] = @AccountStatus ";
                //        sql += " WHERE ID=@ID ";
                //        parameters = new SqlParameter[] {
                //        new SqlParameter("@ID", dataTable.Rows[0]["ID"]),
                //        new SqlParameter("@AccountStatus", "1")
                //    };
                //        if (new SqlExec().Executiondatabase_CUD(sql, parameters) >= 1)
                //        {
                //            msg = "登录成功";
                //            loginErr = 0;
                //            return 1;
                //        }
                //        msg = "登录失败";
                //        return 0;
                //}
            }
            catch (Exception ex)
            {
                msg = "登录过程中出现异常：\n" + ex;
                autoLoginToken = "";
                return -2;
            }
        }

        public void SignOut()
        {
            XMLHelp xMLHelp = new XMLHelp();
            string path = AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.AppSettings["CachePath"];
            if (!File.Exists(path))
            {
                return;
            }
            if (xMLHelp.isXMLKeyNull("AutoLogin"))
            {
                xMLHelp.DelXMLKsy("AutoLogin");
            }
            if (xMLHelp.isXMLKeyNull("UserID"))
            {
                xMLHelp.DelXMLKsy("UserID");
            }
        }
    }
}