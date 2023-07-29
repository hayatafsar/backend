using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.IServices;
using WebAPICore.Models;

namespace WebAPICore.Services
{
    public class UserService : IUserService
    {
        APICoreDBContext db;
        public UserService(APICoreDBContext _db)
        {
            db = _db;
        }
        public TblUsers GetById(Guid userguid)
        {
           var data= db.TblUsers.Where(x => x.UserGuid == userguid).FirstOrDefault();
            return data;
        }

        public TblUsers AddUser(TblUsers objuser)
        {
            if (objuser != null)
            {
                //TblUsers obj = new TblUsers();
                ////obj.UserGuid = Guid.NewGuid();
                //obj.FirstName = objuser.FirstName;
                //obj.LastName = objuser.LastName;
                //obj.UserName = objuser.UserName;
                //obj.Password = objuser.Password;
                db.TblUsers.Add(objuser);
                db.SaveChanges();
                return objuser;
            }
            return null;


        }

        public TblUsers GetByUserNamePassword(string email, string password)
        {
            var data = db.TblUsers.Where(x => x.UserName == email && x.Password== password).FirstOrDefault();
            return data;
        }
    }
}
