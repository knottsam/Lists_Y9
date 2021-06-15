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

            //We need to find an item in the list:
            int itemPosition = myShoppingList.IndexOf("Bread");
            Console.WriteLine("Bread is at position {0} in the list.", itemPosition);

            //We need to find what is at a certain position in the list:
            string item = myShoppingList[6];
            Console.WriteLine("The item at position {0} is: {1}.", 6, item);

            //We want to insert an item into the list:
            string newItem = "Cauliflower";
            myShoppingList.Insert(4, newItem);

            PrintList(myShoppingList);

            //We want to amend an item in the list:
            newItem = "Broccoli";
            myShoppingList[4] = newItem;

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
