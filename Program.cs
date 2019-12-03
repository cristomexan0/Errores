using System;

namespace Errores
{


    class Program
    {
        static void Main()
        {
            int valor;
            Console.WriteLine("Ingresa tu edad");
            string captura = Console.ReadLine();
            valor = int.Parse(captura);
            Console.WriteLine("En diez años tendras {0}", 100/valor  );
            Console.ReadKey();

            //Console.WriteLine(captura);
            //Todo esto es por si damos un valor que no se pueda dividir entre 100 o es un digito incorrecto

            try
            {
                {
                    string captura = Console.ReadLine();
                    int valor = int.Parse(captura);
                    //se ejecutara si solo hay excepsion o sea la formayException
                    Console.WriteLine(valor);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato incorrecto");
            }
            Console.ReadKey();
        }
    }
}
