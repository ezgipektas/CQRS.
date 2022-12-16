using CQRS.İEA.CQRS.Handlers.ProductHandlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.İEA.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        

        public ProductController(GetProductQueryHandler getProductQueryHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
        }

        //Depocuya göre veri listesi
        public IActionResult StoragerIndex()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }
        public IActionResult AccounterIndex()
        {
            var values=_getProductQueryHandler.Handle();    
            return View(values);
        }
    }
}
