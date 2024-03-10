using ConsoleAppOrm.Abstracts;
using ConsoleAppOrm.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppOrm.Concrates
{
    class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext db) : base(db)
        {
        }
    }
}
