using System;
using System.Collections.Generic;

namespace SnapShopDAL.Models
{
    public partial class Payment
    {
        public long Paymentid { get; set; }
        public string EmailId { get; set; }
        public DateTime Paymentdate { get; set; }
        public int Totalamount { get; set; }
        public string Paymentstatus { get; set; }

        public virtual Customer Email { get; set; }
    }
}
