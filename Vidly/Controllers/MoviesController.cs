    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name="Avengers"};
        //    return View(movie);
        //    //return Content("Hello world");
        //    //return HttpNotFound();
        //    //return new EmptyResult();
        //    //return RedirectToAction("Index", "Home", new { page = 1, sortby = "name" });
        //}

        //public ActionResult Edit(int id)
        //{
        //    return Content("Id is" + id);
        //}
        //public ActionResult Index(int? pageIndex,string orderBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (String.IsNullOrWhiteSpace(orderBy))
        //        orderBy = "name";

        //    return Content(String.Format("Page Index {0} and order by {1}",pageIndex,orderBy));
        //}

        ////custom route example
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year+"/"+month);
        //}

        ////custom routing using attribue routing
        //[Route("movies/releasedyear/{year}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ByReleaseYear(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Avengers" };
            var customers = new List<Customer>() {
                new Customer(){Name="Customer 1"},
                new Customer(){Name="Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }


    }
}