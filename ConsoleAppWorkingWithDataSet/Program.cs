using ConsoleAppWorkingWithDataSet.DataSetShopTableAdapters;

namespace ConsoleAppWorkingWithDataSet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var ds = new DataSetShop())
            using (var adp = new SizesTableAdapter())
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("SmallName: ");
                string smallName = Console.ReadLine();
                DateTime now = DateTime.UtcNow;


                adp.AddSize(name, smallName, now);

                adp.Fill(ds.Sizes);



                foreach (var item in ds.Sizes)
                {
                    Console.Write($"{item.Id} ");
                    Console.Write($"{item.Name} ");
                    Console.WriteLine($"{item.SmallName} ");
                }
            }
        }
    }
}
