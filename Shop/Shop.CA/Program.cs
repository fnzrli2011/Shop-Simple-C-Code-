using Shop.Buisness.DTOs;
using Shop.Buisness.Implementations;
using Shop.Core.Models;
using Shop.Data.DAL;

namespace Shop.CA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product() { Name = "Ball" , CostPrice=10 ,SalePrice = 1100};
            ProductCreateDTO productCreateDTO = new ProductCreateDTO(product.Name, product.SalePrice, product.SalePrice);
            ProductGetDTO productGetDTO = new ProductGetDTO(product.Name,product.SalePrice);
            ProductService productService = new ProductService();
            productService.Create(productCreateDTO);
            foreach (var item in ShopData.products)
            {
                Console.WriteLine(item.SalePrice);
            }
        }
    }
}
