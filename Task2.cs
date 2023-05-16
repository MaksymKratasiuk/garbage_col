using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garbage_col
{
    public class Play : IDisposable
    {
        public StringBuilder PlayName { get; set; }
        public StringBuilder TheatreName{get;set;}
        public StringBuilder Genre{get;set;}
        public StringBuilder Duration{get;set;}
        public List<string> Actors { get; set; }

        public Play(string playName, string theatreName, string genre, string duration, List <string>actors)
        {
            PlayName = new StringBuilder(playName);
            TheatreName = new StringBuilder(theatreName);
            Genre = new StringBuilder(genre);
            Duration = new StringBuilder(duration);
            Actors = actors;
        }

       
        public void ShowDetails()
        {
            Console.WriteLine("Play Name: " + PlayName);
            Console.WriteLine("Theatre Name: " + TheatreName);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("Duration: " + Duration);
            Console.WriteLine("Actors: " + string.Join(", ", Actors));
        }

        public void Dispose()
        {
            PlayName = default;
            TheatreName = default;
            Genre = default;
            Actors = default;
        }
    }

    internal class Task2
    {
        public static void task2()
        {
            List<string> actors = new List<string> { "Actor1", "Actor2", "Actor3" };

            using (Play play = new Play("Hamlet", "Royal Theatre", "Tragedy", "3:10", actors))
            {
                play.ShowDetails();
                // Інші операції з об'єктом Play
            }
        }
    }
}
