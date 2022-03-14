using System;
using System.Collections.Generic;
using System.Text;

namespace AppCoreTareaBlocNotas.IServices
{
    public interface IService
    {
        void Add(string t, int i);
        void Delete(string t, int i);
    }
}
