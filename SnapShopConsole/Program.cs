using Microsoft.EntityFrameworkCore;
using SnapShopDAL;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

internal class Program
{
    private static void Main(string[] args)
    {
        SnapShopRepository repository = new SnapShopRepository();
       bool res= repository.DeleteProductFrmCartByPId(1,"netraRadder@gmail.com");
        if(res)
        {
            Console.WriteLine("product deleted successfully");
        }

    }
}