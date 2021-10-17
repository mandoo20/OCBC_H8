using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Models
{
    public class MovieItem
    {
        //private Models.MovieContext context;
        public int id { get; set; }
        public string nama { get; set; }
        public string genre { get; set; }
        public string duration { get; set; }

        public DateTime releaseDate { get; set; }
    }
}