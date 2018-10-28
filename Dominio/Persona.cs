using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        public Int32 Id { set; get; }
        public string Dni { set; get; }
        public string Apellido { set; get; }
        public string Nombre { set; get; }
        public string Sexo { set; get; }
        public Int32 IdSexo { set; get; }
        public DateTime FechaNacimiento { set; get; }
        public string Nacionalidad { set; get; }
        public Int32 IdNacionalidad { set; get; }
        public string Calle { set; get; }
        public string Altura { set; get; }
        public string Piso { set; get; }
        public string Dpto { set; get; }
        public string Partido { set; get; }
        public string Municipio { set; get; }
        public Int32 IdMunicipio { set; get; }
        public string CP { set; get; }
        public string TelCelular { set; get; }
        public string TelFijo { set; get; }
        public string Mail { set; get; }
        public DateTime FechaAlta { set; get; }
        public Int32 IdUsuarioAlta { set; get; }
        public DateTime FechaModif { set; get; }
        public Int32 IdUsuarioModif { set; get; }
        public DateTime FechaBaja { set; get; }
        public Int32 IdUsuarioBaja { set; get; }
        public bool Estado { set; get; }
    }
}
