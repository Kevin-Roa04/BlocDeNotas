using AppCoreTareaBlocNotas.IServices;
using DomainTareaBlocNotas.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCoreTareaBlocNotas.Services
{
    public abstract class BaseService<T> : IService<T>
    {
        private IModel<T> model;
        protected BaseService(IModel<T> model)
        {
            this.model = model;
        }

        public void Add(T t)
        {
            model.Add(t);
        }

        public void Delete(T t)
        {
            model.Delete(t);
        }

        public List<T> FindAll()
        {
            return model.FindAll();
        }
    }
}
