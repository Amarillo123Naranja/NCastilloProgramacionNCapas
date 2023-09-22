using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;

namespace SLWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceEmpleado" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceEmpleado.svc o ServiceEmpleado.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceEmpleado : IServiceEmpleado
    {
        public SLWCF.Result Add(ML.Empleado empleado)
        {

            ML.Result result = BL.Empleado.Add(empleado);

            return new SLWCF.Result
            {
                ErrorMessage = result.ErrorMessage,
                Correct = result.Correct,
                Object = result.Object,
                Objects = result.Objects,
                Ex = result.Ex
            };
        }

        public SLWCF.Result Update(ML.Empleado empleado)
        { 
            
            ML.Result result = BL.Empleado.Update(empleado);

            return new SLWCF.Result
            {
                ErrorMessage = result.ErrorMessage,
                Correct = result.Correct,
                Object = result.Object,
                Objects = result.Objects,
                Ex = result.Ex  


            };

            
        }


        public SLWCF.Result Delete(string NumeroEmpleado)
        {
            ML.Result result = BL.Empleado.Delete(NumeroEmpleado);

            return new SLWCF.Result
            {
                ErrorMessage = result.ErrorMessage,
                Correct = result.Correct,
                Object = result.Object,
                Objects = result.Objects,
                Ex = result.Ex


            };

        }

        public SLWCF.Result GetAll(int IdEmpresa, string NumeroEmpleado)
        {
            ML.Result result = BL.Empleado.GetAll(IdEmpresa, NumeroEmpleado);

            return new SLWCF.Result
            {
                ErrorMessage = result.ErrorMessage,
                Correct = result.Correct,
                Object = result.Object,
                Objects = result.Objects,
                Ex = result.Ex


            };
        }

        public SLWCF.Result GetById(string NumeroEmpleado)
        {
            ML.Result result = BL.Empleado.GetById(NumeroEmpleado);

            return new SLWCF.Result
            {
                ErrorMessage = result.ErrorMessage,
                Correct = result.Correct,
                Object = result.Object,
                Objects = result.Objects,
                Ex = result.Ex


            };


        }


        
    }
}
