using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx3
{
    internal class Program
    {
        static void Main(string[] args){
            while (true){
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Sort with Integers");
                Console.WriteLine("2. Sort with Strings");
                Console.WriteLine("3. Exit");

                string user_choice = Console.ReadLine();

                switch (user_choice)
                {
                    case "1":
                        int[] numberArr = { 5, 2, 8, 1, 9 };
                        SortUtils.InsertSortGen(numberArr);
                        Console.WriteLine("Sorting completed: " + string.Join(", ", numberArr));
                        break;

                    case "2":
                        string[] stringArray = { "toothbrush", "towel", "shoes", "pen", "book" };
                        SortUtils.InsertSortGen(stringArray);
                        Console.WriteLine("Sorting completed: " + string.Join(", ", stringArray));
                        break;

                    case "3":
                        return;

                    default:
                        Console.WriteLine("Wrong user choice");
                        break;
                }
            }


            List<Item> ListOfItems = new List<Item>();

            Console.WriteLine("4. Select to add items: ");
            Console.WriteLine("5. Select to compute optimal payload: ");

            case "4":
                Console.WriteLine("Item name?: ");
                string name = Console.ReadLine();
                Console.WriteLine("Item value? (1-10): ");
                int value = int.Parse(Console.ReadLine());
                Console.WriteLine("Item weight in kg?: ");
                double weight = double.Parse(Console.ReadLine());

                Item newItem = new Item(name, value, weight);
                ListOfItems.Add(newItem);
                break;

            case "5":
                List<Item> totalItems = GreedyUtils.GetGreedyManifesto(ListOfItems, 100);
                Console.WriteLine("Allowed total Payload = max 100kg:");
                foreach (Item item in totalItems)
                {
                    Console.WriteLine($"Item Name:- {item.Name} kg");
                    Console.WriteLine($"Item Value:- { item.Value} kg")
                    Console.WriteLine($"Item Weight:- {item.Weight} kg")
                }
                Console.WriteLine($"Cummulative weight: {totallItems.Sum(i => i.Weight)}kg");
                break;
            }
        }
    }
