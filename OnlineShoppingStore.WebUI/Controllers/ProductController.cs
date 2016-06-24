using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingStore.Domain.Abstract;
using OnlineShoppingStore.Domain.Entities;

namespace OnlineShoppingStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        // GET: Product
        public ViewResult List()
        {
            return View(repository.Products);
        }
    }
}