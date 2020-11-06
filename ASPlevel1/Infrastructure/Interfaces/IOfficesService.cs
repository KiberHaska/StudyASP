using ASPlevel1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPlevel1.Infrastructure.Interfaces
{
    public interface IOfficesService
    {
        IEnumerable<OfficeViewModel> GetAll();
        OfficeViewModel GetById(int id);
        void Commit();
        void AddNew(OfficeViewModel model);
        void Delete(int id);
    }
}
