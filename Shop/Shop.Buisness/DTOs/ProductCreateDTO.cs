using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Buisness.DTOs
{
    public record class ProductCreateDTO(string name , decimal SalePrice , decimal CotPrice);
}
