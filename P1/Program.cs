using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide your name: ");
            string name = readName();
            Console.WriteLine($"Welcome to restraunt {name} !!");
            while(true)
            {
                //Console.WriteLine("Select the option from below menu: ");
                Console.WriteLine("         BURGERS");
                Console.WriteLine("1.Spicy Chiken Burger - $6.76\n2.Chicken Burger - $5.25" +
                    "\n3.Vegan - $4.99\n4.Cheese Burger - $5.15");

                Console.WriteLine("         Drinks ($6.25 per Drink)");
                //Console.WriteLine("1.Coke\n2.Pepsi\n3.Dr.Pepper\n4.Lemonade\n5.Mineral Water");
                Console.Write("Select Type of Burger: ");
                var burgerOption = Console.ReadLine();
                while(true)
                {
                    Console.Write("Select quantity: ");
                    var quantity = Console.ReadLine();

                    if(Convert.ToInt32(quantity) > 0 )
                    {
                        break;
                    } else
                    {
                        Console.WriteLine("Enter valid quantity i.e., 1 or more");
                    }
                }
               
                //Console.Write("Select Type of Drink: ");
                //var drinkOption = Console.ReadLine();

                Console.WriteLine("Do you want to order again: ");
                var choice = Console.ReadLine();
                if (choice == "n")
                {
                    break;
                }
            }


        }

        private static string readName()
        {
            return Console.ReadLine();
        }
    }
}
