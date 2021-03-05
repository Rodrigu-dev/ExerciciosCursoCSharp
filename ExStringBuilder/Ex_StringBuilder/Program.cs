using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_StringBuilder.Entities;

namespace Ex_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow thats awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to new Zealand",
                "I'm going to visit this wonderful country!",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night guys");
            Comment c4 = new Comment("See you tomorrow");

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);

            p2.AddComment(c3);
            p2.AddComment(c4);


            Console.WriteLine(p1);
            Console.WriteLine(p2);



            Console.ReadKey();
        }
    }
}
