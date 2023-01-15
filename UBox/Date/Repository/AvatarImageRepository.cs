using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBox.Date.Interface;
using UBox.Date.Models;

namespace UBox.Date.Repository
{
    public class AvatarImageRepository : IAvatarImage
    {
        AppDBContext appDBContext;
        public AvatarImageRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }
        public AvatarImage getAvatarImage(int idUser)
        {
            return appDBContext.AvatarImages.FirstOrDefault(u => u.UserId == idUser);
        }
    }
}
