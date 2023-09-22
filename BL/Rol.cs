using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Rol
    {
        public static ML.Result GetAll()
        
        {

            ML.Result resultRol = new ML.Result();

            try
            {
                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {

                    var query = context.RolGetAll().ToList();

                    resultRol.Objects = new List<object>();

                    if (query != null)
                    {
                         
                        foreach (var registro in query) 
                        {
                            ML.Rol rol = new ML.Rol();

                            rol.IdRol = registro.IdRol;

                            rol.Nombre = registro.Nombre;

                            resultRol.Objects.Add(rol);


                        }

                        resultRol.Correct = true;
                        
                    }
                    else
                    {

                        resultRol.Correct = false;
                        resultRol.ErrorMessage = ":::ERROR::";

                    }
                }

            }
            catch (Exception ex)
            {


                resultRol.Correct = false;
                resultRol.ErrorMessage = ex.Message;
                resultRol.Ex = ex;

            }

            return resultRol;

        

    }





    }
}
