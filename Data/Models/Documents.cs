using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Documents
    {
        public int DocumentId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
