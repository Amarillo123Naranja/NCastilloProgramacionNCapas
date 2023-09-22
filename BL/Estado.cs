using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Estado
    {
        public static ML.Result GetByIdPais(int IdPais)
        { 
            ML.Result resultEstado = new ML.Result();

            try
            {
                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {
                    var query = context.EstadoGetByIdPais(IdPais).ToList();   
                    if(query != null)
                    {
                        resultEstado.Objects = new List<object>();
                        foreach (var registro in query)
                        {
                            ML.Estado estado = new ML.Estado(); 
                            estado.IdEstado = registro.IdEstado;
                            estado.Nombre = registro.Nombre; 

                            resultEstado.Objects.Add(estado);   
                            

                        }

                        resultEstado.Correct = true;
                    }

                    else
                    {
                        resultEstado.Correct = false; 
                    }

                }
            }
            catch (Exception ex)
            {
                resultEstado.ErrorMessage = ex.Message; 

            }

            return resultEstado;    

        
        
        }



    }
}
