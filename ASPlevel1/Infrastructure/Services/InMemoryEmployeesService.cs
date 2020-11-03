using ASPlevel1.Infrastructure.Interfaces;
using ASPlevel1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPlevel1.Infrastructure.Services
{
    public class InMemoryEmployeesService : IEmployeesService
    {
        private readonly List<EmployeeViewModel> _employees = new List<EmployeeViewModel>
        {
            new EmployeeViewModel
            {
                Id = 1,
                FirstName = "Ivan",
                SurName = "IvanOff",
                Patronymic = "Ivanovich",
                Age = 22,
                Position = "Boss"
            },
            new EmployeeViewModel
            {
                Id = 2,
                FirstName = "Vlad",
                SurName = "PetrOff",
                Patronymic = "Ivanovich",
                Age = 35,
                Position = "Programmer"
            }
        };
        public void AddNew(EmployeeViewModel model)
        {
            model.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(model);
        }
        public void Commit()
        {
            
        }
        public void Delete(int id)
        {
            var employee = GetById(id);
            if (employee is null)
                return;
            _employees.Remove(employee);
        }
        public IEnumerable<EmployeeViewModel> GetAll()
        {
            return _employees;
        }
        public EmployeeViewModel GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id.Equals(id));
        }
        
    }
}
