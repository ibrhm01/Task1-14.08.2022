using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_13._08._2022.Models
{
    class Song:Program
    {
        private string _name;
        private string _genre;
        private Singer _singer;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length <= 100) _name = value;
            }
        }
        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                if (value == "Pop" || value == "Rock" || value == "Jazz" || value == "Techno") _genre = value;
            }
        }
        public Singer Singer { get; set; }
        public float Rating;
        float sum = 0, AverageRating, cnt = 1;
        public void AddRating()
        {
            Rating = Convert.ToSingle(Console.ReadLine());
            sum = sum + Rating;
            AverageRating = sum / cnt;
            cnt++;
            
        }
        public float GetAverageRating()
        {
            return AverageRating;
        }
    }
}
