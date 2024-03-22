using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Mission11_Section03_Morey.Models;
using Mission11_Section03_Morey.Models.ViewModels;

namespace TheWaterProject.Controllers
{
    public class HomeController : Controller
    {
        private IBooks _repo;


        public HomeController(IBooks context)
        {
            _repo = context;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var bookList = new BooksViewModel
            {
                Books = _repo.Books //Pagingation = Showing a limited number of rows per page
                .OrderBy(x => x.BookId)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };
            return View(bookList);
        }
    }
}