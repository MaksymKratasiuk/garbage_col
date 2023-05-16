using System.Text;

namespace garbage_col
{
    public class Film:IDisposable
    {
        public StringBuilder Film_Name { get; set; }
        
        public StringBuilder Studio_Name { get; set; }

        public StringBuilder Genre { get; set; }

        public StringBuilder Durability { get; set; }

        public StringBuilder Year { get; set; }



        public Film()
        {
            Film_Name = default;
            Studio_Name = default;
            Genre = default;
            Durability = default;
            Year = default;
        }
        public Film (string film_name, string studio_name, string genre, string durability,string year)
        {
            Film_Name = new StringBuilder(film_name);
            Studio_Name = new StringBuilder(studio_name);
            Genre = new StringBuilder(genre);
            Durability = new StringBuilder(durability);
            Year = new StringBuilder(year);
        }

        public void Show()
        {
            Console.WriteLine("Film Name: " + Film_Name);
            Console.WriteLine("Studio Name: " + Studio_Name);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("Durability: " + Durability);
            Console.WriteLine("Year: " + Year);
        }

        public void Dispose ()
        {
            Film_Name = default;
            Studio_Name = default;
            Genre = default;
            Durability = default;
            Year = default;

        }
    }
    internal class Task1
    {
        public static void task1()
        {
            using (Film film = new Film("The Shawshank Redemption", "Castle Rock Entertainment", "Drama", "2h 22min", "1994"))
            {
                film.Show();
                // Інші операції з об'єктом Film
                film.Dispose();
                film.Show();
            }
            
        }

    }
}
