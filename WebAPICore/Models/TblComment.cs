﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPICore.Models
{
    public partial class TblComment
    {
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public string Content { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? PostId { get; set; }
    }
}
