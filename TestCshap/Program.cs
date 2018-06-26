using System;
using System.Collections.Generic;
using TestCshap.controller;
using TestCshap.entity;

namespace TestCshap
{
    class Program
    {
        private static ProductController _controller = new ProductController();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("---------------Menu Product---------------");
                Console.WriteLine("1, Add product records.");
                Console.WriteLine("2, Display product records.");
                Console.WriteLine("3, Delete product by Id.");
                Console.WriteLine("4, Exit.");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Please enter choice(1|2|3|4): ");
                
                int choice = Int32.Parse(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You choice add product records.");
                        _controller.AddProduct();
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("You choice display product records.");
                        _controller.DisplayProduct();
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("You choice delete product Id.");
                        _controller.DeleteProduct();
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Exit. Bye bye");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Your choice is wrong. Please retype.");
                        break;
                }
            }
        }

        
    }
}