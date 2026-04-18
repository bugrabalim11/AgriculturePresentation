using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstarct
{
    public interface IGenericService<T> where T : class, new()
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetListAll();
        T? GetById(int id); // ? null olabilir
    }
}
