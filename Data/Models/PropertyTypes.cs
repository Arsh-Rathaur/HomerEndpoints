using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class PropertyTypes
    {
        public int PropertyTypeId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
