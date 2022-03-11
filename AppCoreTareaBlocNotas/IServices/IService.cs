using System;
using System.Collections.Generic;
using System.Text;

namespace AppCoreTareaBlocNotas.IServices
{
    public interface IService<T>
    {
        void Add(T t);
        void Delete(T t);
        List<T> FindAll();
    }
}
