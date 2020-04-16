using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class UserAccounts
    {
        public int UserAccountId { get; set; }
        public string UserAddress { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
