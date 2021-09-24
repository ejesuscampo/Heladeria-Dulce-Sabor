using System;
using System.IO;

namespace Heladeria_Dulce_Sabor
{

    class Program
    {

        static void Main(string[] args)
        {
            //int seleccion;
            //String vendedor;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.SetCursorPosition(15, 8); Console.Write("                                    BIENVENIDO A HELADERIA  :)                            ");
            Console.SetCursorPosition(15, 9); Console.Write(" ______   __   __  ___      _______  _______    _______  _______  _______  _______  ______");
            Console.SetCursorPosition(15, 10); Console.Write("|      | |  | |  ||   |    |       ||       |  |       ||   _   ||  _    ||       ||    _ |");
            Console.SetCursorPosition(15, 11); Console.Write("|  _    ||  | |  ||   |    |       ||    ___|  |  _____||  |_|  || |_|   ||   _   ||   | ||");
            Console.SetCursorPosition(15, 12); Console.Write("| | |   ||  |_|  ||   |    |       ||   |___   | |_____ |       ||       ||  | |  ||   |_||_ ");
            Console.SetCursorPosition(15, 13); Console.Write("| |_|   ||       ||   |___ |      _||    ___|  |_____  ||       ||  _   | |  |_|  ||    __  |");
            Console.SetCursorPosition(15, 14); Console.Write("|       ||       ||       ||     |_ |   |___    _____| ||   _   || |_|   ||       ||   |  | |");
            Console.SetCursorPosition(15, 15); Console.Write("| ______||_______||_______||_______||_______|  |_______||__| |__||_______||_______||___|  |_|");

            //do
            //{
            //    Console.SetCursorPosition(15, 18); Console.Write("            1. Johana Avila que peina              " + "    2. Daniel Rodriguez    ");

            //    Console.SetCursorPosition(15, 20); Console.Write("                            SELECCIONE EL VENDEDOR: "); ;
            //    seleccion = int.Parse(Console.ReadLine());

            //    Console.SetCursorPosition(15, 22); Console.Write("------------------------------------------------------");

            //    if (seleccion == 1)
            //    {
            //        Console.SetCursorPosition(15, 24); Console.Write("Johana Avila que peina: BIENVENIDA");
            //        vendedor = "Johana Avila que peina";
            //    }
            //    else if (seleccion == 2)
            //    {
            //        Console.SetCursorPosition(15, 24); Console.Write("Daniel Rodriguez: BIENVENIDO");
            //        vendedor = "Daniel Rdodriguez";
            //    }
            //    else
            //    {
            //        Console.SetCursorPosition(15, 24); Console.Write("VALOR INCORRECTO");
            //    }

            //} while (seleccion != 1 && seleccion != 2);
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
            Console.SetCursorPosition(15, 6); Console.WriteLine("------------------------------------------------------");
        }

        static public void Menu()
        {
            int Op = 0;
            do
            {
                Titulo();

                Console.SetCursorPosition(15, 8); Console.Write("1. REGISTRAR");
                Console.SetCursorPosition(15, 9); Console.Write("2. CONSULTAR VENTAS");
                Console.SetCursorPosition(15, 10); Console.Write("3. ACTUALIZAR");
                Console.SetCursorPosition(15, 11); Console.Write("4. ELIMINAR");
                Console.SetCursorPosition(15, 12); Console.Write("5. SALIR");


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
                    Consultar();
                }
                else if (Op == 3)
                {
                    Console.Clear();
                    Actualizar();
                }
                else if (Op == 4)
                {
                    Console.Clear();
                    Eliminar();
                }
                else
                {
                    Console.SetCursorPosition(40, 16); Console.WriteLine("MUCHAS GRACIA. ADIOS :)");
                    Environment.Exit(1);
                }

            } while (Op != 5);

        }

        static private void Registrar()
        {
            String identificacion, nombre;
            int tipoHelado, selecToppings;
            double valor = 0, totalHelado = 0;
            String topping = "", presentacionHelado = "";

            Titulo();

            Console.SetCursorPosition(15, 7); Console.Write("DIGITE SU CEDULA: ");
            identificacion = Console.ReadLine();
            Console.SetCursorPosition(15, 8); Console.Write("------------------------------------------------------");

            Console.SetCursorPosition(15, 9); Console.Write("DIGITE SU NOMBRE: ");
            nombre = Console.ReadLine();
            Console.SetCursorPosition(15, 10); Console.Write("------------------------------------------------------");

            do
            {
                Console.SetCursorPosition(15, 11); Console.Write("1.CONO:2500              " + "    2.VASO:3000    ");

                Console.SetCursorPosition(15, 13); Console.Write("DIGITE EL TIPO DE HELADO: ");
                tipoHelado = int.Parse(Console.ReadLine());

                Console.SetCursorPosition(15, 14); Console.Write("------------------------------------------------------");

                if (tipoHelado == 1)
                {
                    Console.SetCursorPosition(15, 15); Console.Write("Presentacion: CONO");
                    presentacionHelado = "CONO: 2500";
                    totalHelado = 2500;
                }
                else if (tipoHelado == 2)
                {
                    Console.SetCursorPosition(15, 15); Console.Write("Presentacion: VASO");
                    presentacionHelado = "VASO: 3000";
                    totalHelado = 3000;
                }
                else
                {
                    Console.SetCursorPosition(15, 15); Console.Write("VALOR INCORRECTO");
                }

            } while (tipoHelado != 1 && tipoHelado != 2);

            Console.SetCursorPosition(15, 16); Console.Write("------------------------------------------------------");

            do
            {
                Console.SetCursorPosition(15, 17); Console.Write("1.MANI:2000         " + "   2.CHISPAS DE CHOCOLATE:3000");
                Console.SetCursorPosition(15, 19); Console.Write("           3.CHISPAS DE COLORES: 1500");

                Console.SetCursorPosition(15, 21); Console.Write("DIGITE EL TOPPING QUE DESEA AGREGAR: ");

                selecToppings = int.Parse(Console.ReadLine());

                Console.SetCursorPosition(15, 22); Console.Write("------------------------------------------------------");

                if (selecToppings == 1)
                {
                    Console.SetCursorPosition(15, 23); Console.Write("Topping: MANI");
                    topping = "MANI: 2000";
                    totalHelado = totalHelado + 2000;
                }
                else if (selecToppings == 2)
                {
                    Console.SetCursorPosition(15, 23); Console.Write("Topping: CHISPAS DE CHOCOLATE");
                    topping = "CHISPAS DE CHOCOLATE: 3000";
                    totalHelado = totalHelado + 3000;
                }
                else if (selecToppings == 3)
                {
                    Console.SetCursorPosition(15, 23); Console.WriteLine("Topping: CHISPAS DE COLORES");
                    topping = "CHISPAS DE COLORES: 1500";
                    totalHelado = totalHelado + 1500;
                }
                else
                {
                    Console.SetCursorPosition(15, 23); Console.WriteLine("VALOR INCORRECTO");
                }

            } while (selecToppings != 1 && selecToppings != 2 && selecToppings != 3);

            valor = totalHelado;

            Console.SetCursorPosition(15, 24); Console.Write("------------------------------------------------------");
            Factura factura = new Factura(identificacion, nombre, presentacionHelado, topping, valor /*vendedor*/);

            Console.SetCursorPosition(15, 26); Console.Write("-----------------    F A C T U R A    ----------------");
            Console.SetCursorPosition(15, 27); Console.Write("Cedula: " + factura.identificacion);
            Console.SetCursorPosition(15, 28); Console.Write("Nombre: " + factura.nombre);
            Console.SetCursorPosition(15, 29); Console.Write("Tipo de helado: " + factura.tipoHelado);
            Console.SetCursorPosition(15, 30); Console.Write("Toppings: " + factura.toppings);

            Console.SetCursorPosition(15, 32); Console.WriteLine($"EL PRECIO TOTAL DE SU HELADO ES DE: " + factura.valor);

            Console.SetCursorPosition(15, 34); Console.WriteLine("Presione ENTER para continuar");

            Guardar(factura);

            Console.ReadKey();
            Console.Clear();
        }

        static private void Consultar()
        {
            Titulo();
            Console.SetCursorPosition(30, 7); Console.WriteLine("VENTAS TOTALES");

            Leer();
            Console.WriteLine("                              PRESIONE ENTER PARA CONTINUAR");
            Console.ReadKey();
            Console.Clear();
        }

        static private void Actualizar()
        {
            Titulo();
            Console.WriteLine("ACTUALIZAR FACTURA");
        }

        static private void Eliminar()
        {
            Titulo();
            Console.WriteLine("ELIMINAR VENTA");
        }

        static private void Guardar(Factura factura)
        {
            string ruta = @"FacturaHelado.txt";
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{factura.identificacion};{factura.nombre};{factura.tipoHelado};{factura.toppings};{factura.valor}");
            writer.Close();
            file.Close();
        }

        static private void Leer()
        {
            string ruta = @"FacturaHelado.txt";
            try
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach (var linea in lineas) {
                    var val = linea.Split(";");
                    Console.WriteLine("               ------------------------------------------------------");
                    Console.WriteLine("               IDENTIFICACION: " + val[0]
                        + "\n               NOMBRE: " + val[1]
                        + "\n               PRESENTACION: " + val[2]
                        + "\n               TOPPING: " + val[3]
                        + "\n               VALOR: " + val[4]);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("El archivo no se puede leer");
            }
            Console.ReadKey();
        }

    }
}

class Factura
{
    public Factura(string identificacion, string nombre, String tipoHelado, String toppings, double valor/*, String vendedor*/)
    {
        this.identificacion = identificacion;
        this.nombre = nombre;
        this.tipoHelado = tipoHelado;
        this.toppings = toppings;
        this.valor = valor;
        //this.vendedor = vendedor;
    }

    public String identificacion { get; set; }
    public String nombre { get; set; }
    public String tipoHelado { get; set; }
    public String toppings { get; set; }
    public double valor { get; set; }
    //public String vendedor { get; set; }
}
