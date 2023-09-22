using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SLWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceEmpleado" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceEmpleado
    {
        [OperationContract]
        SLWCF.Result Add(ML.Empleado empleado);

        [OperationContract]
        SLWCF.Result Update(ML.Empleado empleado);

        [OperationContract]
        SLWCF.Result Delete(string NumeroEmpleado);
        [OperationContract]
        [ServiceKnownType(typeof(ML.Empleado))]
        SLWCF.Result GetAll(int IdEmpresa, string NumeroEmpleado);
        [OperationContract]
        [ServiceKnownType(typeof(ML.Empleado))]
        SLWCF.Result GetById(string NumeroEmpleado);



    }
}
