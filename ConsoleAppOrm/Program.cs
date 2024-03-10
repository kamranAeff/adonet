using ConsoleAppOrm.Abstracts;
using ConsoleAppOrm.Concrates;
using ConsoleAppOrm.Models.DataContexts;
using ConsoleAppOrm.Models.Entities;

namespace ConsoleAppOrm
{
    internal class Program
    {
        static SchoolDbContext db = new SchoolDbContext();
        static void Main(string[] args)
        {
            #region Test via Brand Repository
            //IBrandRepository brandRepository = new BrandRepository(db);

            //brandRepository.Add(new Brand { Name = "Test Edirik", CreatedBy = 1, CreatedAt = DateTime.Now });
            //brandRepository.Add(new Brand { Name = "Test Edirik2", CreatedBy = 1, CreatedAt = DateTime.Now });
            //brandRepository.Add(new Brand { Name = "Test Edirik3", CreatedBy = 1, CreatedAt = DateTime.Now });
            //Console.WriteLine($"Affected: {brandRepository.Save()}");



            //var data = brandRepository.GetAll(m => m.Id > 4 && m.Name.Length > 2).ToList();

            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.Name);
            //}
            #endregion

            /*
                 LINQ
                     - Method Base Linq
                     - Query Base Linq
             
             */


            //var categories = db.Set<Category>()
            //    .Where(m => m.ParentId != null)
            //    .Select(m => new { m.Name, m.Id }) //projection
            //    .ToList();

            ICategoryRepository categoryRepository = new CategoryRepository(db);

            var query = from c in categoryRepository.GetAll()
                        where c.ParentId != null
                        select new { c.Id, c.Name };

            var data = query.ToList();


            foreach (var item in data)
            {
                Console.WriteLine($"Name: {item.Name} # Parent: {item.Id}");
            }


            Console.WriteLine("Complated!");

        }

        #region Examples
        //private static void SelectViaOrm()
        //{
        //    var brands = db.Brands.Where(m => m.DeletedAt == null).ToList();

        //    foreach (var brand in brands)
        //    {
        //        Console.WriteLine($"{brand.Id} {brand.Name}");
        //    }
        //    Console.WriteLine("#########################################");
        //    var products = db.Set<Product>().ToList();

        //    foreach (var product in products)
        //    {
        //        Console.WriteLine($"{product.Id} {product.Name}");
        //    }
        //}

        //private static void RemoveViaOrm()
        //{
        //    Brand b = db.Brands.FirstOrDefault(m => m.Id == 2);

        //    if (b is null)
        //    {
        //        Console.WriteLine("Record not found");
        //        return;
        //    }

        //    db.Brands.Remove(b);

        //    db.SaveChanges();
        //}

        //private static void UpdateViaOrm()
        //{
        //    Brand b = db.Brands.FirstOrDefault(m => m.Id == 2);

        //    if (b is null)
        //    {
        //        Console.WriteLine("Record not found");
        //        return;
        //    }

        //    b.Name = "Demo";

        //    db.SaveChanges();
        //}

        //private static void InsertViaOrm()
        //{
        //    Brand b1 = new Brand();
        //    b1.Name = "Gucci";
        //    b1.CreatedBy = 1;
        //    b1.CreatedAt = DateTime.Now;

        //    db.Brands.Add(b1);
        //    db.SaveChanges();
        //}
        #endregion
    }
}
