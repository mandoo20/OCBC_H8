using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Models
{
    public class MovieContext
    {
        public string ConnectionString { get; set; }

        public MovieContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<MovieItem> GetAllMovie()
        {
            List<MovieItem> list = new List<MovieItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM movie", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("Id"),
                            nama = reader.GetString("Nama"),
                            genre = reader.GetString("Genre"),
                            duration = reader.GetString("Duration"),
                            releaseDate = reader.GetDateTime("ReleaseDate")
                        });
                    }
                }
            }
            return list;
        }

        public List<MovieItem> GetMovie(string id)
        {
            List<MovieItem> list = new List<MovieItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM movie where Id =@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("Id"),
                            nama = reader.GetString("Nama"),
                            genre = reader.GetString("Genre"),
                            duration = reader.GetString("Duration"),
                            releaseDate = reader.GetDateTime("ReleaseDate")
                        });
                    }
                }
            }
            return list;
        }
    }
}