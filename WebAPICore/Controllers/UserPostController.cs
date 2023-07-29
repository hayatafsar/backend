using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.IServices;
using WebAPICore.Models;

namespace WebAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPostController : ControllerBase
    {
        private readonly IUserPostService userPostService;
        public UserPostController(IUserPostService _userPostService)
        {
          userPostService= _userPostService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/UserPost/GetUserPost")]
        public IActionResult GetUserPost()
        {
            List<TblPost> tblPost = new List<TblPost>();
            tblPost = userPostService.GetUserPost();
            if (tblPost != null)
            {
                return Ok(tblPost);
            }
            return null;
        }


        [HttpPost]
        [Route("[action]")]
        [Route("api/UserPost/AddUserPost")]
        public IActionResult AddUserPost([FromBody] TblPost objPost)
        {
            var UserPost = userPostService.AddUserPost(objPost);
            if (UserPost != null)
            {
                return Ok(UserPost);
            }
            return null;
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/UserPost/DeleteUserPost")]
        public IActionResult DeleteUserPost([FromHeader] Guid id)
        {
            TblPost UserPost = userPostService.DeleteGetUserPost(id);
            if (UserPost != null)
            {
                return Ok(UserPost);
            }
            return null;
        }

        //// comment get api
        [HttpGet]
        [Route("[action]")]
        [Route("api/UserPost/getcommentbypost")]
        public IActionResult GetCommentBYPost([FromHeader] Guid postguid, [FromHeader] Guid userguid)
        {

            if (postguid != null && userguid != null)
            {
                var data = userPostService.GetCommentByPost(postguid, userguid);
                return Ok(data);
            }
            return null;
        }
        // comment add api
        [HttpGet]
        [Route("[action]")]
        [Route("api/UserPost/addcommentonpost")]
        public IActionResult AddCommentOnPost([FromBody] TblComment objtblComment)
        {

            if (objtblComment != null)
            {
                var data = userPostService.AddCommentOnPost(objtblComment);
                return Ok(data);
            }
            return null;
        }

        // comment edit api
        [HttpGet]
        [Route("[action]")]
        [Route("api/UserPost/editcommentonpost")]
        public IActionResult EditCommentOnPost([FromHeader] Guid id)
        {

            if (id != null)
            {
                var data = userPostService.EditCommentOnPost(id);
                return Ok(data);
            }
            return null;
        }

        // comment update post api
        [HttpPut]
        [Route("[action]")]
        [Route("api/UserPost/updatecommentonpost")]
        public IActionResult UpdateCommentOnPost([FromBody] TblComment objtblComment)
        {

            if (objtblComment != null)
            {
                var data = userPostService.UpdateCommentOnPost(objtblComment);
                return Ok(data);
            }
            return null;
        }

        // comment delete post api
        [HttpDelete]
        [Route("[action]")]
        [Route("api/UserPost/deletecommentonpost")]
        public IActionResult DeleteCommentOnPost([FromHeader] Guid id)
        {

            if (id != null)
            {
                var data = userPostService.DeleteCommentOnPost(id);
                return Ok(data);
            }
            return null;
        }

        //Api for likes---------------------------------------------------------------------
        //like  api

        //Remove like api





    }
}
