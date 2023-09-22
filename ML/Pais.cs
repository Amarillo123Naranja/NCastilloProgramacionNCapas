using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Pais
    {
        [Display (Name = "Pais")]
        public int IdPais { set; get; }

        public string Nombre { set; get; }

        public List<Object> Paises {set; get;}
    }
}
