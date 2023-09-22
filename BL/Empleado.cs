using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Empleado
    {

        public static ML.Result GetAll(int IdEmpresa, string Nombre)
        {

            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {
                    var query = context.EmpleadoGetAll(IdEmpresa, Nombre).ToList();

                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var registro in query)
                        {
                            ML.Empleado empleado = new ML.Empleado();

                            empleado.NumeroEmpleado = registro.NumeroEmpleado;

                            empleado.Rfc = registro.Rfc;    

                            empleado.Nombre = registro.NombreEmpleado;

                            empleado.ApellidoPaterno = registro.ApellidoPaterno;

                            empleado.ApellidoMaterno = registro.ApellidoMaterno;

                            empleado.Email = registro.Email;

                            empleado.Telefono = registro.Telefono;

                            empleado.FechaNacimiento = Convert.ToDateTime(registro.FechaNacimiento);

                            empleado.Nss = registro.Nss;

                            empleado.FechaIngreso = Convert.ToDateTime(registro.FechaIngreso);

                            empleado.Foto = registro.Foto;

                            empleado.Empresa = new ML.Empresa();

                            empleado.Empresa.IdEmpresa = registro.IdEmpresa;

                            empleado.Empresa.Nombre = registro.NombreEmpresa;

                            result.Objects.Add(empleado);

                        }

                        result.Correct = true;

                    }

                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No existe el Usuario";
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




        public static ML.Result Add(ML.Empleado empleado)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {
                    var query = context.EmpleadoAdd(empleado.NumeroEmpleado, empleado.Rfc, empleado.Nombre, empleado.ApellidoPaterno, empleado.ApellidoMaterno, empleado.Email, empleado.Telefono, empleado.FechaNacimiento, empleado.Nss, empleado.FechaIngreso, empleado.Foto, empleado.Empresa.IdEmpresa);

                    if(query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = ":::ERROR::: No se agrego el empleado";
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


        public static ML.Result Update(ML.Empleado empleado)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {


                    int filasAfectadas = context.EmpleadoUpdate(empleado.NumeroEmpleado,empleado.Rfc, empleado.Nombre, empleado.ApellidoPaterno, empleado.ApellidoMaterno, empleado.Email, empleado.Telefono, empleado.FechaNacimiento, empleado.Nss, empleado.FechaIngreso, empleado.Foto, empleado.Empresa.IdEmpresa);

                    if(filasAfectadas > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Empleado No Agregado";
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

        public static ML.Result Delete(string NumeroEmpleado)
        {
            ML.Result result = new ML.Result();

            try
            {
                using(DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {

                    int filasAfectadas = context.EmpleadoDelete(NumeroEmpleado);
                    if( filasAfectadas > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "El empleado No se elimino";
                       
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


        public static ML.Result GetById(string NumeroEmpleado)
        {
            ML.Result result = new ML.Result();

            try
            {
                using(DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {
                    var query = context.EmpleadoGetById(NumeroEmpleado).SingleOrDefault();

                    result.Objects = new List<object>();

                    if(query != null )
                    {
                        ML.Empleado empleado = new ML.Empleado();

                        empleado.NumeroEmpleado = query.NumeroEmpleado;

                        empleado.Rfc = query.Rfc;

                        empleado.Nombre = query.NombreEmpleado;

                        empleado.ApellidoPaterno = query.ApellidoPaterno;   

                        empleado.ApellidoMaterno = query.ApellidoMaterno;   

                        empleado.Email = query.Email;   

                        empleado.Telefono = query.Telefono;

                        empleado.FechaNacimiento = Convert.ToDateTime(query.FechaNacimiento);

                        empleado.Nss = query.Nss;

                        empleado.FechaIngreso = Convert.ToDateTime(query.FechaIngreso);

                        empleado.Foto = query.Foto; 

                        empleado.Empresa = new ML.Empresa();

                        empleado.Empresa.IdEmpresa = query.IdEmpresa;

                        empleado.Empresa.Nombre = query.NombreEmpresa;


                        result.Object = empleado;
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al consultar Empleado";
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
