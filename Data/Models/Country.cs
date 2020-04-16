using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Country
    {
        public int CountryId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
