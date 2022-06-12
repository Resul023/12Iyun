using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBiz.DAL;
using MyBiz.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBiz.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;

        public PortfolioController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index(int Id)
        {
            PortfolioViewModel portVW = new PortfolioViewModel {

                Portfolios = _context.Portfolios.Include(x=>x.productImage).ToList(),
                
            };
            var isExists = portVW.Portfolios.FirstOrDefault(x => x.Id == Id);
           
            if (isExists == null)
            {
                return NotFound();
            }
            return View(isExists);
        }
    }
}
