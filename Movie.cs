using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    public class Movie
    {
        private string title;
        private string category;

        public Movie(string title, string category)
        {
            this.title = title;
            this.category = category; 
        }


        //getter
        public string GetTitle()
        {
            return title;
        }

        //setter
        public void SetTitle(string title)
        {
            this.title = title;
        }

        //getter
        public string GetCategory()
        {
            return category;
        }

        //setter
        public void SetCategory(string category)
        {
            this.category = category;
        }

  
    public override string ToString()
        {
            return GetTitle() + ": " + GetCategory();
        }
    }
}
