using System;
using System.Collections.Generic;
using System.Text;

namespace DomainTareaBlocNotas.Interfaces
{
    public interface IModel<T>
    {
        void Add(T t);
        void Delete(T t);
        List<T> FindAll();  
    }
}
