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
        private BinaryReader binaryReader;
        public void Add(string t, int i)
        {
            if (i == 1)
            {
                using(FileStream file = File.Create(t))
                {
                    file.Close();
                }
            }
            else if (i == 2)
            {
                Directory.CreateDirectory(t);
            }
        }
        public void Delete(string t, int i)
        {
            if (i ==1)
            {
                File.Delete(t);
            }
            else if (i == 2)
            {
                Directory.Delete(t, true);
            }
        }
        public string Read(string t)
        {
            string texto = string.Empty;
            try
            {
                using (FileStream fileStream = new FileStream(t, FileMode.Open, FileAccess.Read))
                {
                    binaryReader = new BinaryReader(fileStream);
                    long length = binaryReader.BaseStream.Length;
                    if (length <= 0)
                    {
                        return texto;
                    }
                    binaryReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    texto = File.ReadAllText(t);
                    binaryReader.Close();
                    fileStream.Close();
                }
                return texto;
            }
            catch (IOException)
            {
                throw;
            }
        }

        public void Sobreescribir(string t, string i)
        {
            using (FileStream file = new FileStream(t, FileMode.Truncate, FileAccess.Write))
            {
                binaryWriter = new BinaryWriter(file);
                binaryWriter.Write(i);
                binaryWriter.Close();
                file.Close();
            }
        }
    }
}
