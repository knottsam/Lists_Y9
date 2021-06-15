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

            do
            {
                Console.Write("Enter item: ");
                userItem = Console.ReadLine();

                if (userItem != "end")
                {
                    myShoppingList.Add(userItem);
                }
            } while (userItem != "end");

            PrintList(myShoppingList);

            string itemToRemove = "";
            string more = "yes";

            do
            {
                Console.Write("Which item to remove: ");
                itemToRemove = Console.ReadLine();
                myShoppingList.Remove(itemToRemove);

                Console.WriteLine("Any more to remove?");
                more = Console.ReadLine();
            } while (more.ToLower() == "yes");

            PrintList(myShoppingList);

            Console.ReadLine();
        }

        public static void PrintList(List<string> inList)
        {
            Console.WriteLine("Your list:");
            foreach (string item in inList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
