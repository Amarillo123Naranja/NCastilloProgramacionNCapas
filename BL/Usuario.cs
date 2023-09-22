using DLEF;
using Microsoft.Win32;
using ML;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BL
{
    public class Usuario

    {//mes-dia-año

        /*public static ML.Result Add(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                //todo lo que ejecute dentro de un using se libera al final
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "INSERT INTO Usuario VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @FechaNacimiento, @Direccion, @Correo, @Telefono, @EstadoCivil, @NumeroHijos)";

                    SqlCommand cmd = new SqlCommand(query, context);

                    SqlParameter[] collection = new SqlParameter[9];

                    collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                    collection[0].Value = usuario.Nombre;
                    collection[1] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
                    collection[1].Value = usuario.ApellidoPaterno;
                    collection[2] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
                    collection[2].Value = usuario.ApellidoMaterno;
                    collection[3] = new SqlParameter("@FechaNacimiento", SqlDbType.Date);
                    collection[3].Value = usuario.FechaNacimiento;
                    collection[4] = new SqlParameter("@Direccion", SqlDbType.VarChar);
                    collection[4].Value = usuario.Direccion;
                    collection[5] = new SqlParameter("@Correo", SqlDbType.VarChar);
                    collection[5].Value = usuario.Correo;
                    collection[6] = new SqlParameter("@Telefono", SqlDbType.VarChar);
                    collection[6].Value = usuario.Telefono;
                    collection[7] = new SqlParameter("@EstadoCivil", SqlDbType.VarChar);
                    collection[7].Value = usuario.EstadoCivil;
                    collection[8] = new SqlParameter("@NumeroHijos", SqlDbType.Int);
                    collection[8].Value = usuario.NumeroHijos;

                    cmd.Parameters.AddRange(collection);
                    cmd.Connection.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al agregar al Ususario";
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

        public static ML.Result AddSP(ML.Usuario usuario)
        {

            ML.Result result = new ML.Result();
            try
            {
                //todo lo que ejecute dentro de un using se libera al final
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "UsuarioAdd";

                    SqlCommand cmd = new SqlCommand(query, context);

                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter[] collection = new SqlParameter[10];

                    collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                    collection[0].Value = usuario.Nombre;
                    collection[1] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
                    collection[1].Value = usuario.ApellidoPaterno;
                    collection[2] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
                    collection[2].Value = usuario.ApellidoMaterno;
                    collection[3] = new SqlParameter("@FechaNacimiento", SqlDbType.Date);
                    collection[3].Value = usuario.FechaNacimiento;
                    collection[4] = new SqlParameter("@Direccion", SqlDbType.VarChar);
                    collection[4].Value = usuario.Direccion;
                    collection[5] = new SqlParameter("@Correo", SqlDbType.VarChar);
                    collection[5].Value = usuario.Correo;
                    collection[6] = new SqlParameter("@Telefono", SqlDbType.VarChar);
                    collection[6].Value = usuario.Telefono;
                    collection[7] = new SqlParameter("@EstadoCivil", SqlDbType.VarChar);
                    collection[7].Value = usuario.EstadoCivil;
                    collection[8] = new SqlParameter("@NumeroHijos", SqlDbType.Int);
                    collection[8].Value = usuario.NumeroHijos;
                    collection[9] = new SqlParameter("@IdRol", SqlDbType.Int);
                    collection[9].Value = usuario.Rol.IdRol;

                    cmd.Parameters.AddRange(collection);
                    cmd.Connection.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al agregar al Ususario";
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

        public static ML.Result Update(ML.Usuario usuario)

        {
            ML.Result result = new ML.Result();
            try
            {
                //todo lo que ejecute dentro de un using se libera al final
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "UPDATE Usuario SET Nombre = @Nombre, ApellidoPaterno = @ApellidoPaterno, ApellidoMaterno = @ApellidoMaterno, FechaNacimiento = @FechaNacimiento, Direccion = @Direccion, Correo = @Correo, Telefono = @Telefono, EstadoCivil = @EstadoCivil, NumeroHijos = @NumeroHijos WHERE IdUsuario = @IdUsuario";

                    SqlCommand cmd = new SqlCommand(query, context);

                    SqlParameter[] collection = new SqlParameter[10];


                    collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
                    collection[0].Value = usuario.IdUsuario;
                    collection[1] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                    collection[1].Value = usuario.Nombre;
                    collection[2] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
                    collection[2].Value = usuario.ApellidoPaterno;
                    collection[3] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
                    collection[3].Value = usuario.ApellidoMaterno;
                    collection[4] = new SqlParameter("@FechaNacimiento", SqlDbType.Date);
                    collection[4].Value = usuario.FechaNacimiento;
                    collection[5] = new SqlParameter("@Direccion", SqlDbType.VarChar);
                    collection[5].Value = usuario.Direccion;
                    collection[6] = new SqlParameter("@Correo", SqlDbType.VarChar);
                    collection[6].Value = usuario.Correo;
                    collection[7] = new SqlParameter("@Telefono", SqlDbType.VarChar);
                    collection[7].Value = usuario.Telefono;
                    collection[8] = new SqlParameter("@EstadoCivil", SqlDbType.VarChar);
                    collection[8].Value = usuario.EstadoCivil;
                    collection[9] = new SqlParameter("@NumeroHijos", SqlDbType.Int);
                    collection[9].Value = usuario.NumeroHijos;

                    cmd.Parameters.AddRange(collection);
                    cmd.Connection.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al Actualizar el Ususario";
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

        public static ML.Result UpdateSP(ML.Usuario usuario)
        {

            ML.Result result = new ML.Result();
            try
            {
                //todo lo que ejecute dentro de un using se libera al final
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "UsuarioUpdate";

                    SqlCommand cmd = new SqlCommand(query, context);

                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter[] collection = new SqlParameter[11];


                    collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
                    collection[0].Value = usuario.IdUsuario;
                    collection[1] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                    collection[1].Value = usuario.Nombre;
                    collection[2] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
                    collection[2].Value = usuario.ApellidoPaterno;
                    collection[3] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
                    collection[3].Value = usuario.ApellidoMaterno;
                    collection[4] = new SqlParameter("@FechaNacimiento", SqlDbType.Date);
                    collection[4].Value = usuario.FechaNacimiento;
                    collection[5] = new SqlParameter("@Direccion", SqlDbType.VarChar);
                    collection[5].Value = usuario.Direccion;
                    collection[6] = new SqlParameter("@Correo", SqlDbType.VarChar);
                    collection[6].Value = usuario.Correo;
                    collection[7] = new SqlParameter("@Telefono", SqlDbType.VarChar);
                    collection[7].Value = usuario.Telefono;
                    collection[8] = new SqlParameter("@EstadoCivil", SqlDbType.VarChar);
                    collection[8].Value = usuario.EstadoCivil;
                    collection[9] = new SqlParameter("@NumeroHijos", SqlDbType.Int);
                    collection[9].Value = usuario.NumeroHijos;
                    collection[10] = new SqlParameter("@IdRol", SqlDbType.Int);
                    collection[10].Value = usuario.Rol.IdRol;

                    cmd.Parameters.AddRange(collection);
                    cmd.Connection.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al Actualizar el Ususario";
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

        public static ML.Result GetAll()

        {
            ML.Result result = new ML.Result();

            try
            {
                //todo lo que ejecute dentro de un using se libera al final
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "SELECT IdUsuario, Nombre, ApellidoPaterno, ApellidoMaterno, FechaNacimiento, Direccion, Correo, Telefono, EstadoCivil, NumeroHijos FROM Usuario";

                    SqlCommand cmd = new SqlCommand(query, context);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable tablaUsuario = new DataTable();

                    adapter.Fill(tablaUsuario);


                    if (tablaUsuario.Rows.Count > 0)
                    {
                        result.Objects = new List<object>();

                        foreach (DataRow row in tablaUsuario.Rows)
                        {
                            ML.Usuario usuario = new ML.Usuario();

                            usuario.IdUsuario = int.Parse(row[0].ToString());

                            usuario.Nombre = row[1].ToString();

                            usuario.ApellidoPaterno = row[2].ToString();

                            usuario.ApellidoMaterno = row[3].ToString();

                            usuario.FechaNacimiento = DateTime.Parse(row[4].ToString());

                            usuario.Direccion = row[5].ToString();

                            usuario.Correo = row[6].ToString();

                            usuario.Telefono = row[7].ToString();

                            usuario.EstadoCivil = row[8].ToString();

                            usuario.NumeroHijos = int.Parse(row[9].ToString());



                            result.Objects.Add(usuario);
                        }

                        result.Correct = true;

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

        public static ML.Result GetAllSP()
        {

            ML.Result result = new ML.Result();

            try
            {
                //todo lo que ejecute dentro de un using se libera al final
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "UsuarioGetAll";

                    SqlCommand cmd = new SqlCommand(query, context);

                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable tablaUsuario = new DataTable();

                    adapter.Fill(tablaUsuario);


                    if (tablaUsuario.Rows.Count > 0)
                    {
                        result.Objects = new List<object>();

                        foreach (DataRow row in tablaUsuario.Rows)
                        {
                            ML.Usuario usuario = new ML.Usuario();

                            usuario.IdUsuario = int.Parse(row[0].ToString());

                            usuario.Nombre = row[1].ToString();

                            usuario.ApellidoPaterno = row[2].ToString();

                            usuario.ApellidoMaterno = row[3].ToString();

                            usuario.FechaNacimiento = DateTime.Parse(row[4].ToString());

                            usuario.Direccion = row[5].ToString();

                            usuario.Correo = row[6].ToString();

                            usuario.Telefono = row[7].ToString();

                            usuario.EstadoCivil = row[8].ToString();

                            usuario.NumeroHijos = int.Parse(row[9].ToString());

                            usuario.Rol = new ML.Rol();

                            usuario.Rol.IdRol = int.Parse(row[10].ToString());





                            result.Objects.Add(usuario);
                        }

                        result.Correct = true;

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

        public static ML.Result GetById(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                //todo lo que ejecute dentro de un using se libera al final
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "SELECT IdUsuario, Nombre, ApellidoPaterno, ApellidoMaterno, FechaNacimiento, Direccion, Correo, Telefono, EstadoCivil, NumeroHijos FROM Usuario WHERE IdUsuario = @IdUsuario";

                    SqlCommand cmd = new SqlCommand(query, context);

                    SqlParameter[] collection = new SqlParameter[1];
                    collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
                    collection[0].Value = usuario.IdUsuario;

                    cmd.Parameters.AddRange(collection);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable tablaUsuario = new DataTable();

                    adapter.Fill(tablaUsuario);


                    if (tablaUsuario.Rows.Count > 0)
                    {
                        DataRow row = tablaUsuario.Rows[0];

                        ML.Usuario usuarioResult = new ML.Usuario();

                        usuarioResult.IdUsuario = int.Parse(row[0].ToString());

                        usuarioResult.Nombre = row[1].ToString();

                        usuarioResult.ApellidoPaterno = row[2].ToString();

                        usuarioResult.ApellidoMaterno = row[3].ToString();

                        usuarioResult.FechaNacimiento = DateTime.Parse(row[4].ToString());

                        usuarioResult.Direccion = row[5].ToString();

                        usuarioResult.Correo = row[6].ToString();

                        usuarioResult.Telefono = row[7].ToString();

                        usuarioResult.EstadoCivil = row[8].ToString();

                        usuarioResult.NumeroHijos = int.Parse(row[9].ToString());

                        usuario.Rol = new ML.Rol();

                        usuario.Rol.IdRol = int.Parse(row[10].ToString());

                        //boxing
                        result.Object = usuarioResult;
                        result.Correct = true;

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

        public static ML.Result GetByIdSP(ML.Usuario usuario)
        {

            ML.Result result = new ML.Result();

            try
            {
                //todo lo que ejecute dentro de un using se libera al final
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "UsuarioGetById";

                    SqlCommand cmd = new SqlCommand(query, context);

                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter[] collection = new SqlParameter[1];
                    collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
                    collection[0].Value = usuario.IdUsuario;

                    cmd.Parameters.AddRange(collection);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable tablaUsuario = new DataTable();

                    adapter.Fill(tablaUsuario);


                    if (tablaUsuario.Rows.Count > 0)
                    {
                        DataRow row = tablaUsuario.Rows[0];

                        ML.Usuario usuarioResult = new ML.Usuario();

                        usuarioResult.IdUsuario = int.Parse(row[0].ToString());

                        usuarioResult.Nombre = row[1].ToString();

                        usuarioResult.ApellidoMaterno = row[2].ToString();

                        usuarioResult.ApellidoMaterno = row[3].ToString();

                        usuarioResult.FechaNacimiento = DateTime.Parse(row[4].ToString());

                        usuarioResult.Direccion = row[5].ToString();

                        usuarioResult.Correo = row[6].ToString();

                        usuarioResult.Telefono = row[7].ToString();

                        usuarioResult.EstadoCivil = row[8].ToString();

                        usuarioResult.NumeroHijos = int.Parse(row[9].ToString());

                        usuario.Rol = new ML.Rol();

                        usuario.Rol.IdRol = int.Parse(row[10].ToString());

                        //boxing
                        result.Object = usuarioResult;
                        result.Correct = true;

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

        public static ML.Result Delete(ML.Usuario usuario)
        {
            //DELETE FROM Usuario  WHERE IdUsuario = @IdUsuario
            ML.Result result = new ML.Result();

            try
            {
                //todo lo que ejecute dentro de un using se libera al final
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "DELETE FROM Usuario  WHERE IdUsuario = @IdUsuario";

                    SqlCommand cmd = new SqlCommand(query, context);

                    SqlParameter[] collection = new SqlParameter[1];
                    collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
                    collection[0].Value = usuario.IdUsuario;

                    cmd.Parameters.AddRange(collection);

                    cmd.Connection.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al eliminar al Ususario";
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

        public static ML.Result DeleteSP(ML.Usuario usuario)
        {

            //DELETE FROM Usuario  WHERE IdUsuario = @IdUsuario
            ML.Result result = new ML.Result();

            try
            {
                //todo lo que ejecute dentro de un using se libera al final
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "UsuarioDelete";

                    SqlCommand cmd = new SqlCommand(query, context);

                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter[] collection = new SqlParameter[1];
                    collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
                    collection[0].Value = usuario.IdUsuario;

                    cmd.Parameters.AddRange(collection);

                    cmd.Connection.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al eliminar al Ususario";
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

        */


        public static ML.Result AddEF(ML.Usuario usuario)
        {

            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {
                    ObjectParameter FilasAfectadas = new ObjectParameter("FilasAfectadas", typeof(int));
                    var query = context.UsuarioAdd(usuario.UserName, usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Correo, usuario.Contraseña, usuario.Sexo, usuario.Telefono, usuario.Celular, usuario.FechaNacimiento, usuario.Curp, usuario.Rol.IdRol, usuario.Direccion.Calle, usuario.Direccion.NumeroExterior, usuario.Direccion.NumeroInterior, usuario.Direccion.Colonia.IdColonia, usuario.Imagen, FilasAfectadas);

                    if (query == 2)
                    {
                        result.Correct = true;
                    }
                    else
                    {

                        result.Correct = false;
                        result.ErrorMessage = "Usuario no agregado";

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


        public static ML.Result GetAllEF(string Nombre, string ApellidoPaterno)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {

                    var query = context.UsuarioGetAll(Nombre, ApellidoPaterno).ToList();

                    result.Objects = new List<object>();

                    if (query != null)
                    {

                        foreach (var registro in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();

                            usuario.IdUsuario = registro.IdUsuario;

                            usuario.UserName = registro.UserName;

                            usuario.Nombre = registro.Nombre;

                            usuario.ApellidoPaterno = registro.ApellidoPaterno;

                            usuario.ApellidoMaterno = registro.ApellidoMaterno;

                            usuario.Correo = registro.Correo;

                            usuario.Contraseña = registro.Contraseña;

                            usuario.Sexo = registro.Sexo;

                            usuario.Telefono = registro.Telefono;

                            usuario.Celular = registro.Celular;

                            usuario.FechaNacimiento = DateTime.Parse(registro.FechaNacimiento);

                            usuario.Curp = registro.Curp;

                            usuario.Imagen = registro.Imagen;

                            usuario.Rol = new ML.Rol();

                            usuario.Rol.IdRol = registro.IdRol;

                            usuario.Rol.Nombre = registro.NombreRol;


                            usuario.Direccion = new ML.Direccion();

                            usuario.Direccion.Calle = registro.Calle;

                            usuario.Direccion.NumeroExterior = registro.NumeroExterior;

                            usuario.Direccion.NumeroInterior = registro.NumeroInterior.Value;


                            usuario.Direccion.Colonia = new ML.Colonia();

                            usuario.Direccion.Colonia.IdColonia = registro.IdColonia;

                            usuario.Direccion.Colonia.Nombre = registro.NombreColonia;


                            usuario.Direccion.Colonia.Municipio = new ML.Municipio();

                            usuario.Direccion.Colonia.Municipio.IdMunicipio = registro.IdMunicipio;

                            usuario.Direccion.Colonia.Municipio.Nombre = registro.NombreMunicipio;



                            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();

                            usuario.Direccion.Colonia.Municipio.Estado.IdEstado = registro.IdEstado;

                            usuario.Direccion.Colonia.Municipio.Estado.Nombre = registro.NombreEstado;


                            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();

                            usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais = registro.IdPais;

                            usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre = registro.NombrePais;



                            result.Objects.Add(usuario);


                        }

                        result.Correct = true;

                    }
                    else
                    {

                        result.Correct = false;
                        result.ErrorMessage = "No existe el usuario";

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


        public static ML.Result UpdateEF(ML.Usuario usuario)
        {

            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {
                    ObjectParameter FilasAfectadas = new ObjectParameter("FilasAfectadas", typeof(int));
                    var rowAffected = context.UsuarioUpdate(usuario.IdUsuario, usuario.UserName, usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Correo, usuario.Contraseña, usuario.Sexo, usuario.Telefono, usuario.Celular, usuario.FechaNacimiento, usuario.Curp, usuario.Rol.IdRol, usuario.Direccion.Calle, usuario.Direccion.NumeroExterior, usuario.Direccion.NumeroInterior, usuario.Direccion.Colonia.IdColonia, usuario.Imagen, FilasAfectadas);

                    if (rowAffected == 2)
                    {
                        result.Correct = true;
                    }
                    else
                    {

                        result.Correct = false;
                        result.ErrorMessage = "Usuario no agregado";

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


        public static ML.Result DeleteEF(int IdUsuario)
        {

            ML.Result result = new ML.Result();

            try

            {

                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {
                    ObjectParameter FilasAfectadas = new ObjectParameter("FilasAfectadas", typeof(int));
                    int rowAffected = context.UsuarioDelete(IdUsuario, FilasAfectadas);


                    if (rowAffected == 2)

                    {
                        result.Correct = true;

                    }

                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "::ERROR";
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



        public static ML.Result GetByIdEF(int IdUsuario)
        {

            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {

                    var query = context.UsuarioGetById(IdUsuario).SingleOrDefault();

                    result.Object = new List<object>();

                    if (query != null)
                    {

                        ML.Usuario usuarioResult = new ML.Usuario();

                        usuarioResult.IdUsuario = query.IdUsuario;

                        usuarioResult.UserName = query.UserName;

                        usuarioResult.Nombre = query.Nombre;

                        usuarioResult.ApellidoPaterno = query.ApellidoPaterno;

                        usuarioResult.ApellidoMaterno = query.ApellidoMaterno;

                        usuarioResult.Correo = query.Correo;

                        usuarioResult.Contraseña = query.Contraseña;

                        usuarioResult.Sexo = query.Sexo;

                        usuarioResult.Telefono = query.Telefono;

                        usuarioResult.Celular = query.Celular;

                        usuarioResult.FechaNacimiento = DateTime.Parse(query.FechaNacimiento.ToString());

                        usuarioResult.Curp = query.Curp;

                        usuarioResult.Imagen = query.Imagen;


                        usuarioResult.Rol = new ML.Rol();

                        usuarioResult.Rol.IdRol = Convert.ToInt16(query.IdRol);

                        usuarioResult.Rol.Nombre = query.NombreRol;


                        usuarioResult.Direccion = new ML.Direccion();

                        usuarioResult.Direccion.Calle = query.Calle;

                        usuarioResult.Direccion.NumeroExterior = query.NumeroExterior;

                        usuarioResult.Direccion.NumeroInterior = query.NumeroInterior.Value;


                        usuarioResult.Direccion.Colonia = new ML.Colonia();

                        usuarioResult.Direccion.Colonia.IdColonia = query.IdColonia;

                        usuarioResult.Direccion.Colonia.Nombre = query.NombreColonia;


                        usuarioResult.Direccion.Colonia.Municipio = new ML.Municipio();

                        usuarioResult.Direccion.Colonia.Municipio.IdMunicipio = query.IdMunicipio;

                        usuarioResult.Direccion.Colonia.Municipio.Nombre = query.NombreMunicipio;



                        usuarioResult.Direccion.Colonia.Municipio.Estado = new ML.Estado();

                        usuarioResult.Direccion.Colonia.Municipio.Estado.IdEstado = query.IdEstado;

                        usuarioResult.Direccion.Colonia.Municipio.Estado.Nombre = query.NombreEstado;


                        usuarioResult.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();

                        usuarioResult.Direccion.Colonia.Municipio.Estado.Pais.IdPais = query.IdPais;

                        usuarioResult.Direccion.Colonia.Municipio.Estado.Pais.Nombre = query.NombrePais;


                        result.Object = usuarioResult;


                        result.Correct = true;

                    }

                    else
                    {

                        result.Correct = false;
                        result.ErrorMessage = "No se encontro el registro del Usuario";

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


        public static ML.Result ChangeStatus(int IdUsuario, bool Status)
        {

            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {
                    var rowsAffetted = context.UsuarioChangeStatus(IdUsuario, Status);

                    if (rowsAffetted > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
            }
            return result;
        }


        public static ML.Result UsuarioDrop() 
        {

            ML.Result resultUsuario = new ML.Result();

            try
            {
                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {

                    var query = context.UsuarioDropList().ToList();

                    resultUsuario.Objects = new List<object>();

                    if (query != null)
                    {

                        foreach (var registro in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();

                            usuario.IdUsuario = registro.IdUsuario;

                            usuario.Nombre = registro.Nombre;

                            resultUsuario.Objects.Add(usuario);


                        }

                        resultUsuario.Correct = true;

                    }
                    else
                    {

                        resultUsuario.Correct = false;
                        resultUsuario.ErrorMessage = ":::ERROR::";

                    }
                }

            }
            catch (Exception ex)
            {


                resultUsuario.Correct = false;
                resultUsuario.ErrorMessage = ex.Message;
                resultUsuario.Ex = ex;

            }

            return resultUsuario;



        }

        public static ML.Result GetByEmail(string Correo)
        {
            ML.Result result = new ML.Result();

            try
            {

                using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                {

                    var query = context.GetByEmail(Correo).FirstOrDefault();

                    result.Object = new List<object>();

                    if (query != null)
                    {

                        ML.Usuario usuario = new ML.Usuario();
                        usuario.Correo = query.Correo;
                        usuario.Contraseña = query.Contraseña;

                        result.Object = usuario;

                        result.Correct = true;


                    }

                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontraron registros";

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

        public static ML.Result LeerExcel(string connectionString) 
        {

            ML.Result result = new ML.Result();
            
            try
            {
                using (OleDbConnection context = new OleDbConnection(connectionString))
                {
                    string query = "SELECT * FROM [Sheet1$]";
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;
                        OleDbDataAdapter da = new OleDbDataAdapter();
                        da.SelectCommand = cmd;

                        DataTable tableUsuario = new DataTable();
                        da.Fill(tableUsuario);

                        if(tableUsuario.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();

                            foreach(DataRow row in tableUsuario.Rows)
                            {
                                ML.Usuario usuario = new ML.Usuario();

                                usuario.UserName = row[0].ToString();
                                usuario.Nombre = row[1].ToString(); 
                                usuario.ApellidoPaterno = row[2].ToString();
                                usuario.ApellidoMaterno = row[3].ToString();
                                usuario.Correo = row[4].ToString();
                                usuario.Contraseña = row[5].ToString();
                                usuario.Sexo = row[6].ToString();
                                usuario.Telefono = row[7].ToString();
                                usuario.Celular = row[8].ToString();
                                usuario.FechaNacimiento = Convert.ToDateTime(row[9]);
                                usuario.Curp = row[10].ToString();
                                usuario.Rol = new ML.Rol();
                                usuario.Rol.IdRol = Convert.ToInt32(row[11]);
                                usuario.Direccion = new ML.Direccion();
                                usuario.Direccion.Calle = row[12].ToString();
                                usuario.Direccion.NumeroExterior = Convert.ToInt32(row[13]);    
                                usuario.Direccion.NumeroInterior = Convert.ToInt32(row[14]);    
                                usuario.Direccion.Colonia = new ML.Colonia();
                                usuario.Direccion.Colonia.IdColonia = Convert.ToInt32(row[15]);
                                usuario.Imagen = row[16].ToString();
                                result.Objects.Add(usuario);

                            }
                            result.Correct = true;
                        }

                        result.Object = tableUsuario;
                        if (tableUsuario.Rows.Count > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMessage = "No existen registros en el excel";
                        }
                    }
                }

            }
            catch(Exception ex) 
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;   

            }

            return result;  
        }


        public static ML.Result ValidarExcel(List<Object> usuarios)
        {
            ML.Result result = new ML.Result();
            try
            {

                result.Objects = new List<Object>();//Almacena los registros incompletos
                int i = 1;//Guarda el numero de la fila
                foreach (ML.Usuario usuario in usuarios)
                {
                    ML.ErrorExcel error = new ML.ErrorExcel();
                    error.IdRegistro = i++;

                    if (usuario.UserName == "")
                    {
                        error.Mensaje += "Ingresar el User Name ";
                    }
                    if (usuario.Nombre == "")
                    {
                        error.Mensaje += "Ingresar el Nombre ";
                    }
                    if (usuario.ApellidoPaterno == "")
                    {
                        error.Mensaje += "Ingresar el Apellido Paterno ";
                    }
                    if (usuario.ApellidoMaterno == "")
                    {
                        error.Mensaje += "Ingresar el Apellido Materno ";
                    }
                    if (usuario.Correo == "")
                    {
                        error.Mensaje += "Ingresar el Correo ";
                    }
                    if (usuario.Contraseña == "")
                    {
                        error.Mensaje += "Ingresar la Contraseña ";
                    }
                    if (usuario.Sexo == "")
                    {
                        error.Mensaje += "Ingresar el Sexo ";
                    }
                    if (usuario.Telefono == "")
                    {
                        error.Mensaje += "Ingresar el Telefono ";
                    }
                    if (usuario.Celular == "")
                    {
                        error.Mensaje += "Ingresar el Celular ";
                    }
                    if (usuario.FechaNacimiento == null)
                    {
                        error.Mensaje += "Ingresar la Fecha de Nacimiento ";
                    }
                    if (usuario.Curp == "")
                    {
                        error.Mensaje += "Ingresar el Curp ";
                    }
                    if (usuario.Rol.IdRol == 0)
                    {
                        error.Mensaje += "Ingresar el Id Rol ";
                    }
                    if (usuario.Direccion.Calle == "")
                    {
                        error.Mensaje += "Ingresar la Calle ";
                    }
                    if (usuario.Direccion.NumeroExterior == 0)
                    {
                        error.Mensaje += "Ingresar el Numero Exterior ";
                    }
                    if (usuario.Direccion.NumeroInterior == 0)
                    {
                        error.Mensaje += "Ingresar el Numero Interior ";
                    }
                    if (usuario.Direccion.Colonia.IdColonia == 0)
                    {
                        error.Mensaje += "Ingresar el Id Colonia ";
                    }
                    if (error.Mensaje != null)
                    {

                        result.Objects.Add(error);
                    }

                }

                result.Correct = true;
            }
            catch(Exception ex)
            {
                result.Correct = false; 
                result.ErrorMessage = ex.Message;
            }

            return result;  
        }

        /*  public static ML.Result AddLINQ(ML.Usuario usuario)
          {

              ML.Result result = new ML.Result();

              try
              {
                  using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                  {

                      DLEF.Usuario usuarioEntity = new DLEF.Usuario();
                      usuarioEntity.Nombre = usuario.Nombre;
                      usuarioEntity.ApellidoPaterno = usuario.ApellidoPaterno;
                      usuarioEntity.ApellidoMaterno = usuario.ApellidoMaterno;
                      usuario.FechaNacimiento = DateTime.Parse(usuario.FechaNacimiento.ToString());
                      usuarioEntity.Direccion = usuario.Direccion;
                      usuarioEntity.Correo = usuario.Correo;
                      usuarioEntity.Telefono = usuario.Telefono;
                      usuarioEntity.EstadoCivil = usuario.EstadoCivil;
                      usuarioEntity.NumeroHijos = usuario.NumeroHijos;

                      context.Usuarios.Add(usuarioEntity);
                      int rowsAffected = context.SaveChanges();

                      if (rowsAffected > 0)
                      {
                          result.Correct = true;

                      }

                      else
                      {

                          result.Correct = false;
                          result.ErrorMessage = "::ERROR";
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



          public static ML.Result GetAllLINQ()
          {

              ML.Result result = new ML.Result();

              try
              {

                  using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                  {

                      var query = (from Users in context.Usuarios
                                   join Rols in context.Rols on Users.IdRol equals Rols.IdRol
                                   select new
                                   {
                                       IdUsuario = Users.IdUsuario,
                                       Nombre = Users.Nombre,
                                       ApellidoPaterno = Users.ApellidoPaterno,
                                       ApellidoMaterno = Users.ApellidoMaterno,
                                       FechaNacimiento = Users.FechaNacimiento,
                                       Direccion = Users.Direccion,
                                       Correo = Users.Correo,
                                       Telefono = Users.Telefono,
                                       EstadoCivil = Users.EstadoCivil,
                                       NumeroHijos = Users.NumeroHijos,
                                       IdRol = Users.IdRol,
                                       NombreRol = Rols.Nombre


                                   });
                      if (query != null)

                      {
                          result.Objects = new List<object>();
                          foreach (var registro in query)
                          {
                              ML.Usuario usuario = new ML.Usuario();

                              usuario.Nombre = registro.Nombre;

                              usuario.ApellidoPaterno = registro.ApellidoPaterno;

                              usuario.ApellidoMaterno = registro.ApellidoMaterno;

                              usuario.FechaNacimiento = DateTime.Parse(registro.FechaNacimiento);

                              usuario.Direccion = registro.Direccion;

                              usuario.Correo = registro.Correo;

                              usuario.Telefono = registro.Telefono;

                              usuario.EstadoCivil = registro.EstadoCivil;

                              usuario.NumeroHijos = Convert.ToInt16(registro.NumeroHijos);

                              usuario.Rol = new ML.Rol();

                              usuario.Rol.IdRol = Convert.ToInt16(registro.IdRol);

                              result.Objects.Add(usuario);


                          }

                          result.Correct = true;


                      }

                      else 
                      { 
                      result.Correct = false;
                      result.ErrorMessage = "::ERROR::";

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


          public static ML.Result UpdateLINQ( ML.Usuario usuario )
          {
              ML.Result result = new ML.Result();

              try
              {
                  using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                  {

                      var query = (from Users in context.Usuarios
                                   where Users.IdUsuario == Users.IdUsuario
                                   select Users).SingleOrDefault();

                      if (query !=null)
                      {



                          query.Nombre = usuario.Nombre;
                          query.ApellidoPaterno = usuario.ApellidoPaterno;
                          query.ApellidoMaterno = usuario.ApellidoMaterno;
                          query.FechaNacimiento = DateTime.Parse(usuario.FechaNacimiento.ToString();
                          query.Direccion = usuario.Direccion;
                          query.Correo = usuario.Correo;
                          query.Telefono = usuario.Telefono;  
                          query.EstadoCivil = usuario.EstadoCivil;
                          query.NumeroHijos = usuario.NumeroHijos;



                          result.Correct = true;

                      }

                      else
                      {

                          result.Correct = false;
                          result.ErrorMessage = "::ERROR::NO SE ENCONTRO EL GRUPO::";
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



          public static ML.Result DeleteLINQ( ML.Usuario usuario)
          {
              ML.Result result = new ML.Result();

              try
              {
                  using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                  {

                      var query = (from Users in context.Usuarios
                                   where Users.IdUsuario == Users.IdUsuario
                                   select Users).First();



                      context.Usuarios.Remove(query);
                      context.SaveChanges();
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

          public static ML.Result GetByIdLINQ( ML.Usuario usuario) 

          {

              ML.Result result = new ML.Result();

              try
              {

                  using (DLEF.NCastilloProgramacionNCapasEntities context = new DLEF.NCastilloProgramacionNCapasEntities())
                  {

                      var query = (from Users in context.Usuarios
                                   join Rols in context.Rols on Users.IdRol equals Rols.IdRol
                                   where Users.IdUsuario == Users.IdUsuario
                                   select new
                                   {
                                       IdUsuario = Users.IdUsuario,
                                       Nombre = Users.Nombre,
                                       ApellidoPaterno = Users.ApellidoPaterno,
                                       ApellidoMaterno = Users.ApellidoMaterno,
                                       FechaNacimiento = Users.FechaNacimiento,
                                       Direccion = Users.Direccion,
                                       Correo = Users.Correo,
                                       Telefono = Users.Telefono,
                                       EstadoCivil = Users.EstadoCivil,
                                       NumeroHijos = Users.NumeroHijos,
                                       IdRol = Users.IdRol,
                                       NombreRol = Rols.Nombre


                                   });
                      if (query != null)

                      {
                          result.Objects = new List<object>();
                          foreach (var registro in query)
                          {
                              ML.Usuario resgistro = new ML.Usuario();

                              usuario.Nombre = registro.Nombre;

                              usuario.ApellidoPaterno = registro.ApellidoPaterno;

                              usuario.ApellidoMaterno = registro.ApellidoMaterno;

                              usuario.FechaNacimiento = DateTime.Parse(registro.FechaNacimiento);

                              usuario.Direccion = registro.Direccion;

                              usuario.Correo = registro.Correo;

                              usuario.Telefono = registro.Telefono;

                              usuario.EstadoCivil = registro.EstadoCivil;

                              usuario.NumeroHijos = Convert.ToInt16(registro.NumeroHijos);

                              usuario.Rol = new ML.Rol();

                              usuario.Rol.IdRol = Convert.ToInt16(registro.IdRol);

                              result.Objects.Add(usuario);


                          }

                          result.Correct = true;


                      }

                      else
                      {
                          result.Correct = false;
                          result.ErrorMessage = "::ERROR::";

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


          }*/




    }
            


           

            }

        


        


    





       



    

        


    


        
    

    










