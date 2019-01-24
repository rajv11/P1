using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide your name: ");
            string name = ReadName();
            Console.WriteLine($"Welcome to restraunt {name} !!");
            while(true)
            {
                Console.WriteLine("         BURGERS");
                Console.WriteLine("1.Spicy Chiken Burger - $6.76\n2.Chicken Burger - $5.25" +
                    "\n3.Vegan - $4.99\n4.Cheese Burger - $5.15\n");

                char burgerOption;
                int quantity = 0;
                decimal totalCost = 0.0m;
                bool option;

                
                while (true)
                {
                    Console.Write("Select Type of Burger: ");
                    burgerOption = Convert.ToChar(Console.ReadLine());
                    option = IsValid(burgerOption);
                    if (option)
                    {
                        break;
                    } else
                    {
                        Console.WriteLine("Entr a valid option. Try Again!!");
                    }
                }
                
                
                while (true)
                {
                    Console.Write("Select quantity: ");
                    quantity = Convert.ToInt32(Console.ReadLine());

                    if(quantity > 0 )
                    {
                        break;
                    } else
                    {
                        Console.WriteLine("Enter valid quantity i.e., 1 or more\n");
                    }
                }
                Console.WriteLine($"\n{name}'s Bill: ");
                switch (burgerOption)
                {
                    case '1' :
                        totalCost = TotalCost(6.76m, quantity);
                        Console.WriteLine($"{quantity} X Spicy Chiken Burger = ${totalCost}");
                        break;
                    case '2':
                        totalCost = TotalCost(5.25m, quantity);
                        Console.WriteLine($"{quantity} X Chicken Burger = ${totalCost}");
                        break;
                    case '3':
                        totalCost = TotalCost(4.99m, quantity);
                        Console.WriteLine($"{quantity} X Vegan = ${totalCost}");
                        break;
                    case '4':
                        totalCost = TotalCost(5.15m, quantity);
                        Console.WriteLine($"{quantity} X Cheese Burger = ${totalCost}");
                        break;
                    default:
                        Console.WriteLine("Select valid option");
                        break;
                }

                Console.Write("\nThank you for your order.  Visit Again \n");
               
                Console.WriteLine("Do you want to order again: ");
                var choice = Console.Read();
                if (choice == 'n')
                {
                    break;
                }
            }


        }
        private static bool IsValid(char option)
        {
            return option == '1' || option == '2' || option == '3' || option == '4';
        }
        private static decimal TotalCost(decimal cost, int number)
        {
            return cost * number;
        }
        private static string ReadName()
        {
            return Console.ReadLine();
        }
    }
}
