//Binary Tree Implementation

using System;
using System.Collections.Generic;
using ThemeParkProject.Models;
using System.Linq;
using System.Text;

namespace FilmDataProject.Algorithms{
        public class FilmTree{
            public FilmNode Root{
                //can only be set within same class
                private set;
                get;
            }

            //regular insertion of a root: make the inserted nod the root
            public void Insert(Film insertedfilm){
                Root = RecursiveInsertion(Root, insertedfilm)
            }

            public FilmNode RecursiveInsertion(FilmNode root, Film insertedfilm ){
                //if no root, make the inserted node the root
                if(root==null){
                    return new FilmNode(film);
                }else{
                    return null;
                }

                bool result = string.CompareOrdinal(film.Title, root.Film.Title);
                if(result < 0){
                    root.LeftNode = RecursiveInsertion(root.LeftNode, film);

                }else if(result > 0){
                    root.RightNode = RecursiveInsertion(root.RightNode, film);
                }
                return root
            }

            public int CurrentHeight(FilmNode root){
                if(root != null){
                    int treeLeftHeight = CurrentHeight(root.LeftNode);
                    int treeRightHeight = CurrentHeight(root.RightNode);
                    int currentHeight = Math.Max(treeLeftHeight, treeRightHeight) + 1;
                    return currentHeight;
                }
            }

            public void PreorderTreeTraversal(FilmNode root){
                if(root != null){
                    Console.WriteLine(root.FilmNode);
                    PreorderTreeTraversal(root.LeftNode);
                    PreorderTreeTraversal(root.RightNode);

                }
            }

            public void PostorderTreeTraversal(FilmNode root){
                if(root != null){
                    PostorderTreeTraversal(root.LeftNode);
                    PostorderTreeTraversal(root.RightNode)
                    Console.WriteLine(root.FilmNode);
                }
            }

            public void InorderTreeTraversal(FilmNode root){
                if(root != null){
                    InorderTreeTraversal(root.LeftNode);
                    Console.WriteLine(root.FilmNode);
                    InorderTreeTraversal(root.RightNode);
                }
            }

        }
}

