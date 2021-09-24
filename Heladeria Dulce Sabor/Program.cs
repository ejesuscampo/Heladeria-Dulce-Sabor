using System;

namespace Heladeria_Dulce_Sabor
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            int Op=0;
            do {

                Console.WriteLine("BIENVENIDO A HELADERIA DULCE SABOR :)");
                Console.WriteLine("1. REGISTRAR");
                Console.WriteLine("2. CONSULTAR VENTAS");
                Console.WriteLine("3. ACTUALIZAR");
                Console.WriteLine("4. ELIMINAR");
                Console.WriteLine("5. SALIR");
                Console.Write("DIGITE LA OPCION QUE DESEE: ");
                Op = int.Parse(Console.ReadLine());

                if (Op == 1){
                    Console.Clear();
                    Console.WriteLine("AQUI VA LA OPCION DE REGISTRAR");
                } else if(Op == 2){
                    Console.Clear();
                    Console.WriteLine("AQUI VA LA OPCION CONSULTAR");
                } else if(Op == 3){
                    Console.Clear();
                    Console.WriteLine("AQUI VA LA OPCION DE ACTUALIZAR");
                } else if(Op == 4){
                    Console.Clear();
                    Console.WriteLine("AQUI VA LA OPCION DE ELIMINAR");
                } else {
                    Console.WriteLine("MUCHAS GRACIA. ADIOS :)");
                    Environment.Exit(1);
                }
               
            } while (Op != 5 );

        }
    }
}
