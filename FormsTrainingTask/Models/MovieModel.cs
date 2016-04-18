using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormsTrainingTask.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Distributor { get; set; }
        [DisplayName("Release Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }

    public class Movies
    {
        public List<MovieModel> movieList = new List<MovieModel>();
        public Movies()
        {
            movieList.Add(new MovieModel { Id = 1, Title = "Deadpool", Distributor = "Fox", Date = Convert.ToDateTime("10/02/16") });
            movieList.Add(new MovieModel { Id = 2, Title = "Batman v Superman: Dawn of Justice", Distributor = "WB", Date = Convert.ToDateTime("25/03/16") });
            movieList.Add(new MovieModel { Id = 3, Title = "The Revenant", Distributor = "Fox", Date = Convert.ToDateTime("15/01/16") });
            movieList.Add(new MovieModel { Id = 4, Title = "Zootopia", Distributor = "Diseny", Date = Convert.ToDateTime("25/03/15") });
            movieList.Add(new MovieModel { Id = 5, Title = "Alvin and the Chipmunks The Road Chip", Distributor = "Fox", Date = Convert.ToDateTime("12/02/16") });
            movieList.Add(new MovieModel { Id = 6, Title = "Kung Fu Panda 3", Distributor = "Fox", Date = Convert.ToDateTime("11/03/16") });
            movieList.Add(new MovieModel { Id = 7, Title = "London Has Fallen", Distributor = "Lions Gate", Date = Convert.ToDateTime("04/03/16") });
            movieList.Add(new MovieModel { Id = 8, Title = "Goosebumps", Distributor = "Sony", Date = Convert.ToDateTime("05/02/16") });
            movieList.Add(new MovieModel { Id = 9, Title = "Dad's Army", Distributor = "UPI", Date = Convert.ToDateTime("05/02/16") });
            movieList.Add(new MovieModel { Id = 10, Title = "The Danish Girl", Distributor = "UPI", Date = Convert.ToDateTime("01/01/16") });
        }

        // Action to create movie
        public void CreateMovie(MovieModel movieModel)
        {
            movieList.Add(movieModel);
        }

        // action to update movie
        public void UpdateMovie(MovieModel movieModel)
        {
            foreach (MovieModel movie in movieList)
            {
                if (movie.Id == movieModel.Id)
                {
                    movieList.Remove(movie);
                    movieList.Add(movieModel);
                    break;
                }
            }
        }

        // action to get movie details
        public MovieModel GetMovie(int id)
        {
            MovieModel movieMod = null;
            foreach (MovieModel m in movieList)
                if (m.Id == id)
                    movieMod = m;
            return movieMod;
        }

        // action to delete movie

        public void DeleteMovie(MovieModel movieModel)
        {
            foreach (MovieModel movie in movieList)
            {
                if (movie.Id == movieModel.Id)
                {
                    movieList.Remove(movie);
                    break;
                }
            }
        }
    }
}