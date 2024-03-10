using ConsoleAppOrm.Abstracts;
using ConsoleAppOrm.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppOrm.Concrates
{
    class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(DbContext db)
            :base(db)
        {
                
        }

        public decimal GetActualGrade()
        {
            return 9.8M;
        }
    }
}
