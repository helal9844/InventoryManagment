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
            var stores = _unitOfWork.StoreRepo.GetAll();
            if (stores == null) return NotFound();
            var storeDto = _mapper.Map<List<StoreReadDTO>>(stores);
            return View(storeDto);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StoreWriteDTO dto)
        {
            if (dto == null) return BadRequest();

            if (!ModelState.IsValid)
                return View(dto);

            var store = _mapper.Map<Store>(dto);
            _unitOfWork.StoreRepo.Add(store);
            _unitOfWork.SaveChanges();
            
            
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int id)
        {
            var store = _unitOfWork.StoreRepo.GetById(id);
            if (store == null)
                return NotFound();

            var storeDTO = _mapper.Map<StoreWriteDTO>(store);
            return View(storeDTO);
        }
        [HttpPost]
        public IActionResult Update(int id, StoreWriteDTO dto)
        {
            if (id != dto.Id|| dto == null) return BadRequest();

            if (!ModelState.IsValid) return View(dto);

            var store = _mapper.Map<Store>(dto);
            _unitOfWork.StoreRepo.Update(store);
            _unitOfWork.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            var store = _unitOfWork.StoreRepo.GetById(id);
            if (store == null)
            {
                return NotFound();
            }

            var storeDTO = _mapper.Map<StoreWriteDTO>(store);
            return PartialView(storeDTO);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteStoreConfirmed(int id) 
        {
            var store = _unitOfWork.StoreRepo.GetById(id);
            if (store == null) return NotFound();

            _unitOfWork.StoreRepo.Delete(store);
            _unitOfWork.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
