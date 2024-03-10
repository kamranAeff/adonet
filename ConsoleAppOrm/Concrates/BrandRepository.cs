using ConsoleAppOrm.Abstracts;
using ConsoleAppOrm.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOrm.Concrates
{
    class BrandRepository : Repository<Brand>,IBrandRepository
    {
        public BrandRepository(DbContext db)
            : base(db)
        {
                
        }
    }
}
