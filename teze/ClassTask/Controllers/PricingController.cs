using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClassTask.DAL;
using ClassTask.ViewModels;

namespace ClassTask.Controllers
{
    public class PricingController : Controller
    {

        private readonly AppDbContext _appDbContext;
        

        public PricingController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var pricings=_appDbContext.Pricings.Include(p=>p.PricingServices).ToList();
            var services=_appDbContext.Services.ToList();
            var  pricingVM=new PricingVM();
            pricingVM.Pricings = pricings;
            pricingVM.Services = services;
            return View(pricingVM);
        }
    }
}
