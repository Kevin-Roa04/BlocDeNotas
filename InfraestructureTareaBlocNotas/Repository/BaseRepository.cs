using DomainTareaBlocNotas.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraestructureTareaBlocNotas.Repository
{
    public abstract class BaseRepository<T> : IModel<T>
    {
        public List<T> data;
        public BaseRepository()
        {
            data = new List<T>();
        }
        public void Add(T t)
        {
            data.Add(t); 
        }

        public void Delete(T t)
        {
            data.Remove(t);
        }

        public List<T> FindAll()
        {
            return data;
        }
    }
}
