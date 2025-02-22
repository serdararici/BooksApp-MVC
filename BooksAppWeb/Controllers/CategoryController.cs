using BooksAppWeb.Data;
using BooksAppWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooksAppWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategorylist = _db.Categories.ToList();
            return View(objCategorylist);
        }

        public IActionResult Create()
        {
            return View();
        }

    }
}
