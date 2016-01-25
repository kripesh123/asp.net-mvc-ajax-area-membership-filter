using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kripesh.WebStore.Application.Repository
{
    public interface IGenericRepository<E> where E : class
    {
        List<E> GetAll();
        E GetById(int id);
        int Insert(E e);
        int Update(E e);
        int Delete(E e);
        List<E> Search(Expression<Func<E>> e);
    }
}
