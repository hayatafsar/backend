using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        public static IWebHostEnvironment _environment;

        public FileUploadController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        public class FileUploadAPI
        {
            public IFormFile files { get; set; }
        }
        [HttpPost]
        public async Task<string> Post ([FromForm]FileUploadAPI objFile)
        {
            

                if (objFile.files.Length > 0)
                {
                try
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\Upload\\"))
                    {
                        Directory.CreateDirectory(_environment.WebRootPath + "\\Upload\\");
                    }
                    using (FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\Upload\\" + objFile.files.FileName))
                    {
                        objFile.files.CopyTo(fileStream);
                        fileStream.Flush();
                        return "\\Upload\\" + objFile.files.FileName;
                    }
                }


                catch (Exception ex)
                {
                    return ex.Message.ToString();
                }

            }
                else {

                    return "Failed";

                }
            

        }




    }
}
