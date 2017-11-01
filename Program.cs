using System;
using System.Collections.Generic;

namespace CuentaBancaria
{
    class Program
    {
        static void MostrarMenu()
        {
            Console.WriteLine("Que desea realizar");
            Console.WriteLine("1- Creacion de Cuentas");
            Console.WriteLine("2- Agregar un Titular a la Cuenta");
            Console.WriteLine("3- Consulta de Saldo en Cuentas");
            Console.WriteLine("4- Realizar Movimientos de Dinero");
            Console.WriteLine("0- Salir del Menu");
        }

        static void CrearCuenta( int ndeCuenta, string titular)
        {
           
        }
        static void ObtenerDastosTitular()
        {
            Console.WriteLine("Nombre del Titular?");
            Console.ReadLine();
        }
        static void CrearTitular()
        {

        }

        static int ValidarEdad(DateTime nacimiento)
        {
            DateTime ahora = DateTime.Now;
            int edad = ahora.Year - nacimiento.Year;

            if (ahora.Month < nacimiento.Month
                || (ahora.Month == nacimiento.Month
                    && ahora.Day < nacimiento.Day))
                edad--;

            return edad;
        }
        static void Main(string[] args)
        {
            List<Cuenta> CuentasDelBanco = new List<Cuenta>();

            Console.WriteLine("Bienvenido al Banco ECorp!");
            MostrarMenu();

            int.TryParse(Console.ReadLine(), out int opcion);

            while (opcion != 0)
            {
                switch (opcion)
                {
                    case 1:
                        int nCuenta = CuentasDelBanco.Count;
                        

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 0:
                        break;
                    default:
                        MostrarMenu();
                        int.TryParse(Console.ReadLine(), out opcion);
                        break;    
                }
            }
            MostrarMenu();
        }
    }
}
