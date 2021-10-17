using System;

namespace MovieAPI.Models
{
    public class MovieData
    {

        public int id { get; set; }
        public string nama { get; set; }
        public string genre { get; set; }
        public string duration { get; set; }

        public DateTime releaseDate { get; set; }
    }
}