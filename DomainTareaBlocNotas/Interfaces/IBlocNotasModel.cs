using System;
using System.Collections.Generic;
using System.Text;

namespace DomainTareaBlocNotas.Interfaces
{
    public interface IBlocNotasModel : IModel
    {
        string Read(String t);
        void Sobreescribir(string t, string i);
    }
}
