using ASPlevel1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPlevel1.Infrastructure.Interfaces
{
    public interface IEmployeesService
    {
        IEnumerable<EmployeeViewModel> GetAll();
        EmployeeViewModel GetById(int id);
        void Commit();
        void AddNew(EmployeeViewModel model);
        void Delete(int id);
    }
}
