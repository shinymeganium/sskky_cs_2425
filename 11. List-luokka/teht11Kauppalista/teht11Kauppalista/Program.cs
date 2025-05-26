using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht11Kauppalista // 11.2 on viiminen tiedosto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>();
            bool continueProgram = true;

            Console.WriteLine("Shopping list");
            DisplayMenu();
            
            while (continueProgram == true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int option) == true)
                {
                    if (input == "1")
                    {
                        bool addMore = true;
                        while (addMore == true)
                        {
                            Console.WriteLine("What would you like to add to the shopping list?");
                            string item = Console.ReadLine();
                            shoppingList.Add(item);
                            Console.WriteLine($"{item} added to the shopping list \n");
                            Console.WriteLine("Would you like to add another item? y/n");
                            string yesOrNo = Console.ReadLine();

                            if (yesOrNo == "y")
                                addMore = true;
                            else if (yesOrNo == "n")
                                addMore = false;
                            else
                                Console.WriteLine("Wrong input, please select y (yes) or n (no).");
                        }
                    }
                    else if (input == "2")
                    {
                        if (shoppingList.Count > 0)
                        {
                            Console.WriteLine("Shopping list contains:");
                            for (int i = 0; i < shoppingList.Count; i++)
                                Console.WriteLine($"- {shoppingList[i]}");
                            Console.WriteLine();
                        }
                        else
                            Console.WriteLine("Nothing on the list. \n");
                    }
                    else if (input == "3")
                    {
                        bool removeItem = true;
                        while (removeItem)
                        {
                            Console.WriteLine("What would you like to remove from the shopping list?");
                            string removedItem = Console.ReadLine();

                            if (shoppingList.Contains(removedItem))
                            {
                                shoppingList.Remove(removedItem);
                                Console.WriteLine($"{removedItem} was removed from the list.");
                            }
                            else
                                Console.WriteLine($"{removedItem} was not on the list. Nothing was removed.");

                            Console.WriteLine("Would you like to remove another item? y/n");
                            string yesOrNo = Console.ReadLine();

                            if (yesOrNo == "y")
                                removeItem = true;
                            else if (yesOrNo == "n")
                                removeItem = false;
                            else
                                Console.WriteLine("Wrong input, please select y (yes) or n (no).");
                        }
                    }
                    else if (input == "4")
                    {
                        Console.WriteLine("Closing shopping list.");
                        continueProgram = false;
                    }
                    else
                        Console.WriteLine("Plese give a right input (1, 2, 3, or 4)\n");
                }
                else
                    Console.WriteLine("Please give a right input (1, 2, 3 or 4)");

                Console.WriteLine("What would you like to do?");
                DisplayMenu();
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("1: Add to list");
            Console.WriteLine("2: See list");
            Console.WriteLine("3: Remove from list");
            Console.WriteLine("4: Exit");
        }
    }
}
