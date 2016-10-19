﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SingleMovie()
        {
            return View(new Movie()
            {
                Name = "Star Wars",
                Genre = "Horror"
            });
            
        }
       
        
    }
}
