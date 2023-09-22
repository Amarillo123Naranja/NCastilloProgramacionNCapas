using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Aseguradora
    {

        public int IdAseguradora { set; get; }

        public string Nombre { set; get; }  

        public DateTime FechaCreacion { set; get; }

        public DateTime FechaModificacion { set; get; }

        public List<object> Aseguradoras { set; get; }
        
        public ML.Usuario Usuario { set; get; }

    }
}
