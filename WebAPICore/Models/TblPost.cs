using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPICore.Models
{
    public partial class TblPost
    {
        public Guid PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }
        public string PostImage { get; set; }
        public Guid? UserGuid { get; set; }
        public Guid? CategoryId { get; set; }
    }
}
