using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Domicilio
    {
        public int IdDomicilio { set; get; }
        public string Calle { set; get; }
        public int Altura { set; get; }
        public string Piso { set; get; }
        public string Dpto { set; get; }
        public string Municipio { set; get; }
        public string CP { set; get; }
    }
}
