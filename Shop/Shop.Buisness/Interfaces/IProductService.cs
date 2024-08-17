using Shop.Buisness.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Buisness.Interfaces
{
    public interface IProductService
    {
        public void Create(ProductCreateDTO product);
        public ProductCreateDTO GetById(int id);
        public List<ProductGetDTO> GetAll();
        public void Delete(int id);
    }
}
