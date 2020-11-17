using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspLevel1.Domain.Entities.Base.Interfaces
{
    public interface INamedEntity : IBaseEntity
    {        
        string Name { get; set; }
    }
}
