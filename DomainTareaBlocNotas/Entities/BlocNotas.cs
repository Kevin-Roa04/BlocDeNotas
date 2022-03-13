using System;
using System.Collections.Generic;
using System.Text;

namespace DomainTareaBlocNotas.Entities
{
    public class BlocNotas
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public string Titulo { get; set; }
        public string Path { get; set; }
    }
}
