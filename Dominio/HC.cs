using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class HC
    {
        public Int32 IdHC { set; get; }
        public Int32 IdRazonSocial { set; get; }
        public Int32 IdPaciente { set; get; }
        public string NumeroAfiliado { set; get; }
        public DateTime FechaVencimientoCarnet { set; get; }
        public string DescripcionAccidente { set; get; }
        public DateTime FechaHrAlta { set; get; }
        public Int32 IdAdminAlta { set; get; }
        public string Ingresante { set; get; }
        public DateTime FechaHrModif { set; get; }
        public Int32 IdAdminModif { set; get; }
        public DateTime FechaHrBaja { set; get; }
        public Int32 IdAdminBaja { set; get; }
        public Int32 Estado { set; get; }
    }
}
