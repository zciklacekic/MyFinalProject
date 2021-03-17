using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle 
    //Yazılıma yeni bir ozellik eklediğinde mevcuttaki kodları değiştirme
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();
            //Data Transformation Objects

            Console.WriteLine(Base64Encode("admciklacekicz@trdomain.net:Deneme99"));
            Console.WriteLine(Base64Decode("YWRtY2lrbGFjZWtpY3pAdHJkb21haW4ubmV0OkRlbmVtZTk5"));


        }
        public static string Base64Encode(string plainText) //Encode
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData) //Decode
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            //ProductManager productManager = new ProductManager(new InMemoryProductDal()); 
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            var result = productManager.GetProductDetails();
            //foreach (var product in productManager.GetAll())
            //foreach (var product in productManager.GetAllByCategoryId(2))
            //foreach (var product in productManager.GetByUnitPrice(40,100))
            if (result.Success==true)
            {
                foreach (var product in productManager.GetProductDetails().Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
