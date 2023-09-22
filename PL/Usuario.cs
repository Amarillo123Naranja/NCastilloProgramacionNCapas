using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Usuario
    {
        /*   public static void Add()
           {


               ML.Usuario usuario = new ML.Usuario();

               Console.WriteLine("Ingresa el UserName del nuevo usuario");
               usuario.UserName = Console.ReadLine();
               Console.WriteLine("Ingresa el nombre del nuevo usuario");
               usuario.Nombre = Console.ReadLine();
               Console.WriteLine("Ingresa el apellido paterno del nuevo usuario");
               usuario.ApellidoPaterno = Console.ReadLine();
               Console.WriteLine("Ingresa el apellido materno del nuevo usuario");
               usuario.ApellidoMaterno = Console.ReadLine();
               Console.WriteLine("Ingresa el Correo del nuevo usuario");
               usuario.Correo = Console.ReadLine();
               Console.WriteLine("Ingrese la contraseña del nuevo usuario");
               usuario.Contraseña = Console.ReadLine();    
               Console.WriteLine("Ingrese el sexo del nuevo usuario");
               usuario.Sexo = Console.ReadLine();
               Console.WriteLine("Ingresa el telefono del nuevo usuario");
               usuario.Telefono = Console.ReadLine();
               Console.WriteLine("Ingresa el celular del nuevo usuario");
               usuario.Celular = Console.ReadLine();   
               Console.WriteLine("Ingresa la fecha de nacimiento del nuevo usuario");
               usuario.FechaNacimiento = DateTime.Parse(Console.ReadLine());
               Console.WriteLine("Ingese el curp del nuevo usuario");
               usuario.Curp = Console.ReadLine();
               usuario.Rol = new ML.Rol();
               Console.WriteLine("Ingese el rol del nuevo usuario");
               usuario.Rol.IdRol = Convert.ToInt16(Console.ReadLine());

               ML.Result result = BL.Usuario.AddEF(usuario);

               if (result.Correct)
               {

                   Console.WriteLine("Usuario AGREGADO exitosamente");

               }
               else
               {

                   Console.WriteLine("Usuario NO agregado " + result.ErrorMessage);
               }
           }




           public static void Update()
           {

               ML.Usuario usuario = new ML.Usuario();

               Console.WriteLine("ingresa el Id del usuario a editar");
               usuario.IdUsuario = int.Parse(Console.ReadLine());
               Console.WriteLine("Ingresa el UserName del nuevo usuario");
               usuario.UserName = Console.ReadLine();
               Console.WriteLine("Ingresa el nombre del nuevo usuario");
               usuario.Nombre = Console.ReadLine();
               Console.WriteLine("Ingresa el apellido paterno del nuevo usuario");
               usuario.ApellidoPaterno = Console.ReadLine();
               Console.WriteLine("Ingresa el apellido materno del nuevo usuario");
               usuario.ApellidoMaterno = Console.ReadLine();
               Console.WriteLine("Ingresa el Correo del nuevo usuario");
               usuario.Correo = Console.ReadLine();
               Console.WriteLine("Ingrese la contraseña del nuevo usuario");
               usuario.Contraseña = Console.ReadLine();
               Console.WriteLine("Ingrese el sexo del nuevo usuario");
               usuario.Sexo = Console.ReadLine();
               Console.WriteLine("Ingresa el telefono del nuevo usuario");
               usuario.Telefono = Console.ReadLine();
               Console.WriteLine("Ingresa el celular del nuevo usuario");
               usuario.Celular = Console.ReadLine();
               Console.WriteLine("Ingresa la fecha de nacimiento del nuevo usuario");
               usuario.FechaNacimiento = DateTime.Parse(Console.ReadLine());
               Console.WriteLine("Ingese el curp del nuevo usuario");
               usuario.Curp = Console.ReadLine();
               usuario.Rol = new ML.Rol();
               Console.WriteLine("Ingese el rol del nuevo usuario");
               usuario.Rol.IdRol = Convert.ToInt32((Console.ReadLine()));

               ML.Result result = BL.Usuario.UpdateEF(usuario);

               if (result.Correct)
               {
                   Console.WriteLine("Usuario actualizado EXITOSAMENTE");
               }
               else
               {
                   Console.WriteLine("El usuario NO FUE ACTUALIZADO" + result.ErrorMessage);
               }


           }

           */


        /* public static void Delete()



           {

               ML.Usuario usuario = new ML.Usuario();

               Console.WriteLine("ingresa el Id del usuario a eliminar");
               usuario.IdUsuario = int.Parse(Console.ReadLine());


               ML.Result result = BL.Usuario.DeleteEF(usuario);

               if (result.Correct == true)
               {
                   Console.WriteLine("Usuario ELIMINADO EXITOSAMENTE");

               }
               else
               {
                   Console.WriteLine("ERROR al eliminar el Usuario" + result.ErrorMessage);
               }


           }




           public static void GetAll()
           {
               ML.Result result = BL.Usuario.GetAllEF();
               if (result.Correct == true)
               {
                   foreach (ML.Usuario usuario in result.Objects)
                   {

                       Console.WriteLine("-------------------------------");
                       Console.WriteLine("ID Usuario: " + usuario.IdUsuario);
                       Console.WriteLine("User Name: " + usuario.UserName);
                       Console.WriteLine("Nombre: " + usuario.Nombre);
                       Console.WriteLine("Apellido Paterno: " + usuario.ApellidoPaterno);
                       Console.WriteLine("Apellido Materno: " + usuario.ApellidoMaterno);
                       Console.WriteLine("Correo: " + usuario.Correo);
                       Console.WriteLine("Contraseña: " + usuario.Contraseña);
                       Console.WriteLine("Sexo: " + usuario.Sexo);
                       Console.WriteLine("Telefono: " + usuario.Telefono);
                       Console.WriteLine("Celular: " + usuario.Celular);
                       Console.WriteLine("Fecha de Nacimiento: " + usuario.FechaNacimiento);
                       Console.WriteLine("Curp: " + usuario.Curp);
                       Console.WriteLine("Id Rol: " + usuario.Rol.IdRol);
                       Console.WriteLine("Nombre Rol: " + usuario.Rol.Nombre);    
                       Console.WriteLine("-------------------------------");

                   }


               }
               else
               {
                   Console.WriteLine("::ERROR::" + result.ErrorMessage);
               }
           }





           public static void GetById()
           {

               ML.Usuario usuario = new ML.Usuario();
               Console.WriteLine("Ingrese el Id del usuario a consultar");
               usuario.IdUsuario = int.Parse(Console.ReadLine());

               ML.Result result = BL.Usuario.GetByIdEF(usuario);
               if (result.Correct == true)
               {
                   //Unboxing
                   usuario = (ML.Usuario)result.Object;   
                   Console.WriteLine("-------------------------------");
                   Console.WriteLine("ID Usuario: " + usuario.IdUsuario);
                   Console.WriteLine("User Name: " + usuario.UserName);
                   Console.WriteLine("Nombre: " + usuario.Nombre);
                   Console.WriteLine("Apellido Paterno: " + usuario.ApellidoPaterno);
                   Console.WriteLine("Apellido Materno: " + usuario.ApellidoMaterno);
                   Console.WriteLine("Correo: " + usuario.Correo);
                   Console.WriteLine("Contraseña: " + usuario.Contraseña);
                   Console.WriteLine("Sexo: " + usuario.Sexo);
                   Console.WriteLine("Telefono: " + usuario.Telefono);
                   Console.WriteLine("Celular: " + usuario.Celular);
                   Console.WriteLine("Fecha de Nacimiento: " + usuario.FechaNacimiento);
                   Console.WriteLine("Curp: " + usuario.Curp);
                   Console.WriteLine("ID Rol: " + usuario.Rol.IdRol);
                   Console.WriteLine("Nombre Rol: " + usuario.Rol.Nombre);
                   Console.WriteLine("-------------------------------");

               }
               else
               {
                   Console.WriteLine("::ERROR::" + result.ErrorMessage);
               }




           }
        */


        public static void CargaMasivaTxt()
        {
            string file = @"C:\Users\digis\Desktop\Nelly Sanchez\NCastilloProgramacionNCapas\PL_MVC\File\CargaMasivaUsuario.txt";

            if (File.Exists(file))
            {
                StreamReader streamReader = new StreamReader(file);

                string line = streamReader.ReadLine(); //SALTAR HEDEARS

                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] row = line.Split('|');
                    ML.Usuario usuario = new ML.Usuario();
                    usuario.UserName = row[0];
                    usuario.Nombre = row[1];
                    usuario.ApellidoPaterno = row[2];
                    usuario.ApellidoMaterno = row[3];
                    usuario.Correo = row[4];
                    usuario.Contraseña = row[5];
                    usuario.Sexo = row[6];
                    usuario.Telefono = row[7];
                    usuario.Celular = row[8];
                    usuario.FechaNacimiento = Convert.ToDateTime(row[9]);
                    usuario.Curp = row[10];
                    usuario.Rol = new ML.Rol();
                    usuario.Rol.IdRol = Convert.ToInt32(row[11]);
                    usuario.Direccion = new ML.Direccion();
                    usuario.Direccion.Calle = row[13];
                    usuario.Direccion.NumeroExterior = Convert.ToInt32(row[14]);
                    usuario.Direccion.NumeroInterior = Convert.ToInt32(row[15]);
                    usuario.Direccion.Colonia = new ML.Colonia();
                    usuario.Direccion.Colonia.IdColonia = Convert.ToInt32(row[16]);
                    usuario.Imagen = row[17];
                }
            }

        }

        }
    }
