using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Store
{
    class MainClass
    {
        static void Main(string[] args)
        {
           Product productBook = new Book(16.20M, 2, "Български хроники","Стефан Цанев", Genre.History, Nationality.Bulgarian,0) { Name = "Български хроники" };
            Store storeBooks = new Store();
            try
            {                
                    storeBooks.ProductList = new List<Product>()
                    {
                       // new Book(16.20M, 2, "Български хроники","Стефан Цанев", Genre.History, Nationality.Bulgarian,10),
                        new Book(12.00M, 25, "Въведение в C#","Светлин Наков", Genre.History, Nationality.Bulgarian,5,true),
                        new Book(16.20M, 2, "Под игото","Иван Вазов", Genre.History, Nationality.Bulgarian,0),
                        new Music(24.99M, 10, "Best of AC/DC", Nationality.English, 5, false),
                        new Music(24.99M, 10, "Best of АBBA", Nationality.English, 5, false),
                        new Toy(5M,5,"Бомба",0,false),
                        new Movie(11.99M, 0, "Life Of PI.", 5, true),
                        new Music(24.99M, 10, "Best of AC/DC", Nationality.English, 5, false),
                        new Book(11.99M, 3, "Csharp Fundamentals", "Boyan", Genre.War, Nationality.Bulgarian, 12, true),
                        new Toy(15M,2,"Количка",1,false),
                        new Toy(30M,5,"Самолет",1,false),
                    };
                    storeBooks.CheckAvailability(productBook);  
                
            }
            catch (ProductNotExistsExeption ex)
            {
                Logger logger = Logger.Instance();
                logger.Log(ErrorType.Error, ex.Message);
            }

            var orderedProductList = storeBooks.ProductList.OrderBy((x => x.GetType().ToString()));
            string currentproduct = "";
            List<string> productTypes = new List<string>();

            foreach (var product in orderedProductList)
            {
                if (currentproduct != product.GetType().Name)
                {
                    currentproduct = product.GetType().Name;
                    productTypes.Add(product.GetType().Name);
                }
            }
            while (true)
            {
                Console.Clear();

                string welcomeText = "Welcome to Krusty Shop. Feel free to buy as much as possible.\n";
                Console.WriteLine(welcomeText);

                for (int i = 0; i < productTypes.Count; i++)
                {
                    Console.WriteLine("({0}).{1}", i, productTypes[i]);
                }
                try
                {
                    string choice = productTypes[int.Parse(Console.ReadLine())];
                    Console.Clear();
                    Console.WriteLine("Section \"{0}\"\n", choice);
                    Console.Clear();
                    Console.WriteLine("Section \"{0}\"\n", choice);

                    foreach (var product in orderedProductList)
                    {
                        if (choice == product.GetType().Name)
                        {
                            Console.WriteLine("\"{0}\" for {1}lv.\nAvailable {2} pieces in depository. \nDiscount this week {3}lv\n", product.Name, product.Price,product.Quantity, product.Discount());
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter only one digit between [0-3]");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The number you enter must be between [0-3]. Thank you!");
                }

                Console.WriteLine("Go back? Y/N?");
                if (Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
            }
        }
    }
}