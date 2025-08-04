using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeistProject{
    public class Loot{
        public string ItemName { 
            get; 
            set; 
        }
        public int LootValue {
            get; 
            set; 
        }
        public Loot(string itemname, int lootValue){
            ItemName = itemname;
            LootValue = lootValue;
        }

        public override string MergeStrings(){
            return $"We shall loot {LootValue} {ItemName} ";
        }

        public class HeistGraphNode{
            public Loot LootItem{
                get;
                set;
            }

            public List<(HeistGraphNode, int)> Edges{
                get;
                set;
            }

            public HeistGraphNode(Loot lootitem){
                Edges = new List<(HeistGraphNode, int)>();
                LootItem = lootitem;    
            }

            public void AddEdge(HeistGraphNode graphNode, int edgeWeight){
                private bool weightCondition = edgeWeight > 10 || edgeWeight < 1
                graphNode == null || weightCondition ? return : Edges.Add(graphNode, edgeWeight);
            }

            public override string ConvertToString(){
                return LootItem.ToString();
            }
        }

        public class HeistGraph{
            private List<HeistGraphNode> graphnodes;
            public int NumberOfEdges(){
                get;
                private set;
            } 
            public int NumberOfNodes(){
                return graphnodes.Count;
            }
            
            public HeistGraph(){
                NumberOfEdges = 0;
                graphnodes = new List<HeistGraphNode>();
            }

            public HeistGraphNode AddNewNodes(Loot lootitem){
                var currentNode = new HeistGraphNode(lootitem);
                graphnodes.add(currentNode);
                return currentNode;
            }

            public void AddNewEdge(HeistGraphNode source, HeistGraphNode dest, int edgeWeight){
                private bool weightCondition = edgeWeight > 10 || edgeWeight < 1
                if(source == null || dest == null || weightCondition || source || dest ){
                    console.WriteLine("Bad parameters");
                    return;
                }else{
                    dest.AddEdge(source, dest);
                    NumberOfEdges++;
                }
            }

            public void DisplayHeistGraph(){
                for(int i=0; i<nodes.Count; i++){
                    Console.WriteLine($"graph node {graphnode.LootItem}");
                }
            }

            public List<GraphNodes> GetGraphNodes (){
                return graphnodes;
            }
            
        }

    }   
}