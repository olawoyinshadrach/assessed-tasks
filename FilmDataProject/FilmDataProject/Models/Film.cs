using System;
using System.Collections.Generic;
using FilmDataProject.Algorithms;
using System.Linq;
using System.Text;

namespace FilmDataProject.Algorithms{
    public class Film{
        public string Title{
            get;
            set;
        }
        public string Director{
            get;
            set;
        }
        public string Quantity{
            get;
            set;
        }

        //constructor
        public Film(string title, string director, int quantity){
            Title = title;      //must be unique
            Director = director;
            Quantity = quantity;
        }

        public override string StringMerge(){
            string MergeString = $"{Title} was directed by {Director} , who produced {Quantity} reels";
            return MergeString;
        }
    }
}