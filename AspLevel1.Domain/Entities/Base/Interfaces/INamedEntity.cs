using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspLevel1.Domain.Entities.Base.Interfaces
{
    public interface INamedEntity : IBaseEntity
    {        
        int Id { get; set; }
        string Name { get; set; }
    }
}
