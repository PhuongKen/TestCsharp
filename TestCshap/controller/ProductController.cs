using System;
using System.Collections.Generic;
using System.Text;
using TestCshap.entity;

namespace TestCshap.controller
{
    public class ProductController
    {
        List<Product> list = new List<Product>();
        public void AddProduct()
        {
            
            while (true)
            {
                var p = new Product();
                Console.WriteLine("Please enter productID: ");
                p.ProductId = Console.ReadLine();
                Console.WriteLine("Please enter product name: ");
                p.ProductName = Console.ReadLine();
                Console.WriteLine("Please enter price: ");
                p.Price = Console.ReadLine();
                list.Add(p);
                Console.WriteLine("Would you like to add more?(y/n)");
                string cont = Console.ReadLine();
                if (cont.Equals("n"))
                {
                    break;
                }
            }
            
        }

        public void DisplayProduct()
        {

            Console.WriteLine("Dispaly product");
            Console.WriteLine("{0, -20}{1, -20}{2, -20}","Product ID","Product Name", "Price");
            Console.WriteLine("--------------------------------------------------------------");
            foreach (var i in list)
            {
                Console.WriteLine("{0,-20}{1,-20}{2,-20}",i.ProductId, i.ProductName, i.Price);
            }
        }

        public void DeleteProduct()
        {
            Console.WriteLine("Please enter ProductID");
            string id = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ProductId.Equals(id))
                {
                    list.RemoveAt(i);
                }
            }
        }
    }
}