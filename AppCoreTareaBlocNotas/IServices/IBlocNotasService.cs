using System;
using System.Collections.Generic;
using System.Text;

namespace AppCoreTareaBlocNotas.IServices
{
    public interface IBlocNotasService : IService
    {
        string Read(string t);
        void Sobreescribir(string t, string i);
    }
}
