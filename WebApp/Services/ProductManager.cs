using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp
{
    public sealed class ProductManager
    {
        private List<ProductInCustomOrder> _products;

        public ProductManager()
        {
            this._products = new List<ProductInCustomOrder>();
            this._products.Add(new ProductInCustomOrder() { Name = "iPhone 7", Brand = "Apple" });
            this._products.Add(new ProductInCustomOrder() { Name = "iPhone 6S", Brand = "Apple" });
            this._products.Add(new ProductInCustomOrder() { Name = "Microsoft Lumia 950", Brand = "Microsoft" });
            this._products.Add(new ProductInCustomOrder() { Name = "Microsoft Lumia 950 XL", Brand = "Microsoft" });
            this._products.Add(new ProductInCustomOrder() { Name = "NOKIA 6S", Brand = "NOKIA" });
            this._products.Add(new ProductInCustomOrder() { Name = "HTC 10", Brand = "HTC" });
        }

        public IEnumerable<ProductInCustomOrder> GetProducts()
        {
            return this._products.ToArray();
        }
    }
}
