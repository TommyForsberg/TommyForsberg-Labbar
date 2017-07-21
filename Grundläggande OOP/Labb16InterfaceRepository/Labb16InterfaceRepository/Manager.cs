using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Labb16InterfaceRepository
{
    class Manager
    {
        IProductRepository fileProductRepository = new FileProductRepository();
        IProductRepository listProductRepository = new ListProductRepository();
        
        public event AddingToFileEventHandler FileUpdate;

        public void ChangeProductInList()
        {
            UI.PrintProducts(listProductRepository.GetAll());
            var fetchedProduct = listProductRepository.Get(UI.SelectProduct());
            listProductRepository.Update(
            UI.ChangeProduct(fetchedProduct));
        }

        public void ChangeProductInFile()
        {
            UI.PrintProducts(fileProductRepository.GetAll());
            var fetchedProduct = fileProductRepository.Get(UI.SelectProduct());
            fileProductRepository.Update(UI.ChangeProduct(fetchedProduct));
            OnFileUpdate();
        }

        public void RemoveProductInList()
        {
            UI.PrintProducts(listProductRepository.GetAll());
            listProductRepository.Delete(UI.SelectProduct());
        }

        public void RemoveProductInFile()
        {
            UI.PrintProducts(fileProductRepository.GetAll());
            fileProductRepository.Delete(UI.SelectProduct());
            OnFileUpdate();
        }

        public void AddProductToList()
        {
            listProductRepository.Add();
        }

        public void AddProductToFile()
        {
            fileProductRepository.Add();
            OnFileUpdate();
        }
        public void FileUpdateData(object source, EventArgs args)
        {
            string serializedProducts = JsonConvert.SerializeObject(fileProductRepository.GetAll());
            var directory = Environment.CurrentDirectory;
            var file = String.Format("{0}{1}", directory, "\\database.json");
            File.WriteAllText(file, serializedProducts);
        }

        protected virtual void OnFileUpdate()
        {
            FileUpdate?.Invoke(this, EventArgs.Empty);
        }
    }
}
