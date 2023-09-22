using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace BL
{


    public class Aseguradora
    {


        public static ML.Result GetAll()
        {

            ML.Result result = new ML.Result();

            try

            {
                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {
                    var query = context.AseguradoraGetAll().ToList();

                    result.Objects = new List<Object>();

                    if (query != null)
                    {
                        foreach (var registro in query)
                        {
                            ML.Aseguradora aseguradora = new ML.Aseguradora();

                            aseguradora.IdAseguradora = registro.IdAseguradora;

                            aseguradora.Nombre = registro.Nombre;

                            aseguradora.FechaCreacion = Convert.ToDateTime(registro.FechaCreacion);

                            aseguradora.FechaModificacion = Convert.ToDateTime(registro.FechaModificacion);

                            aseguradora.Usuario = new ML.Usuario();

                            aseguradora.Usuario.IdUsuario = registro.IdUsuario;

                            aseguradora.Usuario.Nombre = registro.NombreUsuario;

                            result.Objects.Add(aseguradora);


                        }

                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No hay usuarios agregados";
                    }
                }


            }

            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;

        }

        public static ML.Result Add(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();


            try
            {
                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {
                    var query = context.AseguradoraAdd(aseguradora.Nombre, aseguradora.Usuario.IdUsuario);
                    if (query > 0)
                    {

                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al agregar el Usuario";

                    }

                }

            }
            catch(Exception ex)
            {
                result.Correct= false;  
                result.ErrorMessage = ex.Message; 
                result.Ex = ex;
            }

            return result;  
            {


            }


        }



        public static ML.Result Delete(int IdAseguradora) 
        {
            ML.Result result = new ML.Result();

            try
            {

                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {

                    int filasAfectadas = context.AseguradoraDelete(IdAseguradora);

                    if(filasAfectadas > 0)
                    {

                        result.Correct = true;
                    }

                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "ERROR";

                    }


                }

            }

            catch (Exception ex)
            {
                result.Correct= false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex; 
            }

            return result;

        }



        public static ML.Result GetById(int IdAseguradora) 
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {
                    var query = context.AseguradoraGetById(IdAseguradora).SingleOrDefault();

                    result.Objects = new List<object>();

                    if (query != null)
                    {

                        ML.Aseguradora aseguradora = new ML.Aseguradora();

                        aseguradora.IdAseguradora = query.IdAseguradora;

                        aseguradora.Nombre = query.Nombre;

                        aseguradora.FechaCreacion = Convert.ToDateTime(query.FechaCreacion);

                        aseguradora.FechaModificacion = Convert.ToDateTime(query.FechaCreacion);

                        aseguradora.Usuario = new ML.Usuario();

                        aseguradora.Usuario.IdUsuario = query.IdUsuario;

                        aseguradora.Usuario.Nombre = query.Nombre;


                        result.Object = aseguradora;

                        result.Correct = true;
                    }

                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "ERROR AL CONSULTAR ASEGURADORA";


                    }

                   



                }

            }

            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        

        
        }



        public static ML.Result Update(ML.Aseguradora aseguradora)
        {

            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {

                    var filasAfectadas = context.AseguradoraUpdate(aseguradora.IdAseguradora, aseguradora.Nombre, aseguradora.Usuario.IdUsuario);
                    if (filasAfectadas > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {

                        result.Correct = false;
                        result.ErrorMessage = "Aseguradora no agregada";

                    }
                }

            }
            catch (Exception ex)
            {


                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }

            return result;

        }


    }

}
