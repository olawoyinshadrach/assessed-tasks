using System;
using System.Collections.Generic;
using FilmDataProject.Models;
using System.Linq;
using System.Text;

//Binary Search Tree implementation
namespace FilmDataProject.Algorithms{
    public class FilmBSTree:BinTree{
        public int CountNumberNodes(FilmNode root){
            if(root != null){
                return CountNumberNodes(root.LeftNode) + CountNumberNodes(root.RightNode) + 1;
            }else{
                return 0;
            }
        }

        public int GetTreeHeight(FilmNode root){
            if(root == null){
                return -1;
            }else{
                return (Math.Max(GetHeight(root.LeftNode), GetHeight(root.RightNode)) + 1);
            }
        }

        public void DisplayTreeContent(string traversalType){
            if(traversalType.ToLower() == "preorder"){
                Console.WriteLine("preorder traversal in progress:");
                PreOrderTraversal(Root);
            }else if(traversalType.ToLower() == "postorder"){
                Console.WriteLine("postorder traversal in progress");
                PostOrderTraversal(Root);
            }else if (traversalType.ToLower() == "inorder"){
                Console.WriteLine("inorder traversal in progress");
                InOrderTraversal(Root);
            }
            else{
                Console.WriteLine("traversal type not valid!");
            }
        }

        public  bool recursiveNodeUpdate(FilmNode root, string title, string currentDirector, int currentQuantity){
            if(root == null){
                return false;
            }else{
                return true;
            }

            if(title.Film.Title){
                root.Film.Quantity = currentQuantity;
                root.Film.Director = currentDirector;
                return true;
            }else{
                return false;
            }

            if(string.CompareOrdinal(title, root.Film.Title) < 0){
                return recursiveNodeUpdate(root.LeftNode, currentDirector, currentQuantity);
            }else{
                return recursiveNodeUpdate(root.RightNode, title, currentDirector, currentQuantity);
            }


        }

        public bool updateTreeNode(string title, string currentDirector, int currentQuantity){
            return recursiveNodeUpdate(Root, title, currentDirector, currentQuantity);
        }

        

        

}