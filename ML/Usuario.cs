using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Usuario
    {

        public int IdUsuario { set; get; }
        [Display(Name = "User Name")]
        public string UserName { set; get; }
        [Required]
        [StringLength(20)]
        public string Nombre { set; get; }
        [Required]
        [Display (Name = "Apellido Paterno")]
        public string ApellidoPaterno { set; get; }
        [Display (Name = "Apellido Materno")]
        public string ApellidoMaterno { set; get; }
        [EmailAddress]
        [Required]
        public string Correo { set; get; }
        [Required]
        public string Contraseña { set; get; }
        [Required]
        public string Sexo { set; get; }
        [Phone]
        [Required]
        public string Telefono { set; get; }
        [Required]
        [Phone]
        public string Celular { set; get; }
        [Required]
        [Display (Name = "Fecha de nacimiento")]
        public DateTime FechaNacimiento { set; get; }
        
        public string Curp { set; get; }
       
        //Propiedad navegacion
        public ML.Rol Rol { set; get; }

        public ML.Direccion Direccion { set; get; } 

        public List<object> Usuarios { set; get; }

        public string Imagen { set; get; }

        public bool Status { set; get; }

        

       
    }
}
