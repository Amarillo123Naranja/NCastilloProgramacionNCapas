using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Colonia
    {

        public static ML.Result GetByIdMunicipio(int IdMunicipio)
        {

            ML.Result resultColonia = new ML.Result();

            try
            {
                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {
                    var query = context.ColoniaGetByIdMunicipio(IdMunicipio).ToList();
                    if (query != null)
                    {
                        resultColonia.Objects = new List<object>();
                        foreach (var registro in query)
                        {
                            ML.Colonia colonia = new ML.Colonia();
                            colonia.IdColonia = registro.IdColonia;
                            colonia.Nombre = registro.Nombre;
                            

                            resultColonia.Objects.Add(colonia);


                        }

                        resultColonia.Correct = true;
                    }

                    else
                    {
                        resultColonia.Correct = false;
                    }

                }
            }
            catch (Exception ex)
            {
                resultColonia.ErrorMessage = ex.Message;

            }

            return resultColonia;



        }

    }
}
