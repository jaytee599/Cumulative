﻿using System.Web.Mvc;

namespace CumulativeProject2.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.Title = "Home Page";

        return View();
    }
}