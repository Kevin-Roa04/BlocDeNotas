using AppCoreTareaBlocNotas.IServices;
using DomainTareaBlocNotas.Entities;
using DomainTareaBlocNotas.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCoreTareaBlocNotas.Services
{
    public class BlocNotasService : BaseService<BlocNotas>, IBlocNotasService
    {
        public IBlocNotasModel blocNotasModel;
        public BlocNotasService(IBlocNotasModel model) : base(model)
        {
            this.blocNotasModel = model;
        }
        public int GetLastId()
        {
            return blocNotasModel.GetLastId();
        }
    }
}
