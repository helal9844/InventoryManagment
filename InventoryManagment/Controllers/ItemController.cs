using AutoMapper;
using BL;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagment.Controllers
{
    public class ItemController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ItemController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            try
            {
                var items = _unitOfWork.ItemRepo.GetAll();
                if (items == null) return NotFound();
                var itemDto = _mapper.Map<List<ItemReadDTO>>(items);
                return View(itemDto);
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
        public IActionResult Create(ItemWriteDTO dto)
        {
            try
            {
                if (dto == null) return BadRequest();

                if (!ModelState.IsValid)
                    return View(dto);

                var item = _mapper.Map<Item>(dto);
                _unitOfWork.ItemRepo.Add(item);
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
                var item = _unitOfWork.ItemRepo.Find(e => e.Id == id);
                if (item == null)
                    return NotFound();

                var itemDTO = _mapper.Map<ItemWriteDTO>(item);
                return View(itemDTO);
            }
            catch
            {
                return RedirectToAction("Index", "Error");
            }
            
        }
        [HttpPost]
        public IActionResult Update(int id, ItemWriteDTO dto)
        {
            try
            {
                if (id != dto.Id || dto == null) return BadRequest();

                if (!ModelState.IsValid) return View(dto);

                var item = _mapper.Map<Item>(dto);
                _unitOfWork.ItemRepo.Update(item);
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
                var item = _unitOfWork.ItemRepo.Find(e => e.Id == id);
                if (item == null)
                {
                    return NotFound();
                }

                var itemDTO = _mapper.Map<ItemWriteDTO>(item);
                return PartialView(itemDTO);
            }
            catch
            {
                return RedirectToAction("Index", "Error");
            }

        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteItemConfirmed(int id)
        {
            try
            {
                var item = _unitOfWork.ItemRepo.Find(e => e.Id == id);
                if (item == null) return NotFound();

                _unitOfWork.ItemRepo.Delete(item);
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
