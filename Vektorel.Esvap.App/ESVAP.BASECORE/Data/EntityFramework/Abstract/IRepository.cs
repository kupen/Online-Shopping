using ESVAP.BASECORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ESVAP.BASECORE.Data.EntityFramework.Abstract
{
    public interface IRepository<TEntity>
        where TEntity : BaseModel
    {
        // CustomerRepository.GetList(x=>x.Id>5).ToList();
        List<TEntity> GetList(Expression<Func<TEntity,bool>> filter=null);
        // SingleOrDefault(x=>x.Id==id);
        // Find(3);
        TEntity Get(Expression<Func<TEntity,bool>> filter);
        bool Insert(TEntity model);
        bool Delete(TEntity model);
        bool Update(TEntity model);
    }
}