using System;
using Task1_13._08._2022.Models;

namespace Task1_13._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Singer FrankSinatra = new Singer { Name = "Frank", Surname = "Sinatra", Age = 87 };
            Song song = new Song
            {
                Name = "Fly Me To The Moon",
                Genre = "Rock",
                Singer = FrankSinatra,
            };

            int value;
            do
            {
                Console.Write("Enter the rating that you give to the song:");
                song.AddRating();
                Console.WriteLine($"Name:{song.Name}\nGenre:{song.Genre}\nSinger:{song.Singer.Name} {song.Singer.Surname} {song.Singer.Age}\nRating:{song.GetAverageRating()}\n");
                Console.WriteLine("If you want to exit, press 0");
                Console.WriteLine("If you want to continue, press 1");
                value = Convert.ToInt32(Console.ReadLine());
            } while (value != 0);
            
        }
    }
}
