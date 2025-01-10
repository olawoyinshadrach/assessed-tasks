using System;
using System.Collections.Generic;
using FilmDataProject.Models;
using System.Linq;
using System.Text;

//Binary Search Tree implementation
namespace FilmDataProject.Algorithms{
    public class AVLBTree:BinTree{

        private node RotateNodeRight(FilmNode b){
            FilmNode a = b.LeftNode;
            FilmNode T2 = a.RightNode;
            a.RightNode = b;
            b.LeftNode = T2;

            updateTreeHeight(b);
            updateTreeHeight(a);

            return a;
        }

        private Node RotateLeft(Node a){
            FilmNode b = a.RightNode;
            FilmNode T2 = b.LeftNode;
            b.LeftNode = a;
            a.RightNode = T2;

            updateTreeHeight(a);
            updateTreeHeight(b);

            return b;


        }

        private FilmNode SelfBalande(FilmNode filmnode){
            int factor = getFactor(filmnode);
            if(factor > 1){
                if(getFactor < 0 ){
                    filmnode.LeftNode = RotateLeft(filmnode.LeftNode)
                }else{
                    return RotateRight(filmnode)
                }
                
            }else if(factor < -1){
                if(getFactor(filmnode.RightNode) > 0){
                    filmnode.RightNode = RotateNodeRight(filmnode.RightNode);
                return RotateNodeLeft(filmnode);
                }
            }
            return filmnode;
        }

        private void InsertNode(FilmNode filmnode, Film film){
            if(filmnode == null){
                return new FilmNode(film);
            }else{
                return null;
            }

            if(string.CompareOrdinal(film.Title, .Film.Title) == 0){
                throw new InvalidOperationException("YOu cannot compare same film title!");           
            }else if(string.CompareOrdinal(film.Title, .Film.Title) > 0){
                filmnode.RightNode = InsertNode(node.RightNode, film)
            }else{
                filmnode.LeftNode = InsertNode(node.LeftNode, film);
            }

            updateTreeHeight(filmnode);
            return SelfBalande(filmnode);
        }

        private void RemoveNode(FilmNode filmnode, string title){
            if(node == null){
                return null;
            }else{
                if(string.CompareOrdinal(title, filmnode.Film.Title) > 0){
                    filmnode.RightNode = RemoveNode(node.RightNode, title)
                }else if(string.CompareOrdinal(title, filmnode.Film.Title) < 0){
                    filmnode.LeftNode = RemoveNode(filmnode.LeftNode, title);
                }else if(string.CompareOrdinal(title, filmnode.Film.Title) == 0){
                    if(filmnode.RightNode == null || filmnode.LeftNode == null){
                        filmnode = filmnode.RightNode ?? filmnode.LeftNode.Film;
                    }else{
                        filmnode.Film = GetLowestNode(filmnode.RightNode).Film;
                        filmnode.RemoveNode = RemoveNode(filmnode.RightNode, GetLowestNode(node.RightNode).Film.Title);
                    }
                }
                
                if(filmnode == null){
                    return null;
                }else{
                    updateTreeHeight(filmnode);
                    return SelfBalande(filmnode);
                }
            }
        }

        public void invokeRemoveNode(string title){
            Root = RemoveNode(Root, title);
        }

        private int GetNodeHeight(FilmNode filmnode){
            if(filmnode == null){
                return -1;
            }else{
                return filmnode.Height;
            }
        }

        private void updateTreeHeight(FilmNode filmnode){
            int tallest = Math.Max(GetNodeHeight(filmnode.LeftNode), GetNodeHeight(filmnode.RightNode) +1);
            filmnode.Height = tallest;
        }

        public int GetTreeHeight(){
            return GetNodeHeight(root);
        }

        private Node GetShortestNode(FilmNode filmnode){
            FilmNode temp = filmnode;
            while (temp.LeftNode != null){
                temp = temp.LeftNode;
            return temp;
            }
        }

        public void invokeRemoveNode(string title){
            Root = RemoveNode(Root, title);
        }

        public void InvokeInsert(Film film){
            //Root is defined in BinTree as protected, it is therefore accessible to the AVBLTree class and its methods.
            Root = InsertNode(Root, film);
        }

       
    }
}