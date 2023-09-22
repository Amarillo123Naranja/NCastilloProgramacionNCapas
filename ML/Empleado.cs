using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Empleado
    {

        public string NumeroEmpleado { set; get; }

        public string Rfc { set; get; }

        public string Nombre { set; get;}

        public string ApellidoPaterno { set; get; }

        public string ApellidoMaterno { set; get; }

        public string Email { set; get; }   

        public string Telefono { set; get; }   

        public DateTime FechaNacimiento { set; get; }    

        public string Nss { set; get; }

        public DateTime FechaIngreso { set; get; }

        public string Foto { set; get; }    

        //Propiedad de Navegacion
        public ML.Empresa Empresa { set; get; }

        public List<Object> Empleados { set; get; }

        public string Accion { set; get; }  
    }

}
