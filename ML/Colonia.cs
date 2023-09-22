using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Colonia
    {

        [Display (Name = "Colonia")]
        public int IdColonia { set; get; }
        public string Nombre { set; get;}
        [Display (Name ="Codigo Postal")]
        public string CodigoPostal { set; get; }    

        public ML.Municipio Municipio { set; get; } 

        public List<Object> Colonias { set; get; }
    }
}
