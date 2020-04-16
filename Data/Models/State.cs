using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class State
    {
        public int StateId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
