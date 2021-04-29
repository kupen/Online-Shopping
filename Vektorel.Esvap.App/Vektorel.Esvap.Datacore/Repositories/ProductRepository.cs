using ESVAP.BASECORE.Data.EntityFramework.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vektorel.Esvap.Domain.Context;
using Vektorel.Esvap.Domain.Models;

namespace Vektorel.Esvap.Datacore.Repositories
{
    public class ProductRepository:Repository<EsvapDbContext,Product>
    {
        public ProductRepository(EsvapDbContext context) : base(context)
        {

        }
    }
}
