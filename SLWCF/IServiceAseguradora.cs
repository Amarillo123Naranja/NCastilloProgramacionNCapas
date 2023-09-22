using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SLWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceAseguradora" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceAseguradora
    {
        [OperationContract]
        SLWCF.Result Add(ML.Aseguradora aseguradora);

        [OperationContract] 

        SLWCF.Result Update(ML.Aseguradora aseguradora);

        [OperationContract] 

        SLWCF.Result Delete(int IdAseguradora);

        [OperationContract]
        [ServiceKnownType(typeof(ML.Empleado))]
        SLWCF.Result GetAll();

        [OperationContract]
        [ServiceKnownType(typeof(ML.Empleado))]
        SLWCF.Result GetById(int IdAseguradora);
    }
}
