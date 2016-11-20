using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Labb16InterfaceRepository
{
    class FileProductRepository : IProductRepository
    {
        private List<Product> products;
        
        public FileProductRepository()
        {
            var directory = Environment.CurrentDirectory;
            var productDatabase = String.Format("{0}{1}", directory, "\\database.json");
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            if (!File.Exists(productDatabase))
                File.Create(productDatabase);

            string toBeDeSerialized = File.ReadAllText(productDatabase);
            products = JsonConvert.DeserializeObject<List<Product>>(toBeDeSerialized);
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
            return products[id - 1];
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
