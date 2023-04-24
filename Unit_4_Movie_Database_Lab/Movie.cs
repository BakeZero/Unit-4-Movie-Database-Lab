using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4_Movie_Database_Lab
{
    internal class Movie
    {
        internal string Title { get; set; }
        internal string Category { get; set; }

        public Movie(string Title, string Category)
        { 
            this.Title = Title;
            this.Category = Category;
        }

        public void Display()
        {
            Console.WriteLine(Title);
        }
    }
}
