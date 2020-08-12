using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AibelDeelineInterface.Data
{
    public interface IRepository<T> : IDisposable
    {
        T Get(params object[] keys);
        T GetFull(params object[] keys);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Func<T, bool> predicate);
        void Add(T item);
        void Delete(T item);
        void Update(T item);
    }
}
