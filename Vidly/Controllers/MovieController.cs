﻿using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random(int id)
        {
            var movie = new Movie() { Name = "Shrek" };
            return View(movie);
        }
    }
}