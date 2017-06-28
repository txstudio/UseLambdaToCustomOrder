using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataModel;

namespace WebApp.Controllers
{

    public class ProductViewModel
    {
        public IEnumerable<Product> Product { get; set; }
        public IEnumerable<Product> ProductOrderByBrandName { get; set; }
        public IEnumerable<ProductInCustomOrder> ProductInCustomOrder { get; set; }
    }

    public class ProductController : Controller
    {
        private readonly ProductManager _manager;

        public ProductController()
        {
            this._manager = new ProductManager();
        }

        public IActionResult Index()
        {
            ProductViewModel _viewModel;

            _viewModel = new ProductViewModel();
            _viewModel.Product = this._manager.GetProducts();

            var _items = _viewModel.Product
                                    .Select(x => new ProductInCustomOrder() {
                                        Name = x.Name
                                        , Brand = x.Brand
                                    });

            var _orderByBrand = _viewModel.Product.ToArray();


            _items = _items.OrderBy(x => x.Sort).ToArray();

            _viewModel.ProductInCustomOrder = _items;
            _viewModel.ProductOrderByBrandName = _orderByBrand.OrderBy(x=>x.Brand).ToArray();

            return View(_viewModel);
        }
    }
}