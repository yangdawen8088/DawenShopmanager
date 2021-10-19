using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBusiness.Ydw.Models;

namespace SystemBusiness.Ydw.Main
{
    public interface IMain
    {
        Bitmap GetUserAvatar(string avatarData);
        Users GetUsers(Guid userId);
    }
}
