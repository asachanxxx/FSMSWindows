using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Repository
{
    public interface IRepositoryBase<T> where T:class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        int Save(T entity );
        bool Delete(int id);

    }
}
