using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Dependiente
    {
       public static ML.Result GetByIdEmpleado(string NumeroEmpleado)
        {
            ML.Result resultEmpleado = new ML.Result();

            try
            {
                using(DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {
                    var query = context.DependienteGetByIdEmpleado(NumeroEmpleado).ToList(); 
                    if (query != null) 
                    {
                        resultEmpleado.Objects = new List<object>();

                        foreach(var registro in query)
                        {
                            ML.Dependiente dependiente = new ML.Dependiente();

                            dependiente.IdDependiente = registro.IdDependiente;

                            dependiente.Nombre = registro.Nombre;

                            dependiente.ApellidoPaterno = registro.ApellidoPaterno; 

                            dependiente.ApellidoMaterno = registro.ApellidoMaterno;

                            dependiente.FechaNacimiento = Convert.ToDateTime(registro.FechaNacimiento);

                            dependiente.EstadoCivil = registro.EstadoCivil;

                            dependiente.Genero = registro.Genero;   

                            dependiente.Telefono = registro.Telefono;   

                            dependiente.Rfc = registro.Rfc;

                            dependiente.Empleado = new ML.Empleado();

                            dependiente.Empleado.NumeroEmpleado = registro.NumeroEmpleado;  

                            resultEmpleado.Objects.Add(dependiente);

                          

                        }

                        resultEmpleado.Correct = true;

                    }
                    else
                    {
                        resultEmpleado.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                resultEmpleado.ErrorMessage = ex.Message;
            }

            return resultEmpleado;
        }


        public static ML.Result Add(ML.Dependiente dependiente)
        {
            ML.Result result = new ML.Result();

            try
            {
                using(DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {
                    var query = context.DependienteAdd(dependiente.Nombre, dependiente.ApellidoPaterno, dependiente.ApellidoMaterno, dependiente.FechaNacimiento, dependiente.EstadoCivil, dependiente.Genero, dependiente.Telefono, dependiente.Rfc,dependiente.Empleado.NumeroEmpleado);
                    if(query > 0)
                    {
                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Dependiente No agregado";


                    }
                }
            }
            
            catch(Exception ex) 
            {

                result.Correct = false;
                result.ErrorMessage = ex.Message;   
                result.Ex = ex; 

            }

            return result;  
        }

        public static ML.Result Update(ML.Dependiente dependiente) 
        {
            ML.Result result = new ML.Result();

            try
            {
                using(DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {
                    int filasAfectadas = context.DependienteUpdate(dependiente.IdDependiente, dependiente.Nombre, dependiente.ApellidoPaterno, dependiente.ApellidoMaterno, dependiente.FechaNacimiento, dependiente.EstadoCivil, dependiente.Genero, dependiente.Telefono, dependiente.Rfc,dependiente.Empleado.NumeroEmpleado);

                    if(filasAfectadas > 0)
                    {
                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Dependiente NO ACTUALIZADO";
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


        public static ML.Result Delete(int IdDependiente)
        {

            ML.Result result = new ML.Result();

            try
            {
                using(DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {
                    int filasAfectadas = context.DependienteDelete(IdDependiente);
                    if(filasAfectadas > 0)
                    {
                        result.Correct = true;  
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "El dependiente NO SE ELIMINO";
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


        public static ML.Result GetById(int IdDependiente)
        {
            ML.Result result = new ML.Result(); 
            
            try
            { using(DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                
                {
                    var query = context.DependienteGetById(IdDependiente).SingleOrDefault();

                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        ML.Dependiente dependiente = new ML.Dependiente();

                        dependiente.IdDependiente = query.IdDependiente;

                        dependiente.Nombre = query.Nombre;

                        dependiente.ApellidoPaterno = query.ApellidoPaterno;    

                        dependiente.ApellidoMaterno = query.ApellidoMaterno;

                        dependiente.FechaNacimiento = Convert.ToDateTime(query.FechaNacimiento);

                        dependiente.EstadoCivil = query.EstadoCivil;

                        dependiente.Genero = query.Genero;

                        dependiente.Telefono = query.Telefono;

                        dependiente.Rfc = query.Rfc;

                        result.Object = dependiente;    

                        result.Correct = true;  
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al consultar Dependiente";

                    }




                }

            }
            catch(Exception ex)
            {
                result.Correct = false; 
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;  
        }

    }
}
