using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class MovieController : Controller
    {
        public static List<MovieModel> movieList = new List<MovieModel>
        {
            new MovieModel
            {
                Id = 1,
                Name ="Interstelar",
                Genre ="Sci-Fi",
                Rating = 8.7,
                Length = 124 
            },
            new MovieModel
            {
                Id = 2,
                Name ="The Upside",
                Genre ="Drama/Comedy",
                Rating = 6.7,
                Length = 110
            },
            new MovieModel
            {
                Id = 3,
                Name ="Guardians of The Galaxy",
                Genre ="Sci-Fi/Comedy",
                Rating = 7.2,
                Length = 124
            },
            new MovieModel
            {
                Id = 4,
                Name ="Up",
                Genre ="Animation",
                Rating = 6.2,
                Length = 115
            }


        };
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Movies()
        {
            return View(movieList);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(MovieModel model)
        {
            movieList.Add(model);
            return View("Movies", movieList);
        }

        public IActionResult Remove()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            var movie = movieList.FirstOrDefault(x => x.Id == id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult UpdateMovie(MovieModel movie)
        {
            var movieIndex = movieList.FindIndex(m => m.Id == movie.Id);
            movieList[movieIndex] = movie;
            return View("Movies",movieList);
        }


        public IActionResult MovieDetails(MovieModel Model)
        {
            var movie = movieList.FirstOrDefault(m => m.Id == Model.Id);
            return View(movie);
        }
    }
}