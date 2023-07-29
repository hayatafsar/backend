using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.IServices;
using WebAPICore.Models;

namespace WebAPICore.Services
{
    public class UserPostService : IUserPostService
    {
        private readonly APICoreDBContext DbContext;
        public UserPostService(APICoreDBContext _DBContext)
        {
            DbContext = _DBContext;
        }
        public List<TblPost> GetUserPost()
        {
            return DbContext.TblPost.ToList();
        }

        public TblPost AddUserPost(TblPost tblPost)
        {
            if (tblPost != null)
            {
                DbContext.TblPost.Add(tblPost);
                DbContext.SaveChanges();
                return tblPost;
            }
            return null;


        }

        public TblPost DeleteGetUserPost(Guid id)
        {
            if (id != null)
            {
                var userpost = DbContext.TblPost.FirstOrDefault(x => x.PostId == id);
                DbContext.Entry(userpost).State = EntityState.Deleted;
                DbContext.SaveChanges();
                return userpost;
            }
            return null;
        }


        public TblPost GetUserPostById(Guid id)
        {
            if (id != null)
            {
                return DbContext.TblPost.FirstOrDefault(x => x.PostId == id);
            }
            return null;
        }

        public List<TblComment> GetCommentByPost(Guid postguid, Guid userguid)
        {
            if (postguid != null && userguid != null)
            {
                return DbContext.TblComment.Where(x => x.UserId == userguid && x.PostId == postguid).ToList();

            }
            return null;
        }

        
        TblComment IUserPostService.AddCommentOnPost(TblComment objtblcomment)
        {
            if(objtblcomment != null)
            {
                DbContext.TblComment.Add(objtblcomment);
                DbContext.SaveChanges();
                return objtblcomment;
            }
            return null;
        }

        TblComment IUserPostService.EditCommentOnPost(Guid id)
        {
            var data = DbContext.TblComment.Where(x => x.Id == id).FirstOrDefault();
            if(data != null)
            {
                return data;
            }
            return null;
        }

        TblComment IUserPostService.DeleteCommentOnPost(Guid id)
        {
            var usercomnt = DbContext.TblComment.FirstOrDefault(x => x.Id == id);
            if(usercomnt != null)
            {
                DbContext.Remove(usercomnt);
                DbContext.SaveChanges();
                return usercomnt;
            }
            else
            {
                return null;
            }
            

        }

        TblComment IUserPostService.UpdateCommentOnPost(TblComment objtblcomment)
        {
            var data = DbContext.TblComment.FirstOrDefault(x => x.Id == objtblcomment.Id);
            if (data != null)
            {
                data.Content = objtblcomment.Content;
                DbContext.SaveChanges();
                return data;
            }
            return null;
        }
    }
}
