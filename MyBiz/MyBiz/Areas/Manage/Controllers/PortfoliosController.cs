using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBiz.DAL;
using MyBiz.Helper;
using MyBiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBiz.Areas.Manage.Controllers
{
    [Area("manage")]
    public class PortfoliosController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public PortfoliosController(AppDbContext context, IWebHostEnvironment env)
        {
            this._context = context;
            this._env = env;
        }
        public IActionResult Index()
        {
            var portfolio = _context.Portfolios.ToList();
            return View(portfolio);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Portfolio portfolio)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (portfolio.HoverImage != null)
            {
                if (portfolio.HoverImage.Length > 2097152)
                {
                    ModelState.AddModelError("HoverImage", "File size must be less than 2MB");
                }
                if (portfolio.HoverImage.ContentType != "image/png" && portfolio.HoverImage.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("ImageFiles", "File format must be image/png or image/jpeg");
                }
                if (!ModelState.IsValid)
                {

                    return View();
                }
                ProductImage proImg = new ProductImage
                {
                    Name = FileManage.Save(_env.WebRootPath, "upload/portfolio", portfolio.HoverImage),
                    PosterStatus = false,
                };
                portfolio.productImage.Add(proImg);
            }

            if (portfolio.DetailImages != null)
            {
                foreach (var file in portfolio.DetailImages)
                {
                    if (file.Length > 2097152)
                    {
                        ModelState.AddModelError("ImageFiles", "File size must be less than 2MB");
                    }
                    if (file.ContentType != "image/png" && file.ContentType != "image/jpeg")
                    {
                        ModelState.AddModelError("ImageFiles", "File format must be image/png or image/jpeg");
                    }
                    if (!ModelState.IsValid)
                    {
                        
                        return View();
                    }
                }
                foreach (var file in portfolio.DetailImages)
                {
                    ProductImage proImg = new ProductImage
                    {
                        Name = FileManage.Save(_env.WebRootPath, "upload/portfolio", file),
                        PosterStatus = true
                    };
                    portfolio.productImage.Add(proImg);
                }
            }
            _context.Portfolios.Add(portfolio);
            _context.SaveChanges();
            return RedirectToAction("index");

        }

      
        
    }
}
