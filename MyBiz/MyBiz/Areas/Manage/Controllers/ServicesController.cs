using Microsoft.AspNetCore.Mvc;
using MyBiz.DAL;
using MyBiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBiz.Areas.Manage.Controllers
{
    [Area("manage")]
    public class ServicesController : Controller
    {
        private readonly AppDbContext _context;

        public ServicesController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var service = _context.Services.ToList();
            return View(service);
        }
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Services service) 
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            _context.Services.Add(service);
            _context.SaveChanges();
            return RedirectToAction("index");
        
        }
        public IActionResult Edit(int Id) 
        {
            var service = _context.Services.FirstOrDefault(x => x.Id == Id);
            if (service == null)
            {
                return Content("This Service is not exits");
            }
            return View(service);
        
        }
        [HttpPost]
        public IActionResult Edit(Services service) 
        {
            var isExists = _context.Services.FirstOrDefault(x => x.Id == service.Id);
            if (isExists == null)
            {
                return Content("This Service is not exits");
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            isExists.Desc = service.Desc;
            isExists.Icon = service.Icon;
            isExists.Title = service.Title;
            _context.SaveChanges();
            return RedirectToAction("index");
        
        }

        public IActionResult Delete(int Id) 
        {
            var service = _context.Services.FirstOrDefault(x => x.Id == Id);
            if (service == null)
            {
                return NotFound();
            }
            _context.Services.Remove(service);
            _context.SaveChanges();
            return Ok();
        }
    }
}
