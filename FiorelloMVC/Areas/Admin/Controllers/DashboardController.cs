﻿
using FiorelloMVC.Contexts;
using FiorelloMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FiorelloMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {

        private readonly AppDbContext _context;

        public DashboardController()
        {
            _context = new AppDbContext();
        }
        public IActionResult Index()
        {
           
            return View();
        }
    }
}
