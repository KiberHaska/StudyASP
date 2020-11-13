using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AspLevel1.Domain.Entities.Base.Interfaces;

namespace AspLevel1.Domain.Entities.Base
{
    public class NamedEntity : INamedEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
