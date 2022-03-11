using DomainTareaBlocNotas.Entities;
using DomainTareaBlocNotas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfraestructureTareaBlocNotas.Repository
{
    public class ListBlocNotasRepository : BaseRepository<BlocNotas>, IBlocNotasModel
    {
        public int GetLastId()
        {
            int MaxId = 0;
            return data.Count == 0 ? MaxId = 1 : MaxId = data.Max(x => x.Id) + 1;
        }
    }
}
