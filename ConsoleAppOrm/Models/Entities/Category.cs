using ConsoleAppOrm.Models.Commons;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppOrm.Models.Entities
{
    public class Category : AuditableEntity
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
    }
}
