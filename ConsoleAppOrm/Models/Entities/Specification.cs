using ConsoleAppOrm.Models.Commons;

namespace ConsoleAppOrm.Models.Entities
{
    public class Specification : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
