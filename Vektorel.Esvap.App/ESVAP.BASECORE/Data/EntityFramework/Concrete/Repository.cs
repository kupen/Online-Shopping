using ESVAP.BASECORE.Data.EntityFramework.Abstract;
using ESVAP.BASECORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace ESVAP.BASECORE.Data.EntityFramework.Concrete
{
    public class Repository<TContext, TEntity> : IRepository<TEntity>
        where TEntity : BaseModel
        where TContext : DbContext
    {
        protected TContext ctx;
        public Repository(TContext context)
        {
            ctx = context;
        }
        public bool Delete(TEntity model)
        {
            try
            {
                //ctx.Set<TEntity>().Remove(model);
                model.IsDeleted = true;
                model.IsActive = false;
                return ctx.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw new Exception("Silinemedi");
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            TEntity tentiti = null;
            try
            {
                tentiti = ctx.Set<TEntity>().SingleOrDefault(filter);
                return tentiti;
            }
            catch (Exception)
            {
                throw new Exception("Getiremedi");
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            List<TEntity> result = null;
            try
            {
                if (filter == null)
                {
                    result = ctx.Set<TEntity>().ToList();
                }
                else
                {
                    result = ctx.Set<TEntity>().Where(filter).ToList();
                }

                return result;
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    throw new Exception("Format hatası var");
                }
                else if (ex is OverflowException)
                {
                    throw new Exception("Veri boyutu bizi aştı");
                }
                else
                {
                    throw new Exception("Listeyi getiremedi");
                }
            }
        }

        public bool Insert(TEntity model)
        {

            // Recursive Method
            try
            {
                ctx.Set<TEntity>().Add(model);
                return ctx.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw new Exception("Ekleme işlemi sırasında bir hata oluştu.");
            }
        }


        public bool Update(TEntity model)
        {
            try
            {
                // Func<TEntity,object>
                model.Updated = DateTime.Now;
                ctx.Set<TEntity>().AddOrUpdate(x => x.Id, model);
                return ctx.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw new Exception("Güncellenemedi");
            }
        }
    }
}
