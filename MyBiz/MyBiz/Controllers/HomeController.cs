using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyBiz.DAL;
using MyBiz.Models;
using MyBiz.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyBiz.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel homeVW = new HomeViewModel
            {
                Sliders = _context.Sliders.ToList(),
                Services = _context.Services.ToList(),
                Portfolios = _context.Portfolios.ToList(),
                Teams = _context.Teams.ToList(),
                PortfolioCategories = _context.PortfolioCategories.ToList(),
                productImages = _context.ProductImages.ToList(),
            };
            
            return View(homeVW);
        }

        
    }
}
