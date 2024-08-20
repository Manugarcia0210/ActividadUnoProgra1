using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsuarioContraseña
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String usuario = "PROGRA1";
            String contraseña = "K0m1d4";
            int intentos = 3;

            Console.WriteLine("Tiene tres intentos para ingresar al sistema");

            while (intentos>0) 
            {
                Console.WriteLine("Ingrese nombre de usuario al sistema");
                String user = Console.ReadLine();

                Console.WriteLine("Ingrese contraseña al sistema");
                String contra = Console.ReadLine();



                if (user=="" && contra=="") 
                {
                    Console.WriteLine("El usuario o contraseña no puede estar vacio, ingrese nuevamente");
                }              

                if (user == usuario && contra == contraseña)
                {
                    Console.WriteLine("Bienvenido");                  
                    
                }

                else { 
                intentos--;
                    Console.WriteLine("Las credenciales son incorrectas, le quedan: " + intentos + " intentos" );
                    
                }              


            }                  

        }
    }
}
