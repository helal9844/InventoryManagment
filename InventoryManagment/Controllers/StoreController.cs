using AutoMapper;
using BL;
using BL;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagment.Controllers
{
    public class StoreController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StoreController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            try
            {
                var stores = _unitOfWork.StoreRepo.GetAll();
                if (stores == null) return NotFound();
                var storeDto = _mapper.Map<List<StoreReadDTO>>(stores);
                return View(storeDto);
            }
            catch
            {
                return RedirectToAction("Index", "Error");
            }
            
        }
        public IActionResult Create()
        {
            try
            {
                return View();

            }
            catch
            {
                return RedirectToAction("Index", "Error");
            }
        }
        [HttpPost]
        public IActionResult Create(StoreWriteDTO dto)
        {
            try
            {
                if (dto == null) return BadRequest();

                if (!ModelState.IsValid)
                    return View(dto);

                var store = _mapper.Map<Store>(dto);
                _unitOfWork.StoreRepo.Add(store);
                _unitOfWork.SaveChanges();


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Index", "Error");
            }
            
        }
        public IActionResult Update(int id)
        {
            try
            {
                var store = _unitOfWork.StoreRepo.Find(e => e.Id == id);
                if (store == null)
                    return NotFound();

                var storeDTO = _mapper.Map<StoreWriteDTO>(store);
                return View(storeDTO);
            }
            catch
            {
                return RedirectToAction("Index", "Error");
            }
            
        }
        [HttpPost]
        public IActionResult Update(int id, StoreWriteDTO dto)
        {
            try
            {
                if (id != dto.Id || dto == null) return BadRequest();

                if (!ModelState.IsValid) return View(dto);

                var store = _mapper.Map<Store>(dto);
                _unitOfWork.StoreRepo.Update(store);
                _unitOfWork.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Index", "Error");
            }
            
        }
        public IActionResult Delete(int id)
        {
            try
            {
                var store = _unitOfWork.StoreRepo.Find(e => e.Id == id);
                if (store == null)
                {
                    return NotFound();
                }

                var storeDTO = _mapper.Map<StoreWriteDTO>(store);
                return PartialView(storeDTO);
            }
            catch
            {
                return RedirectToAction("Index", "Error");
            }
            
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteStoreConfirmed(int id) 
        {
            try
            {
                var store = _unitOfWork.StoreRepo.Find(e => e.Id == id);
                if (store == null) return NotFound();

                _unitOfWork.StoreRepo.Delete(store);
                _unitOfWork.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Index", "Error");
            }
            
        }
    }
}
