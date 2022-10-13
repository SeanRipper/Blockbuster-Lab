using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster_Lab
{
    public class Blockbuster
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public Blockbuster()
        {
            Movies.Add(new DVD("Die Hard", Genre.Action, 93, new List<string> {"Barefoot on the Plane","Hippie Kai Ye Mother F'er", "McClain kills Gruber" }));
            Movies.Add(new DVD("The Dark Knight", Genre.Drama, 132, new List<string> { "Bank Heist","The Joker does his best Zodiac Killer impression", "Cruise Ship bombs","Fake Hostages", "Rachel or Harvey?", "Two-Face's Revenge Tour" }));
            Movies.Add(new DVD("The Big Lebowski", Genre.Comedy, 102, new List<string> { "Baptism", "Carpet peeing", "Donnie is out of his element", "I can get you a toe, Dude", "This is what happens Larry", "Donnie's Eulogy" }));
            Movies.Add(new VHS("Inception", Genre.Action, 145, new List<string> { "Failing Inception","Cobb recruits his crew", "Car chase in a van", "The Rotating Hotel","Snow-mobile chase ripped from James Bond","Successful Inception" }));
            Movies.Add(new VHS("IT", Genre.Horror, 193, new List<string> { "Poor Georgy", "The shower starts to bleed", "We all float down here" }));
            Movies.Add(new VHS("The Notebook", Genre.Romance, 140, new List<string> { "Couple falls in love", "Couple breaks up", "Couple falls in love again" }));
        }
        public static void PrintMovies(List<Movie> movies)
        {
            for(int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine((i+1) + ": " + movies[i].Title);
            }
        }
        public static void CheckOut()
        {

        }
        public static void PrintInfo(Movie m)
        {
            Console.WriteLine("Title: " + m.Title);
            Console.WriteLine("Catoegory: " + m.Category);
            Console.WriteLine("Runtime: " + m.RunTime + " minutes");
            
        }
    }
}
