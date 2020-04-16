using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class PropertyAge
    {
        public int PropertyAgeId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
