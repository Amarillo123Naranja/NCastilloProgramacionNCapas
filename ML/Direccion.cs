using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Direccion
    {
        [Display (Name = "Direccion")]
        public int IdDireccion { set; get; }
        public string Calle { set; get; }
        [Display (Name = "Numero Exterior")]
        public int NumeroExterior { set; get; }
        [Display (Name = "Numero Interior")]
        public int NumeroInterior { set; get; } 

        public ML.Colonia Colonia { set; get; }
        

    }
}
