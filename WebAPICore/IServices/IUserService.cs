using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.Models;

namespace WebAPICore.IServices
{
    public interface IUserService
    {
        TblUsers GetById(Guid userguid);
        TblUsers AddUser(TblUsers objuser);
        TblUsers GetByUserNamePassword(string email, string password);

    }
}
