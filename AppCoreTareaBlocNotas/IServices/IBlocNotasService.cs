using DomainTareaBlocNotas.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCoreTareaBlocNotas.IServices
{
    public interface IBlocNotasService : IService<BlocNotas>
    {
        int GetLastId();
    }
}
