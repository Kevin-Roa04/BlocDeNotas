using AppCoreTareaBlocNotas.IServices;
using DomainTareaBlocNotas.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCoreTareaBlocNotas.Services
{
    public abstract class BaseService : IService
    {
        private IModel model;
        protected BaseService(IModel model)
        {
            this.model = model;
        }

        public void Add(string t, int i)
        {
            model.Add(t, i);
        }

        public void Delete(string t, int i)
        {
            model.Delete(t, i);
        }
    }
}
