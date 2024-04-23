using System;
using System.Collections.Generic;

namespace SnapShopDAL.Models
{
    public partial class Order
    {
        public long OrderId { get; set; }
        public string EmailId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public virtual Customer Email { get; set; }
    }
}
