using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICore.ViewModel
{
    public class newsfeed
    {
        public string MediaName { get; set; }
        public string MediaDiscription { get; set; }
        public string MediaUrl { get; set; }
        public string TextHeading { get; set; }
        public string TextDiscription { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
