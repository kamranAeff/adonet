namespace ConsoleAppOrm.Models.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime BirthOfDate { get; set; }
    }
}
