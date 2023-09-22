using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Pais
    {


        public static ML.Result GetAll()
        {
            ML.Result resultPais = new ML.Result();
            try
            {
                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {

                    var query = context.PaisGetAll().ToList();

                  

                    if (query != null) 
                    {
                        resultPais.Objects = new List<object>();

                        foreach (var registro in query)
                        {
                            ML.Pais pais = new ML.Pais();

                            pais.IdPais = registro.IdPais;

                            pais.Nombre = registro.Nombre;

                            resultPais.Objects.Add(pais);


                        }

                        resultPais.Correct = true;

                    }
                    else
                    {

                        resultPais.Correct = false;
                        resultPais.ErrorMessage = ":::ERROR::";
                    }
                }

            }
            catch (Exception ex) 
            {

                resultPais.Correct = false;
                resultPais.ErrorMessage = ex.Message;
                resultPais.Ex = ex;

            }

            return resultPais;
        }
    }
}
