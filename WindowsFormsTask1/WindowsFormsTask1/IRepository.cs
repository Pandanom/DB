using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTask1
{
    public interface IRepository<T>:IDisposable
    {
        IEnumerable<T> GetList();
        T GetItem(int id);
        void Add(T item);
        void Delete(int id);
        void Save();

    }
}
