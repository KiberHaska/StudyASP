using AspLevel1.Domain.Entities.Base;
using AspLevel1.Domain.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPlevel1.ViewModels
{
    public class CategoryViewModel: NamedEntity, IOrderedEntity
    {
        public CategoryViewModel()
        {
            ChildCategories = new List<CategoryViewModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
               
        public List<CategoryViewModel> ChildCategories { get; set; }

        public CategoryViewModel ParentCategory { get; set; }
    }
}
