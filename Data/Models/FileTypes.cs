using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class FileTypes
    {
        public int FileTypeId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
