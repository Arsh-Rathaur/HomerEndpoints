using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Tags
    {
        public int TagId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
