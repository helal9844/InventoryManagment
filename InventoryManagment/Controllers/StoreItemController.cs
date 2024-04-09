using DAL;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagment.Controllers
{
    public class StoreItemController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public StoreItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
