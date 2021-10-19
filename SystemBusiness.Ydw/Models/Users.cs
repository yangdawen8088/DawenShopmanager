using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBusiness.Ydw.Models
{
    public class Users
    {
        public Guid ID { get; set; }
        public string LoginAccount { get; set; }
        public string LoginPassword { get; set; }
        public string UserName { get; set; }
        public string Telephone { get; set; }
        public string EMail { get; set; }
        public string RoleID { get; set; }
        public string Avatar { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}