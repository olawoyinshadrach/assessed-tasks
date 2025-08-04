using System;
using System.Collections.Generic;
using FilmDataProject.Algorithms;
using System.Linq;
using System.Text;

namespace HeistProject{
    class Program{
        static void Main(string[] args){
            var heistgraph = new HeistGraph();
            bool hypo = true;
            while(hypo){
                Console.WriteLine("1. Add a valuable to be looted");
                Console.WriteLine("2. What is the risk/edge asociated with looting? ");
                Console.WriteLine("3. Display the heist graph");
                Console.WriteLine("4. Count graph nodes");
                Console.WriteLine("5. Count graph edges");
                Console.WriteLine("6. Count number of edges");

                Console.Write("Select from the menu above: ")
                var selected = Console.ReadLine();

                if(selected == "1"){
                    Console.WriteLine("What item do you plan to loot? ");
                    string lootname = Console.ReadLine();
                    Console.WriteLine("How many of the items do you plan to loot? ")
                    string lootQuantity = Console.ReadLine();
                    if(int.TryParse(lootQuantity, out int lootQuantity)){
                        heistgraph.AddNewNodes(new Loot(lootname, lootQuantity));
                        Console.WriteLine("Loot added to graph!");
                    }else{
                        Console.WriteLine("Node not parse-able");
                    }
                    return;
                }else if(selected == "2"){
                    var graphnodes = heistgraph.GetGraphNodes();
                    if(graphnodes.Count >= 2){
                        Console.WriteLine("The nodes are: ")
                        foreach (var node in graphnodes){
                            Console.WriteLine($"{node}")
                        }
                    }else{
                        Console.WriteLine("There is a need for more  or more nodes to form an edge");
                    }
                }
            }
        }     
    }
}