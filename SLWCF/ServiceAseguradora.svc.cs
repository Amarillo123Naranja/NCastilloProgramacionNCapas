using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SLWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceAseguradora" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceAseguradora.svc o ServiceAseguradora.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceAseguradora : IServiceAseguradora
    {
        public SLWCF.Result Add(ML.Aseguradora aseguradora)
        {
            ML.Result result = BL.Aseguradora.Add(aseguradora);

            return new SLWCF.Result
            {
                ErrorMessage = result.ErrorMessage,
                Correct = result.Correct,
                Object = result.Object,
                Objects = result.Objects,
                Ex = result.Ex
            };
        }

        public SLWCF.Result Update(ML.Aseguradora aseguradora)
        {
            ML.Result result = BL.Aseguradora.Update(aseguradora);

            return new SLWCF.Result 
            {

                ErrorMessage = result.ErrorMessage,
                Correct = result.Correct,
                Object = result.Object,
                Objects = result.Objects,
                Ex = result.Ex

            };
        }

        public SLWCF.Result Delete(int IdAseguradora)
        {
            ML.Result result = BL.Aseguradora.Delete(IdAseguradora);

            return new SLWCF.Result 
            {

                ErrorMessage = result.ErrorMessage,
                Correct = result.Correct,
                Object = result.Object,
                Objects = result.Objects,
                Ex = result.Ex
            };
        }

        public SLWCF.Result GetAll()
        {
            ML.Result result = BL.Aseguradora.GetAll();

            return new SLWCF.Result 
            {

                ErrorMessage = result.ErrorMessage,
                Correct = result.Correct,
                Object = result.Object,
                Objects = result.Objects,
                Ex = result.Ex
            };
        }

        public SLWCF.Result GetById(int IdAseguradora) 
        {
            ML.Result result = BL.Aseguradora.GetById(IdAseguradora);

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
