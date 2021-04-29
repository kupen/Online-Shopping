using ESVAP.BASECORE.Data.EntityFramework.Abstract;
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
    public interface IAddressRepository : IRepository<Address> { }
    public class AddressRepository:Repository<EsvapDbContext,Address>,IAddressRepository
    {
        public AddressRepository(EsvapDbContext context) : base(context)
        {

        }
    }
}
