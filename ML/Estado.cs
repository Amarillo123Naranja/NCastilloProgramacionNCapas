using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Estado
    {
        [Display (Name = "Estado")]
        public int IdEstado { set; get; }
        public string Nombre { set; get; }

        //Propiedad de navegacion
        public ML.Pais Pais { set; get; }
      
        public List<Object> Estados { set; get; }


    }
}
