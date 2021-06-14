using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Y9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myShoppingList = new List<string>();
            string userItem = "";
            //Comment

            do
            {
                Console.Write("Enter item: ");
                userItem = Console.ReadLine();

                if (userItem != "end")
                {
                    myShoppingList.Add(userItem);
                }
            } while (userItem != "end");

            Console.WriteLine("Your list:");

            foreach (string item in myShoppingList)
            {
                Console.WriteLine(item);
            }

            string itemToRemove = "";
            Console.Write("Which item to remove: ");
            itemToRemove = Console.ReadLine();
            myShoppingList.Remove(itemToRemove);

            Console.WriteLine("Your list:");
            foreach (string item in myShoppingList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
