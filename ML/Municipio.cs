using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
     public class Municipio
    {
        [Display (Name = "Municipio")]
        public int IdMunicipio { set; get; }

        public string Nombre { set; get; }  

        public ML.Estado Estado { set; get; }

        public List<Object> Municipios { set; get; }
    }
}
