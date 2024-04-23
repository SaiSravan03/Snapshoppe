using System;
using System.Collections.Generic;

namespace SnapShopDAL.Models
{
    public partial class Cart
    {
        public int CartId { get; set; }
        public string EmailId { get; set; }
        public byte? ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal? TotalAmount { get; set; }

        public virtual Customer Email { get; set; }
        public virtual Product Product { get; set; }
    }
}
