using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingStore.Domain.Abstract;
using OnlineShoppingStore.Domain.Entities;
using OnlineShoppingStore.WebUI.Models;
using OnlineShoppingStore.WebUI.HtmlHelpers;

namespace OnlineShoppingStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;
        public int PageSize = 4;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        // GET: Product
        public ViewResult List(string category, int page =1)
        {
            ProductListViewModel model = new ProductListViewModel
            {
                Products = repository.Products
                .Where(p=> category==null || p.Category==category)
                    .OrderBy(p => p.ProductId)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Count()
                },
                CurrentCategory=category
            };

            return View(model);
        }
    }
}