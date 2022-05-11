using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class EfBaseRepository<T> where T : class, new()
    {
        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (var context = new ProjectDbContext())
            {
                return filter == null ?
                    context.Set<T>().ToList() :
                    context.Set<T>().Where(filter).ToList();
            }
        }
    }
}
