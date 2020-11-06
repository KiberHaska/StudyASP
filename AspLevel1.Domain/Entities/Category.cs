using AspLevel1.Domain.Entities.Base;
using AspLevel1.Domain.Entities.Base.Interfaces;

namespace AspLevel1.Domain.Entities
{
    public class Category: NamedEntity, IOrderedEntity
    {
        public int? ParentId { get; set; }
        public int Order { get; set; }
    }
}
