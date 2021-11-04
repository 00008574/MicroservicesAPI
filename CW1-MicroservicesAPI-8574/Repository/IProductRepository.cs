using CW1_MicroservicesAPI_8574.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW1_MicroservicesAPI_8574.Repository
{
    public interface IProductRepository
    {
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int Id);
        Product GetProductById(int id);
        IEnumerable<Product> GetProducts();
    }
}
