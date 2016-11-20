using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb16InterfaceRepository
{
    class ListProductRepository : IProductRepository
    {
        private List<Product> products;

        public ListProductRepository()
        {
            products = new List<Product> { new Product { Type = "Ris", Id = 1 }, new Product { Id = 2, Type = "Potatis"} };
        }
       
        public void Add()
        {
            int id = products.Count + 1;
            products.Add(UI.CreateProduct(id));
        }

        public void Delete(int id)
        {
            products.RemoveAt(id -1);
        }

        public Product Get(int id)
        {
            return products[id-1];
             
        }

        public Product[] GetAll()
        {
            return products.ToArray();
        }

        public void Update(Product updatedProduct)
        {
            var single = products.SingleOrDefault(product => product.Type.Equals(updatedProduct.Type));
            if (single != null)
                updatedProduct = single;

        }
    }
}
