using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("Bienvenid@");
            Console.WriteLine("Ingrese la opcion que desea ejecutar: " + "\n" + 
                              "1.- Agregar Nuevo Usuario" + "\n" + 
                              "2.- Modificar un Usuario" + "\n" +
                              "3.- Eliminar un Usuario" + "\n" +
                              "4.- Consultar Todos los Usuarios" + "\n" +
                              "5.- Consultar un Usuario" + "\n" +
                              "6.- Salir del programa");

            int opcion = int.Parse(Console.ReadLine());

            switch(opcion)
            {
                case 1: PL.Usuario.Add();
                    break;
                case 2: PL.Usuario.Update();
                    break;
                case 3: PL.Usuario.Delete();
                    break;
                case 4: PL.Usuario.GetAll();
                    break;
                case 5: PL.Usuario.GetById();  
                    break;
                case 6: Console.WriteLine("Programa Finalizado");
                    break;  
                default: Console.WriteLine("Opcion invalida");
                    break;  

            }

            Console.ReadKey();


            */

            PL.Usuario.CargaMasivaTxt();
            Console.ReadKey();


        }

            
    }
}
