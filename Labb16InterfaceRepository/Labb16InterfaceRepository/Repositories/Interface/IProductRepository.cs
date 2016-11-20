using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb16InterfaceRepository
{
    interface IProductRepository
    {
        void Add();
        Product Get(int id);
        Product[] GetAll();
        void Update(Product updatedProduct);
        void Delete(int id);

    }
}
