using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pregunta3.Classes;

namespace Pregunta3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Escriba su nombre ");
            string nombre = Console.ReadLine();

            Console.WriteLine(" Escriba su apellido ");
            string apellido = Console.ReadLine();

            //char[] Nombre = new char[10];
            //char[] Apellido = new char[10];

            char[] Nombre = nombre.ToCharArray();
            char[] Apellido = apellido.ToCharArray();

            //if ()
            //{
            //    ExceptionNum exceptionNum = new ExceptionNum(message: string.Format(" Nombre/Apellido no valido "));
            //    throw exceptionNum;
            //}

            if (Nombre.Length >= 2)
            {
                Console.WriteLine(" Nombre/Apellido no valido ");
            }
            else
            {
                if (Apellido.Length >= 2)
                {
                    Console.WriteLine(" Nombre/Apellido no valido ");
                }
                Console.ReadKey();
            }


        }
    }
}
