using System;

namespace Heladeria_Dulce_Sabor
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        static public void menu(){
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
                    registrar();
                } else if(Op == 2){
                    Console.Clear();
                    Console.WriteLine("AQUI VA LA OPCION DE CONSULTAR");
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

        static private void registrar() {
            //Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            String cc;
            String nombre;
            int tipoHelado, toppings;
            double precio;
            double totalHelado=0;
            Console.WriteLine("------------------------------------------");
            Console.Write("DIGITE SU CEDULA: ");
            cc = Console.ReadLine();
            Console.WriteLine("------------------------------------------");
            Console.Write("DIGITE SU NOMBRE: ");
            nombre = Console.ReadLine();
            Console.WriteLine("------------------------------------------");
            do
            {
            Console.WriteLine("1.CONO:2500\n2.VASO:3000\n");
            Console.Write("DIGITE EL TIPO DE HELADO: ");
            tipoHelado = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------");

                if (tipoHelado == 1) {
                    Console.WriteLine("CONO");
                    totalHelado = 2500;
                } else if (tipoHelado == 2) {
                    Console.WriteLine("VASO");
                    totalHelado = 3000;
            } else {
                    Console.WriteLine("VALOR INCORRECTO");
                }
            } while (tipoHelado!=1 && tipoHelado!=2);
            Console.WriteLine("------------------------------------------");
            do
            {
            Console.WriteLine("1.MANI:2000\n2.CHISPAS DE CHOCOLATE:3000\n3.CHISPAS DE COLORES:1500\n");
            Console.Write("DIGITE SUS TOPPINGS: ");
            toppings = int.Parse(Console.ReadLine());
            
                if (toppings == 1){
                    Console.WriteLine("MANI");
                    totalHelado = totalHelado + 2000;
                }else if (toppings == 2){
                    Console.WriteLine("CHISPAS DE CHOCOLATE");
                    totalHelado = totalHelado + 3000;
                }
                else if(toppings == 3){
                    Console.WriteLine("CHISPAS DE COLORES");
                    totalHelado = totalHelado + 1500;
                }
                else{
                    Console.WriteLine("VALOR INCORRECTO");
                }
            } while (toppings!=1 && toppings!=2 && toppings != 3);
            Console.WriteLine("------------------------------------------");
            precio = totalHelado;
            Console.WriteLine($"EL PRECIO TOTAL DE SU HELADO ES DE: {precio}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("PRECIONE ENTER PARA CONTINUAR");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
