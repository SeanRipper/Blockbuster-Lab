using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster_Lab
{
    public enum Genre
    {
        Action,
        Horror,
        Comedy,
        Drama,
        Romance,
    }
    public abstract class Movie
    {
        public string Title { get; set; } 
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }
        public Movie(string title, Genre category, int runTime, List<string> scenes)
        {
            Title = title;
            Category = category;
            RunTime = runTime;
            Scenes = scenes;
        }
        public virtual void PrintInfo(Movie m)
        {
            Console.WriteLine("Title: " + m.Title);
            Console.WriteLine("Category: " + m.Category);
            Console.WriteLine("Runtime: " + m.RunTime + " minutes");
        }
        public static void PrintScenes(List<string> scenes)
        {
            int count = 0;  
            foreach(string scene in scenes)
            {
                Console.WriteLine("Scene " + count + ": " + scenes[count]);
                count++;
            }
        }
        public abstract void Play(int scene);
        
    }
}
