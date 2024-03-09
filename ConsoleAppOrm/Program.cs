using ConsoleAppOrm.Models.DataContexts;
using ConsoleAppOrm.Models.Entities;

namespace ConsoleAppOrm
{
    internal class Program
    {
        static SchoolDbContext db = new SchoolDbContext();
        static void Main(string[] args)
        {
            var brands = db.Brands.Where(m => m.DeletedAt == null).ToList();

            foreach (var brand in brands)
            {
                Console.WriteLine($"{brand.Id} {brand.Name}");
            }


            Console.WriteLine("Complated!");

        }

        private static void RemoveViaOrm()
        {
            Brand b = db.Brands.FirstOrDefault(m => m.Id == 2);

            if (b is null)
            {
                Console.WriteLine("Record not found");
                return;
            }

            db.Brands.Remove(b);

            db.SaveChanges();
        }

        private static void UpdateViaOrm()
        {
            Brand b = db.Brands.FirstOrDefault(m => m.Id == 2);

            if (b is null)
            {
                Console.WriteLine("Record not found");
                return;
            }

            b.Name = "Demo";

            db.SaveChanges();
        }

        private static void InsertViaOrm()
        {
            Brand b1 = new Brand();
            b1.Name = "Gucci";
            b1.CreatedBy = 1;
            b1.CreatedAt = DateTime.Now;

            db.Brands.Add(b1);
            db.SaveChanges();
        }
    }
}
