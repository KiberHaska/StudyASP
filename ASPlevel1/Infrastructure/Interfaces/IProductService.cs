using AspLevel1.Domain.Entities;
using System.Collections.Generic;

namespace ASPlevel1.Infrastructure.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<Brand> GetBrands();
    }
}
