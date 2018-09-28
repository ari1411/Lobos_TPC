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
        public RazonSocial IdRazonSocial { set; get; }
        public Paciente IdPaciente { set; get; }
        public Int32 NumeroAfiliado { set; get; }
        public DateTime FechaVencimiento { set; get; }
        public string DescripcionAcc { set; get; }
        public DateTime FechaHrAlta { set; get; }
        public Int32 IdAdminAlta { set; get; }
        public DateTime FechaHrModif { set; get; }
        public Int32 IdAdminModif { set; get; }
        public DateTime FechaHrBaja { set; get; }
        public Int32 IdAdminBaja { set; get; }
        public bool Estado { set; get; }
    }
}
