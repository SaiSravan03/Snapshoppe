using SnapShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapShopDAL
{
    public  class SnapShopRepository
    {
        SnapShopContext context = new SnapShopContext();
        public SnapShopRepository()
        {
                
        }

        public bool DeleteProductFrmCartByPId(byte productId,string EmailId)
        {
            bool res = false;
            try
            {
                var obj = (from prd in context.Carts
                           where prd.ProductId == productId && prd.EmailId == EmailId
                           select prd).FirstOrDefault();
                if (obj != null)
                {
                    context.Carts.Remove(obj);
                    context.SaveChanges();
                    res = true;
                }
                else
                {
                    res = false;
                }
            }
            catch (Exception)
            {
                res=false;
                throw;
            }
            return res;
        }
    }
}
