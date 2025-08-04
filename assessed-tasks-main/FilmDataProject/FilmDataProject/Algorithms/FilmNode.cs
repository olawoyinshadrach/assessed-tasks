using System;
using System.Collections.Generic;
using FilmDataProject.Models;
using System.Linq;
using System.Text;
//Binart Tree Node implementation

namespace FilmDataProject.Algorithms{
    public class FilmNode{
    public Film FilmData{
        get;
        set;
    }
    public FilmNode LeftNode{
        get;
        set;
    }
    public FilmNode RightNode{
        get;
        set;
    }

    //constructor
    public FilmNode(Film film){
        Film = film;
        LeftNode = null;
        RightNode = null;
    }

}
}
