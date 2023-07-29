using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.IServices;
using WebAPICore.Models;
using WebAPICore.ViewModel;

namespace WebAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsfeedController : ControllerBase
    {
        private readonly INewsfeedService newsfeedService;
        public NewsfeedController(INewsfeedService newsfeed)
        {
            newsfeedService = newsfeed;
        }

    //    [HttpGet]
    //    [Route("[action]")]
    //    [Route("api/Newsfeed/GetPost")]
    //    public List<TblUserPost> GetPost()
    //    {
    //         var obj= newsfeedService.GetPost();
    //        if(obj != null)
    //        {
    //            return obj;
    //        }
    //        return null;
    //    }

    //    [HttpPost]
    //    [Route("[action]")]
    //    [Route("api/Newsfeed/addpost")]
    //    public IActionResult AddPost([FromBody] TblPost tblPost)
    //    {
    //        var obj = newsfeedService.AddPost(tblPost);
    //        if (obj != null)
    //        {
    //            return obj;
    //        }
    //        return null;
    //    }

    //    [HttpPut]
    //    [Route("[action]")]
    //    [Route("api/Newsfeed/editpost")]
    //    public IActionResult EditPost([FromBody] TblPost tblPost)
    //    {
    //        var obj = newsfeedService.EditPost(tblPost);
    //        if (obj != null)
    //        {
    //            return obj;
    //        }
    //        return null;
    //    }

    //    [HttpPut]
    //    [Route("[action]")]
    //    [Route("api/Newsfeed/deletepost")]
    //    public IActionResult DeletePost([FromHeader] int id)
    //    {
    //        var obj = newsfeedService.DeletePost(id);
    //        if (obj != null)
    //        {
    //            return obj;
    //        }
    //        return null;
    //    }
    }
}
