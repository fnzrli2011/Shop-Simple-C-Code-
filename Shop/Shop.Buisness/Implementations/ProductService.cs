using Shop.Buisness.DTOs;
using Shop.Buisness.Interfaces;
using Shop.Core.Models;
using Shop.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shop.Buisness.Implementations
{
    public class ProductService : IProductService
    {
        public void Create(ProductCreateDTO product)
        {
            ShopData.products.Add(new Product() { Name = product.name , CostPrice = product.CotPrice ,SalePrice = product.SalePrice});
        }

        public void Delete(int id)
        {
            Product? searched = ShopData.products.FirstOrDefault(x => x.Id == id);
            if (searched != null)
            {
                throw new NotImplementedException("Product not found");
            }
            ShopData.products.Remove(searched);
        }

        public List<ProductGetDTO> GetAll()
        {
            List<ProductGetDTO> getproducts = new List<ProductGetDTO>();
            foreach (var item in ShopData.products)
            {
                getproducts.Add(new ProductGetDTO( item.Name,item.SalePrice));
            }
            return getproducts;
        }

        public ProductCreateDTO GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
