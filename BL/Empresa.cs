using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Empresa
    {
        public static ML.Result GetAll()
        {

            ML.Result resultEmpresa = new ML.Result();

            try
            {
                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {
                    var query = context.EmpresaGetAll().ToList();

                    resultEmpresa.Objects = new List<object>();

                    if(query != null)
                    {
                        foreach(var registro in query)
                        {

                            ML.Empresa empresa = new ML.Empresa();

                            empresa.IdEmpresa = registro.IdEmpresa;

                            empresa.Nombre = registro.Nombre;

                            empresa.Telefono = registro.Telefono;

                            resultEmpresa.Objects.Add(empresa);

                        }


                        resultEmpresa.Correct = true;



                    }

                    else
                    {
                        resultEmpresa.Correct = false;
                        resultEmpresa.ErrorMessage = ":::ERROR::";
                    }


                }

            }
            catch (Exception ex)
            {
                resultEmpresa.Correct = false;
                resultEmpresa.ErrorMessage = ex.Message;
                resultEmpresa.Ex = ex;
            }

            return resultEmpresa;

        }




    }
}
