using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.Models;

namespace WebAPICore.IServices
{
    public interface IUserPostService
    {
        List<TblPost> GetUserPost();
        TblPost GetUserPostById(Guid id);
        TblPost AddUserPost(TblPost tblPost);

        TblPost DeleteGetUserPost(Guid id);
        List<TblComment> GetCommentByPost(Guid postguid, Guid userguid);
        TblComment AddCommentOnPost(TblComment objtblcomment);
        TblComment EditCommentOnPost(Guid id);
        TblComment DeleteCommentOnPost(Guid id);
        TblComment UpdateCommentOnPost(TblComment objtblcomment);


    }
}
