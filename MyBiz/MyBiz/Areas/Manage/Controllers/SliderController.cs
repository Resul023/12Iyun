using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(AppDbContext context,IWebHostEnvironment env)
        {
            this._context = context;
            this._env = env;
        }
        public IActionResult Index()
        {
            var sliders = _context.Sliders.ToList();
            return View(sliders);
        }
        public IActionResult Create() 
        {
            return View();
        
        }
        [HttpPost]
        public IActionResult Create(Sliders slider) 
        {
            if (slider.ImageFile != null)
            {
                if (slider.ImageFile.ContentType != "image/jpeg"&& slider.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "File format must be only jpeg or png");
                }
                if (slider.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "Image size must be less from 2mb ");
                }

                
            }
            else
            {
                ModelState.AddModelError("ImageFile","Image is required");
            }
            if (!ModelState.IsValid)
            {
                return View();
            }

            slider.SliderImage = FileManage.Save(_env.WebRootPath, "upload/slider",slider.ImageFile);
            _context.Sliders.Add(slider);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Edit(int Id) 
        {
            Sliders isExists = _context.Sliders.FirstOrDefault(x => x.Id == Id);
            if (isExists == null)
            {
                return NotFound();
            }
            return View(isExists);
        
        }
        [HttpPost]
        public IActionResult Edit(Sliders slider) 
        {
            Sliders isExists = _context.Sliders.FirstOrDefault(x => x.Id == slider.Id);
            if (isExists == null)
            {
                return NotFound();
            }
            if (slider.ImageFile != null)
            {
                if (slider.ImageFile.ContentType != "image/jpeg" && slider.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "File format must be only jpeg or png");
                }
                if (slider.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "Image size must be less from 2mb ");
                }

                if (!ModelState.IsValid)
                {
                    return View();
                }

                string newFileName = FileManage.Save(_env.WebRootPath, "upload/slider", slider.ImageFile);
                FileManage.Delete(_env.WebRootPath, "upload/slider", isExists.SliderImage);
                isExists.SliderImage = newFileName;
            }
            isExists.Desc = slider.Desc;
            isExists.BtnUrl = slider.BtnUrl;
            isExists.BtnText = slider.BtnText;
            isExists.Order = slider.Order;
            isExists.Title = slider.Title;
            _context.SaveChanges();
            return RedirectToAction("index");


        }

        public IActionResult Delete(int Id)
        {
            Sliders isExists = _context.Sliders.FirstOrDefault(x => x.Id == Id);
            if (isExists == null )
            {
                return NotFound();
            }
            FileManage.Delete(_env.WebRootPath, "upload/slider", isExists.SliderImage);
            _context.Sliders.Remove(isExists);
            _context.SaveChanges();
            return Ok();
        }
        
    }
}
