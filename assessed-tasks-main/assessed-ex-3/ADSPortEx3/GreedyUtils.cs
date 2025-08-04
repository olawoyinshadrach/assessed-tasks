using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx3
{
    class GreedyUtils
    {
        //Greedy algorithm implementation for Assessed Exercise 3

        //Hints : 
        //Use lecture materials from Week 8
        // to aid with implementation...

        //You can take a list of items obtained from the user in the menu driven interface then convert it into
        // an array as you work your way towards a viable solution.

        //The delivered solution cannot exceed a weight limit of 100KG, make sure you are keeping track of this


        // - Adam.M 

        public static List<Item> GetGreedyManifesto(List<Item> items, double limit){
            Item[] sortedListItems = items.ToArray();

            List<Item> result = new List<Item>();
            double totalWeight = 0;

            InsertSortGen(sortedListItems);
    
            foreach (Item item in sortedListItems){
                if (totalWeight + item.Weight <= limit){
                    result.Add(item);
                    totalWeight += item.Weight;
                }
                else{
                    // do nothing
                }
            }
            return result;
            //throw new NotImplementedException();
        }
    }
}
