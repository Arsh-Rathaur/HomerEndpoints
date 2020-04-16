using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class DocumentTypes
    {
        public int DocumentTypeId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
