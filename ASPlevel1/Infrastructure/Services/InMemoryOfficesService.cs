using ASPlevel1.Infrastructure.Interfaces;
using ASPlevel1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPlevel1.Infrastructure.Services
{
    public class InMemoryOfficesService : IOfficesService
    {
        private readonly List<OfficeViewModel> _office = new List<OfficeViewModel>
        {
            new OfficeViewModel
            {
                Id = 1,
                Name = "Office1",
                Address = "1 Street"
            },
            new OfficeViewModel
            {
                Id = 2,
                Name = "Office2",
                Address = "2 Street"
            },
            new OfficeViewModel
            {
                Id = 3,
                Name = "Office3",
                Address = "3 Street"
            }
            };
       
        public void AddNew(OfficeViewModel model)
        {
            model.Id = (_office.Count > 0) ? _office.Max(e => e.Id) + 1 : 1;
            _office.Add(model);
        }

        public void Commit()
        {
            
        }
        public void Delete(int id)
        {
            var employee = GetById(id);
            if (employee is null)
                return;
            _office.Remove(employee);
        }
  
        public OfficeViewModel GetById(int id)
        {
            return _office.FirstOrDefault(e => e.Id.Equals(id));
        }

        public IEnumerable<OfficeViewModel> GetAll()
        {
            return _office;
        }       
    }
}
