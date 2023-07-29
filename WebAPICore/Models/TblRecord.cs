using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPICore.Models
{
    public partial class TblRecord
    {
        public Guid RecordGuid { get; set; }
        public Guid? MediaGuid { get; set; }
        public Guid? TextGuid { get; set; }
        public Guid? UserGuid { get; set; }
        public int? LikeStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
