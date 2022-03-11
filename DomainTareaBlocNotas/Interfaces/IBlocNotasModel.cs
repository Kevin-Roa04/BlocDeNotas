using DomainTareaBlocNotas.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainTareaBlocNotas.Interfaces
{
    public interface IBlocNotasModel : IModel<BlocNotas>
    {
        int GetLastId();
    }
}
