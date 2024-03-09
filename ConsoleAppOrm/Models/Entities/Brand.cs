using ConsoleAppOrm.Models.Commons;

namespace ConsoleAppOrm.Models.Entities
{
    public class Brand : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
