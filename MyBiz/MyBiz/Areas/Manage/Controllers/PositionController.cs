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
    public class PositionController : Controller
    {
        private readonly AppDbContext _context;

        public PositionController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var postions = _context.Positions.ToList();
            return View(postions);
        }
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Position position)
        {
            bool isExists = _context.Positions.Any(x => x.Department == position.Department);
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (isExists == true)
            {
                return Content("This Departmen is already exists");
            }

            _context.Positions.Add(position);
            _context.SaveChanges();
            return RedirectToAction("index");

        }
        public IActionResult Edit(int Id) 
        {
            Position isExists = _context.Positions.FirstOrDefault(x => x.Id == Id);
            if (isExists == null)
            {
                return Content("This Position is not exits");
            }
            if (!ModelState.IsValid)
            {
                return View();
            }

            return View(isExists);
        }
        [HttpPost]
        public IActionResult Edit(Position position)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            Position isExists = _context.Positions.FirstOrDefault(x => x.Id == position.Id);

            if (isExists == null)
            {
                return Content("This Position is not exits");
            }

            isExists.Department = position.Department;
            _context.SaveChanges();
            return RedirectToAction("index");

        }
        public IActionResult Delete(int Id)
        {
            Position position = _context.Positions.FirstOrDefault(x => x.Id == Id);
            if (position == null)
            {
                return Content("This Position is not exits");
            }

            _context.Positions.Remove(position);
            _context.SaveChanges();
            return Ok();

        }


    }
}
