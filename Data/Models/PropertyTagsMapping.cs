using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class PropertyTagsMapping
    {
        public int PropertyTagsMappingId { get; set; }
        public int? PropertyId { get; set; }
        public int? TagId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
