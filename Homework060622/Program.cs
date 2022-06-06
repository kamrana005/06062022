using System;

namespace Homework060622
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Product elave et.");
            Console.WriteLine("2.Product sat.");
            Console.WriteLine("3.Productlara bax.");
            Console.WriteLine("4.Menudan cix.");

            string numstr = Console.ReadLine();
            int num = Convert.ToInt32(numstr);
            Product[] products = new Product[5];



            if ( num == 1)
            {

                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. Product No:");
                    string No = Console.ReadLine();
                    Console.WriteLine($"{i + 1}. Product Name:");
                    string Name = Console.ReadLine();
                    Console.WriteLine($"{i + 1}. Product Price:");
                    string Pricestr = Console.ReadLine();
                    int Price = Convert.ToInt32(Pricestr);
                    Console.WriteLine($"{i + 1}. Product Count:");
                    string Countstr = Console.ReadLine();
                    int Count = Convert.ToInt32(Countstr);
                    

                    products[i] = new Product()
                    {
                        No = No,
                        Name = Name,
                        Price = Price,
                        Count = Count

                    };

                }



            }
            if(num == 2)
            {
                Console.WriteLine("Product No daxil edin:");
                 string nostr=Console.ReadLine();
                int no = Convert.ToInt32(nostr);
                Console.WriteLine(products.SellProduct(no));
                    


            }
            if(num== 3)
            {
               foreach(var item in products)
                {
                    item.ShowInfo();
                }

            }
            if ( num == 4) ;


           
            
              
            
                
            
           








        }
    }
}
