using DomainTareaBlocNotas.Entities;
using DomainTareaBlocNotas.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InfraestructureTareaBlocNotas.Repository
{
    public class WrittenBlocNotasRepository : IBlocNotasModel
    {
        private BinaryWriter binaryWriter;
        public void Add(BlocNotas t)
        {
            try
            {
                using (FileStream fileStream = new FileStream(t.Path, FileMode.Append, FileAccess.Write))
                {
                    binaryWriter = new BinaryWriter(fileStream);
                    binaryWriter.Write(t.Texto);
                    binaryWriter.Close();
                }

            }
            catch (IOException)
            {
                throw;
            }
        }

        public void Delete(BlocNotas t)
        {
            
        }

        public List<BlocNotas> FindAll()
        {
            return null;   
        }

        public int GetLastId()
        {
            return 0;
        }
    }
}
