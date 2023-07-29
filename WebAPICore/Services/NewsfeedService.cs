using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.IServices;
using WebAPICore.Models;
using WebAPICore.ViewModel;

namespace WebAPICore.Services
{
    public class NewsfeedService
    {
        APICoreDBContext dbContext;
        public NewsfeedService(APICoreDBContext _db)
        {
            dbContext = _db;
        }
        public List<TblUserPost> GetPost()
        {
            return dbContext.TblUserPost.ToList();
            
        }
    }
}
