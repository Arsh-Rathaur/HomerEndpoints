using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Locality
    {
        public int LocalityId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
