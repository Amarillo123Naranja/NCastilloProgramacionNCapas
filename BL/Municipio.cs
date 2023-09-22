using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Municipio
    {

        public static ML.Result GetByIdEstado(int IdEstado)
        {

            ML.Result resultMunicipio = new ML.Result();

            try
            {
                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {
                    var query = context.MunicipioGetByIdEstado(IdEstado).ToList();
                    if (query != null)
                    {
                        resultMunicipio.Objects = new List<object>();
                        foreach (var registro in query)
                        {
                            ML.Municipio municipio = new ML.Municipio();
                            municipio.IdMunicipio = registro.IdMunicipio;
                            municipio.Nombre = registro.Nombre;

                            resultMunicipio.Objects.Add(municipio);


                        }

                        resultMunicipio.Correct = true;
                    }

                    else
                    {
                        resultMunicipio.Correct = false;
                    }

                }
            }
            catch (Exception ex)
            {
                resultMunicipio.ErrorMessage = ex.Message;

            }

            return resultMunicipio;



        }
    }
}
