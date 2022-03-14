using System;
using System.Collections.Generic;
using System.Text;

namespace DomainTareaBlocNotas.Interfaces
{
    public interface IModel
    {
        void Add(string t, int i);
        void Delete(string t, int i);
    }
}
