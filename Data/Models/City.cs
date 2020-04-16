using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class City
    {
        public int CityId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
