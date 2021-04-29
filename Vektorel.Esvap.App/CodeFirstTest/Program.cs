using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vektorel.Esvap.Datacore.Repositories;
using Vektorel.Esvap.Domain.Context;
using Vektorel.Esvap.Domain.Models;

namespace CodeFirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //ctx.Database.Create();

            //MasterCategory mc = new MasterCategory();

            //EsvapDbContext ctx = new EsvapDbContext();

            //ctx.Database.Create();
            //ctx.MasterCategories.Add(mc);
            //ctx.SaveChanges();


            //List<int> list = new List<int>();

            //list.Where(x => x > 0).ToList();

            //Matematik mat = new Matematik(Topla);

            //mat += Cikar;

            //mat(15.5, 11.2);

            //int num1 = 1;
            //int num2 = 3;
            //int num3 = 5;

            //List<int> sayilar = new List<int>();
            //Func<int, int, bool> newFunc = (x, y) => x > y;

            //// x,y => x>y
            //var result = newFunc(num1, num2);

            EsvapDbContext ctx = new EsvapDbContext();
            AddressRepository aRepo = new AddressRepository(ctx);
            var address = aRepo.Get(x => x.Id == 1);
            ProductRepository pRepo = new ProductRepository(ctx);
            Product p = new Product();
            pRepo.Insert(p);
            Console.ReadKey();
        }

        public delegate void Matematik(double num1, double num2);

        public static double Topla(double num1, double num2) => num1 + num2;

        public static void Cikar(double num1, double num2)
        {
            Console.WriteLine(num1 - num2);
        }
    }
}
