using ConsoleAppOrm.Abstracts;
using ConsoleAppOrm.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppOrm.Concrates
{
    class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext db) : base(db)
        {
        }
    }
}
