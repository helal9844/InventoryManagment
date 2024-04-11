using AutoMapper;
using BL;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace InventoryManagment.Controllers
{
    public class StoreItemController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public StoreItemController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            try
            {
                var storeItem = _unitOfWork.StoreItemRepo.GetAllInclue();
                if (storeItem == null) return NotFound();
                var storeItemDto = _mapper.Map<List<StoreItemReadDTO>>(storeItem);

                return View(storeItemDto);
            }
            catch
            {
                return RedirectToAction("Index", "Error");
            }

        }
        public IActionResult Update(int storeId, int itemId)
        {
            try
            {
                var storeItems = _unitOfWork.StoreItemRepo.GetAllInclue();

                var storeDto = _mapper.Map<List<StoreReadDTO>>(storeItems.Select(si => si.Store).Distinct());
                var itemDto = _mapper.Map<List<ItemReadDTO>>(storeItems.Where(e=>e.ItemId==-1).Select(si => si.Item).Distinct());


                var viewModel = new StoreItemWriteDTO
                {
                    Stores = storeDto,
                    Items = itemDto
                };

                if (storeId != -1 && itemId != -1)
                {

                    var storeItem = _unitOfWork.StoreItemRepo.Find(si => si.StoreId == storeId && si.ItemId == itemId);
                    if (storeItem == null)
                        return NotFound();

                    viewModel.StoreId = storeId;
                    viewModel.ItemId = storeItem.ItemId;
                    viewModel.Quantity = storeItem.Quantity;
                    viewModel.Price = storeItem.Price;
                }
                return View(viewModel);
            }
            catch
            {
                return RedirectToAction("Index", "Error");
            }

        }

        [HttpPost]
        public IActionResult Update(StoreItemWriteDTO viewModel)
        {
            try
            {
                if (viewModel == null)
                    return BadRequest();

                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                    viewModel.Stores = _mapper.Map<List<StoreReadDTO>>(_unitOfWork.StoreRepo.GetAll());
                    viewModel.Items = _mapper.Map<List<ItemReadDTO>>(_unitOfWork.ItemRepo.GetAll());
                    return View(viewModel);
                }

                var storeItem = _unitOfWork.StoreItemRepo.Find(si => si.StoreId == viewModel.StoreId && si.ItemId == viewModel.ItemId);
                if (storeItem == null)
                    return NotFound();

                storeItem.Quantity += viewModel.Quantity;
                storeItem.Price = viewModel.Price;
                _unitOfWork.StoreItemRepo.Update(storeItem);
                _unitOfWork.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Index", "Error");
            }

        }

        public IActionResult Add()
        {
            try
            {
                var storeItems = _unitOfWork.StoreItemRepo.GetAllInclue();

                var storeDto = _mapper.Map<List<StoreReadDTO>>(storeItems.Select(si => si.Store).Distinct());

                var viewModel = new StoreItemWriteDTO
                {
                    Stores = storeDto,
                    Items = null
                };


                return View(viewModel);
            }
            catch
            {
                return RedirectToAction("Index", "Error");
            }

        }
        [HttpPost]
        public IActionResult Add(StoreItemWriteDTO viewModel)
        {
            try
            {
                if (viewModel == null)
                    return BadRequest();
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                    viewModel.Stores = _mapper.Map<List<StoreReadDTO>>(_unitOfWork.StoreRepo.GetAll());
                    viewModel.Items = _mapper.Map<List<ItemReadDTO>>(_unitOfWork.ItemRepo.GetAll());
                    return View(nameof(Update), viewModel);
                }

                var storeItem = _unitOfWork.StoreItemRepo.Find(si => si.StoreId == viewModel.StoreId && si.ItemId == viewModel.ItemId);
                if (storeItem != null)
                {
                    ModelState.AddModelError("", "A store item with the same StoreId and ItemId already exists.");
                    viewModel.Stores = _mapper.Map<List<StoreReadDTO>>(_unitOfWork.StoreRepo.GetAll());
                    viewModel.Items = _mapper.Map<List<ItemReadDTO>>(_unitOfWork.ItemRepo.GetAll());
                    return View(nameof(Add), viewModel);
                }

                var map = _mapper.Map<StoreItem>(viewModel);

                _unitOfWork.StoreItemRepo.Add(map);
                _unitOfWork.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Index", "Error");
            }
            
        }

        [HttpGet]
        public IActionResult GetQuantity(int storeId, int itemId)
        {
            try
            {
                var storeItem = _unitOfWork.StoreItemRepo.Find(si => si.ItemId == itemId && si.StoreId == storeId);
                if (storeItem == null) return NotFound();

                return Json(storeItem);
            }
            catch
            {
                return RedirectToAction("Index", "Error");
            }

        }
        [HttpGet]
        public IActionResult GetItemForStore(int storeId)
        {
            try
            {
                IEnumerable<Item> availableItems;
                var existingStoreItems = _unitOfWork.StoreItemRepo.GetAll().Where(si => si.StoreId == storeId).Select(si => si.ItemId).ToList();
                int action = Request.Query.ContainsKey("action") ? int.Parse(Request.Query["action"]) : 1;
                if (action == 1)
                {
                    availableItems = _unitOfWork.ItemRepo.GetAll().Where(item => !existingStoreItems.Contains(item.Id));

                }
                else
                {
                    availableItems = _unitOfWork.ItemRepo.GetAll().Where(item => existingStoreItems.Contains(item.Id));

                }

                if (availableItems == null || !availableItems.Any()) return NotFound();

                var jsonData = JsonConvert.SerializeObject(availableItems.Select(item => new { item.Id, item.ItemName }));
                return Content(jsonData, "application/json");
            }
            catch
            {
                return RedirectToAction("Index", "Error");
            }

        }

        public IActionResult Delete(int storeId,int itemId)
        {
            try
            {
                var storeItem = _unitOfWork.StoreItemRepo.Find(e => e.ItemId == itemId && e.StoreId == storeId);
                if (storeItem == null)
                {
                    return NotFound();
                }

                var storeItemDTO = _mapper.Map<StoreItemWriteDTO>(storeItem);
                return PartialView(storeItemDTO);
            }
            catch
            {
                return RedirectToAction("Index", "Error");
            }


        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteStoreItemConfirmed(int storeId, int itemId)
        {
            try
            {
                var storeItem = _unitOfWork.StoreItemRepo.Find(e => e.ItemId == itemId && e.StoreId == storeId);
                if (storeItem == null)
                {
                    return NotFound();
                }

                _unitOfWork.StoreItemRepo.Delete(storeItem);
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
