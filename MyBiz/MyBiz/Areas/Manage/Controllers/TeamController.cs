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
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public TeamController(AppDbContext context,IWebHostEnvironment env)
        {
            this._context = context;
            this._env = env;
        }
        public IActionResult Index()
        {
            var team = _context.Teams.Include(x=>x.Position).ToList();
            return View(team);
        }
        public IActionResult Create() 
        {
            ViewBag.Position = _context.Positions.ToList();
            return View();
        
        }
        [HttpPost]
        public IActionResult Create(Team team) 
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Position = _context.Positions.ToList();
                return View();
            }
            if (!_context.Positions.Any(x=>x.Id == team.PositionId))
            {
                ModelState.AddModelError("PositionId", "This position is not exists");
                ViewBag.Position = _context.Positions.ToList();
                return View();
            }

            if (team.ImageFile!= null)
            {
                if (team.ImageFile.ContentType!= "image/jpeg" && team.ImageFile.ContentType!="image/png")
                {
                    ModelState.AddModelError("ImageFiles", "File format must be image/png or image/jpeg");
                }
                if (team.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFiles", "File size must be less than 2MB");
                }
                if (!ModelState.IsValid)
                {
                    ViewBag.Position = _context.Positions.ToList();
                    return View();
                }
                team.WorkerImage = FileManage.Save(_env.WebRootPath, "upload/team",team.ImageFile);
                
            }
            _context.Teams.Add(team);
            _context.SaveChanges();
            return RedirectToAction("index");
        
        }
        public IActionResult Edit(int Id) 
        {
            Team isExists = _context.Teams.FirstOrDefault(x => x.Id == Id);
            ViewBag.Position = _context.Positions.ToList();
            if (isExists == null)
            {

                return NotFound();
            }
            return View(isExists);
        
        }
        [HttpPost]
        public IActionResult Edit(Team team) 
        {
            Team isExists = _context.Teams.FirstOrDefault(x => x.Id == team.Id);
            ViewBag.Position = _context.Positions.ToList();
            if (isExists == null)
            {
                return NotFound();
            }
            if (team.ImageFile != null)
            {

                if (team.ImageFile.ContentType != "image/jpeg" && team.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFiles", "File format must be image/png or image/jpeg");
                }
                if (team.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFiles", "File size must be less than 2MB");
                }
                if (!ModelState.IsValid)
                {
                    ViewBag.Position = _context.Positions.ToList();
                    return View();
                }
                string newFileName = FileManage.Save(_env.WebRootPath, "upload/team", team.ImageFile);
                FileManage.Delete(_env.WebRootPath, "upload/team", isExists.WorkerImage);
                isExists.WorkerImage = newFileName;
            }
            isExists.WorkerName = team.WorkerName;
            isExists.TwitUrl = team.TwitUrl;
            isExists.PositionId = isExists.PositionId;
            isExists.Desc = team.Desc;
            isExists.FaceUrl = team.FaceUrl;
            isExists.linkUrl = team.linkUrl;
            isExists.InstaUrl = team.InstaUrl;
            _context.SaveChanges();
            return RedirectToAction("index");

        }

        public IActionResult Delete(int Id) 
        {
            Team isExists = _context.Teams.FirstOrDefault(x => x.Id == Id);
            if (isExists == null)
            {
                ViewBag.Position = _context.Positions.ToList();
                return View();
            }

            FileManage.Delete(_env.WebRootPath,"upload/team",isExists.WorkerImage);
            _context.Teams.Remove(isExists);
            _context.SaveChanges();
            return Ok();
        
        }
    }
}
