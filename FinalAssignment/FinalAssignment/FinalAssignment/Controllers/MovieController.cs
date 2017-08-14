using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalAssignment.Models;
using FinalAssignment.Models.ViewModels;

namespace FinalAssignment.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }

        // GET: Movie
        public ActionResult MovieAttendView()
        {
            List<Theater> theatreList = new List<Theater>();
            List<Movie> movieList = new List<Movie>();
            List<Customer> customerList = new List<Customer>();
            List<Attending> attendingList = new List<Attending>();



            //INSERT DATA VIA DAO METHOD HERE 

           

            

            var attendingViewModel = from t in theatreList
                                   join at in attendingList on t.Id equals at.TheatreId 
                                   join m in movieList on at.MovieId equals m.Id 
                                   join c in customerList on at.CustId equals c.Id 
                                   


                                   select new AttendingViewModel { theatre = t, attending = at, customer = c, movie = m};
            return View(attendingViewModel);


            
        }
    }
}