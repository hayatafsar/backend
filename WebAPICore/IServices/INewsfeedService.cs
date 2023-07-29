using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.Models;
using WebAPICore.ViewModel;

namespace WebAPICore.IServices
{
   public interface INewsfeedService
    {
        List<TblUserPost> GetPost();
        TblPost AddPost(TblUserPost tblPost);

    }
}
