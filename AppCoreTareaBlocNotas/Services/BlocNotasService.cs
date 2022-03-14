using AppCoreTareaBlocNotas.IServices;
using DomainTareaBlocNotas.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCoreTareaBlocNotas.Services
{
    public class BlocNotasService : BaseService, IBlocNotasService
    {
        public IBlocNotasModel blocNotasModel;
        public BlocNotasService(IBlocNotasModel model) : base(model)
        {
            this.blocNotasModel = model;
        }
        public string Read(string t)
        {
            return blocNotasModel.Read(t);
        }

        public void Sobreescribir(string t, string i)
        {
            blocNotasModel.Sobreescribir(t, i);
        }
    }
}
