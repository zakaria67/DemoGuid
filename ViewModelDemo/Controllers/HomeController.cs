using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelDemo.Models;
using ViewModelDemo.Models.ViewModel;
using ViewModelDemo.Models.ViewModel.ProductSupplierViewModel;

namespace ViewModelDemo.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Laptop", Price = 1000 });
            products.Add(new Product { Id = 2, Name = "Tv", Price = 800 });
            products.Add(new Product { Id = 3, Name = "Smartphone", Price = 500 });

            List<Supplier> suppliers = new List<Supplier>();
            suppliers.Add(new Supplier { Id = 1, Name = "Dell"});
            suppliers.Add(new Supplier { Id = 2, Name = "Samsung"});
            suppliers.Add(new Supplier { Id = 3, Name = "Apple"});

            var viewModel = new ProductSupplierViewModel
            {
                Products = products,
                suppliers = suppliers
            };
            
            return View(viewModel);
        }

       

    }
}
