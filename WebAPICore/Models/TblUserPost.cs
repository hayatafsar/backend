using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPICore.Models
{
    public partial class TblUserPost
    {
        public string MediaName { get; set; }
        public string TextHeading { get; set; }
        public string TextDiscription { get; set; }
        public Guid? Userguid { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
