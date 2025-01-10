using System;
using System.Collections.Generic;
using FilmDataProject.Models;
using FilmDataProject.Algorithms;
using System.Linq;
using System.Text;

//Binary Search Tree implementation
namespace FilmDataProject{
    class Program{
        static void Main(string[] args){
            FilmBSTree tree = new FilmBSTree();
            while(true){ 
                //create a menu of questions for user to select from:
                Console.WriteLine("type question number to select question from menu below: ")
                Console.WriteLine("1: Add film to the record");
                Console.WriteLine("2: Display the films in record");
                Console.WriteLine("3: Calculate the height of the tree");
                Console.WriteLine("4: Calculate the total number of films stored");
                Console.WriteLine("5: Update a film title, director or number of reels");
                Console.WriteLine("6: Close program");

                string random; 

                Console.WriteLine("Chose a film: ");
                random = Console.ReadLine(); // taking input from user
                Console.WriteLine("Your choice film is : " +random);

                if(random === "1"){
                    Console.WriteLine("What is the title?");
                    string title = Console.ReadLine();

                    Console.WriteLine("Who is the director?")?;
                    string director = Console.ReadLine();

                    Console.WriteLine("How many of this film reels did the director produce?")?;
                    string quantity = int.Parse(Console.ReadLine());

                    Film film = new Film(title, director, quantity);
                    Console.WriteLine("Film added to tree");
                    tree.Insert(film);

                }else if( random == "2"){
                    Console.WriteLine("chose a traversal type to display films. They include: InOrder, PreOrder and PostOrder traversal types. ");
                    string traversal = Console.ReadLine();
                    tree.DisplayTreeContent(traversal);
                }else if(random === "3"){
                    Console.WriteLine($"Tree has a height of {tree.CurrentHeight()}")
                }else if(random == "4"){
                    Console.WriteLine($"{tree.CountNumberNodes}")
                }else if(random == "5"){
                    Console.WriteLine("What is the new title? ");
                    string newTitle = Console.ReadLine();

                    Console.WriteLine("What is the name of the director? ");
                    string newDirector = Console.ReadLine();

                    Console.WriteLine("Enter the new number of reels of this film: ");
                    string newQuantity = Console.ReadLine();
                    int.Parse(newQuantity);

                    if(tree.recursiveNodeUpdate(newTitle, newDirector, newQuantity) == true){
                        Console.WriteLine("Film successfully updated");
                    }else{
                        COnsole.WriteLine("sorry, Film update filed")
                    }
                }else if(random == "6"){
                    Console.WriteLine("Good bye!");
                }else{
                    Console.WriteLine("Invalid choice, select from 1 to 6")
                }

            }
            
        }
    }
}