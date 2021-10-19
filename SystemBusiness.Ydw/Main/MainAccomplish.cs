using Basiclibrarycode.Ydw;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBusiness.Ydw.Models;

namespace SystemBusiness.Ydw.Main
{
    public class MainAccomplish : IMain
    {
        public Bitmap GetUserAvatar(string avatarData)
        {
            if (string.IsNullOrWhiteSpace(avatarData))
            {
                return null;
            }
            return publicUtility.Base64StringToImageBitmap(avatarData);
        }

        public Users GetUsers(Guid userId)
        {
            SqlExec sqlExec = new SqlExec();
            string where = "AND (ID=@ID)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID", userId)
            };
            DataTable dataTable = sqlExec.Executiondatabase_R(0, 0, "*", "T_Users", "ID", where, parameters, out int count);
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            Users users = new Users()
            {
                ID = new Guid(dataTable.Rows[0]["ID"].ToString()),
                LoginAccount = dataTable.Rows[0]["LoginAccount"].ToString(),
                UserName = dataTable.Rows[0]["UserName"].ToString(),
                Telephone = dataTable.Rows[0]["Telephone"].ToString(),
                EMail = dataTable.Rows[0]["EMail"].ToString(),
                RoleID = dataTable.Rows[0]["RoleID"].ToString(),
                Avatar = dataTable.Rows[0]["Avatar"].ToString(),
                RegistrationDate = Convert.ToDateTime(dataTable.Rows[0]["RegistrationDate"])
            };
            return users;
        }
    }
}
