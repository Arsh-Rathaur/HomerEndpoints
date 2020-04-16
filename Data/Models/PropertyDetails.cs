using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class PropertyDetails
    {
        public int PropertyDetailId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
