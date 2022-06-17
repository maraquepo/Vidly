using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
<<<<<<< HEAD
using Vidly.ViewModels;
=======
>>>>>>> 9029b8f69c47c20ec890eaa78ea63837408d5c2d

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
<<<<<<< HEAD
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek"},
                new Movie { Id = 2, Name = "Wall-e"}
            };
        }
=======
>>>>>>> 9029b8f69c47c20ec890eaa78ea63837408d5c2d
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
<<<<<<< HEAD
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);

        }
=======
            return View(movie);

        }
        
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
>>>>>>> 9029b8f69c47c20ec890eaa78ea63837408d5c2d
    }
}