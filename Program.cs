using Movies;
using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static public void Main(String[] args)
    {

        List<Movie> movies = new List<Movie>();
        string cont;
        movies.Add(new Movie("The Fellowship of the Ring", "Action"));
        movies.Add(new Movie("Who Am I?", "Action"));
        movies.Add(new Movie("The Gentlemen", "Action"));
        movies.Add(new Movie("Karate Kid", "Action"));
        movies.Add(new Movie("Why Him?", "Comedy"));
        movies.Add(new Movie("Night School", "Comedy"));
        movies.Add(new Movie("The Princess Bride", "Comedy"));
        movies.Add(new Movie("A Quiet Place", "Horror"));
        movies.Add(new Movie("It", "Horror"));
        movies.Add(new Movie("Get Out", "Horror"));

        movies.ToArray();


        do
        {
            Console.WriteLine("Welcome to Jack's Theatre! \nPlease select either horror, comedy, or action");
            string genre = Console.ReadLine();

            if (genre.ToLower().Equals("horror"))
            {
                Console.WriteLine("Excellent choice! Our Horror movies are as follows:");
                Console.WriteLine(movies[7].ToString());
                Console.WriteLine(movies[8].ToString());
                Console.WriteLine(movies[9].ToString());
            }
            else if (genre.ToLower().Equals("comedy"))
            {
                Console.WriteLine("Excellent choice! Our Comedy movies are as follows:");

                Console.WriteLine(movies[4].ToString());
                Console.WriteLine(movies[5].ToString());
                Console.WriteLine(movies[6].ToString());
            }
            else if (genre.ToLower().Equals("action"))
            {
                Console.WriteLine("Excellent choice! Our Action movies are as follows:");

                Console.WriteLine(movies[0].ToString());
                Console.WriteLine(movies[1].ToString());
                Console.WriteLine(movies[2].ToString());
                Console.WriteLine(movies[3].ToString());
            }
            else
            {
                Console.WriteLine("Please enter a valid movie genre! We provide action, comedy, and horror Movies");
            }
            Console.WriteLine("Would you like to continue? (y/n)");
            cont = Console.ReadLine();
        } while (cont.ToLower().Equals("y"));
        Console.WriteLine("Thanks for visiting Jack's Theatre! Have a nice day!");
       




    }








}
