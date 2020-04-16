using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class PropertyDocuments
    {
        public int PropertyDocumentId { get; set; }
        public int? PropertyId { get; set; }
        public string DocumentName { get; set; }
        public string RemoteUrl { get; set; }
        public int? DocumentTypeId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
