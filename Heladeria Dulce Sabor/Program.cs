using System;

namespace Heladeria_Dulce_Sabor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(15, 8); Console.WriteLine("                                    BIENVENIDO A HELADERIA  :)                            ");
            Console.SetCursorPosition(15, 9); Console.WriteLine(" ______   __   __  ___      _______  _______    _______  _______  _______  _______  ______");
            Console.SetCursorPosition(15, 10); Console.WriteLine("|      | |  | |  ||   |    |       ||       |  |       ||   _   ||  _    ||       ||    _ |");
            Console.SetCursorPosition(15, 11); Console.WriteLine("|  _    ||  | |  ||   |    |       ||    ___|  |  _____||  |_|  || |_|   ||   _   ||   | ||");
            Console.SetCursorPosition(15, 12); Console.WriteLine("| | |   ||  |_|  ||   |    |       ||   |___   | |_____ |       ||       ||  | |  ||   |_||_ ");
            Console.SetCursorPosition(15, 13); Console.WriteLine("| |_|   ||       ||   |___ |      _||    ___|  |_____  ||       ||  _   | |  |_|  ||    __  |");
            Console.SetCursorPosition(15, 14); Console.WriteLine("|       ||       ||       ||     |_ |   |___    _____| ||   _   || |_|   ||       ||   |  | |");
            Console.SetCursorPosition(15, 15); Console.WriteLine("| ______||_______||_______||_______||_______|  |_______||__| |__||_______||_______||___|  |_|");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        static public void Titulo()
        {
            Console.SetCursorPosition(15, 1); Console.WriteLine("                     HELADERIA                        ");
            Console.SetCursorPosition(15, 2); Console.WriteLine(" ____        _              _____       _             ");
            Console.SetCursorPosition(15, 3); Console.WriteLine("|    |  _ _ | | ___  ___   |   __| ___ | |_  ___  ___ ");
            Console.SetCursorPosition(15, 4); Console.WriteLine("|  |  || | || ||  _|| -_|  |__   || .'|| . || . ||  _|");
            Console.SetCursorPosition(15, 5); Console.WriteLine("|____/ |___||_||___||___|  |_____||__,||___||___||_|  ");
            Console.SetCursorPosition(15, 6); Console.WriteLine("-------------------------------------------------------");
        }

        static public void Menu()
        {
            //Console.BackgroundColor = ConsoleColor.Yellow;
            //Console.ForegroundColor = ConsoleColor.Black;
            int Op = 0;
            do
            {


                Titulo();

                Console.SetCursorPosition(15, 8); Console.WriteLine("1. REGISTRAR");
                Console.SetCursorPosition(15, 9); Console.WriteLine("2. CONSULTAR VENTAS");
                Console.SetCursorPosition(15, 10); Console.WriteLine("3. ACTUALIZAR");
                Console.SetCursorPosition(15, 11); Console.WriteLine("4. ELIMINAR");
                Console.SetCursorPosition(15, 12); Console.WriteLine("5. SALIR");


                Console.SetCursorPosition(15, 14); Console.Write("DIGITE LA OPCION QUE DESEE: ");

                Op = int.Parse(Console.ReadLine());

                if (Op == 1)
                {
                    Console.Clear();
                    Registrar();
                }
                else if (Op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("AQUI VA LA OPCION DE CONSULTAR");
                }
                else if (Op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("AQUI VA LA OPCION DE ACTUALIZAR");
                }
                else if (Op == 4)
                {
                    Console.Clear();
                    Console.WriteLine("AQUI VA LA OPCION DE ELIMINAR");
                }
                else
                {
                    Console.WriteLine("MUCHAS GRACIA. ADIOS :)");
                    Environment.Exit(1);
                }

            } while (Op != 5);

        }

        static private void Registrar()
        {
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.Black;
            String cc;
            String nombre;
            int tipoHelado, toppings;
            double precio;
            double totalHelado = 0;
            Titulo();

            Console.SetCursorPosition(15, 8); Console.Write("DIGITE SU CEDULA: ");
            cc = Console.ReadLine();
            Console.SetCursorPosition(15, 9); Console.WriteLine("------------------------------------------");
            Console.SetCursorPosition(15, 10); Console.Write("DIGITE SU NOMBRE: ");
            nombre = Console.ReadLine();
            Console.SetCursorPosition(15, 11); Console.WriteLine("------------------------------------------");

            do
            {
                Console.WriteLine("1.CONO:2500\n2.VASO:3000\n");
                Console.SetCursorPosition(15, 12); Console.Write("DIGITE EL TIPO DE HELADO: ");
                tipoHelado = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(15, 13); Console.WriteLine("------------------------------------------");

                if (tipoHelado == 1)
                {
                    Console.WriteLine("CONO");
                    totalHelado = 2500;
                }
                else if (tipoHelado == 2)
                {
                    Console.WriteLine("VASO");
                    totalHelado = 3000;
                }
                else
                {
                    Console.WriteLine("VALOR INCORRECTO");
                }

            } while (tipoHelado != 1 && tipoHelado != 2);

            Console.WriteLine("------------------------------------------");

            do
            {
                Console.WriteLine("1.MANI:2000\n2.CHISPAS DE CHOCOLATE:3000\n3.CHISPAS DE COLORES:1500\n");
                Console.Write("DIGITE SUS TOPPINGS: ");
                toppings = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------");

                if (toppings == 1)
                {
                    Console.WriteLine("MANI");
                    totalHelado = totalHelado + 2000;
                }
                else if (toppings == 2)
                {
                    Console.WriteLine("CHISPAS DE CHOCOLATE");
                    totalHelado = totalHelado + 3000;
                }
                else if (toppings == 3)
                {
                    Console.WriteLine("CHISPAS DE COLORES");
                    totalHelado = totalHelado + 1500;
                }
                else
                {
                    Console.WriteLine("VALOR INCORRECTO");
                }

            } while (toppings != 1 && toppings != 2 && toppings != 3);
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
