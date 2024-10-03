using Food.BusinessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
	public class CategoriesController : Controller
	{
		private readonly ICategoryService _categoryService;

		public CategoriesController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		public IActionResult CategoryList()
		{
			var values = _categoryService.TGetAll();
			return View(values);
		}

		[HttpGet]
        public IActionResult CreateCategory()
        {          
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
			_categoryService.TInsert(category);
            return RedirectToAction("CategoryList");
        }

        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryService.TUpdate(category);
            return RedirectToAction("CategoryList");
        }
    }
}
