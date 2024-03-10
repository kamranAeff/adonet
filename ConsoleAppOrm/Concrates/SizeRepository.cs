using ConsoleAppOrm.Abstracts;
using ConsoleAppOrm.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppOrm.Concrates
{
    class SizeRepository : Repository<Size>, ISizeRepository
    {
        public SizeRepository(DbContext db) : base(db)
        {
        }
    }
}
