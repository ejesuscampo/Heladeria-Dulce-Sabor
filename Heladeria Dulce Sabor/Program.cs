using Entidad;
using Logica;
using System;
using System.IO;

namespace Heladeria_Dulce_Sabor
{

    public class Program
    {
        private static readonly FacturaService facturaService = new FacturaService();

        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();
            Console.SetCursorPosition(15, 8); Console.Write("                                    BIENVENIDO A HELADERIA  :)                            ");
            Console.SetCursorPosition(15, 9); Console.Write(" ______   __   __  ___      _______  _______    _______  _______  _______  _______  ______");
            Console.SetCursorPosition(15, 10); Console.Write("|      | |  | |  ||   |    |       ||       |  |       ||   _   ||  _    ||       ||    _ |");
            Console.SetCursorPosition(15, 11); Console.Write("|  _    ||  | |  ||   |    |       ||    ___|  |  _____||  |_|  || |_|   ||   _   ||   | ||");
            Console.SetCursorPosition(15, 12); Console.Write("| | |   ||  |_|  ||   |    |       ||   |___   | |_____ |       ||       ||  | |  ||   |_||_ ");
            Console.SetCursorPosition(15, 13); Console.Write("| |_|   ||       ||   |___ |      _||    ___|  |_____  ||       ||  _   | |  |_|  ||    __  |");
            Console.SetCursorPosition(15, 14); Console.Write("|       ||       ||       ||     |_ |   |___    _____| ||   _   || |_|   ||       ||   |  | |");
            Console.SetCursorPosition(15, 15); Console.Write("| ______||_______||_______||_______||_______|  |_______||__| |__||_______||_______||___|  |_|");

            Console.ReadKey();
            Console.Clear();
            Menu();

        }


        static public void Titulo()
        {
            Console.Clear();
            Console.SetCursorPosition(32, 1); Console.WriteLine("                     HELADERIA                        ");
            Console.SetCursorPosition(32, 2); Console.WriteLine(" ____        _              _____       _             ");
            Console.SetCursorPosition(32, 3); Console.WriteLine("|    |  _ _ | | ___  ___   |   __| ___ | |_  ___  ___ ");
            Console.SetCursorPosition(32, 4); Console.WriteLine("|  |  || | || ||  _|| -_|  |__   || .'|| . || . ||  _|");
            Console.SetCursorPosition(32, 5); Console.WriteLine("|____/ |___||_||___||___|  |_____||__,||___||___||_|  ");
            Console.SetCursorPosition(32, 6); Console.WriteLine("------------------------------------------------------");
        }

        static public void Menu()
        {
            byte opcion = 0;

            do
            {
                Titulo();

                Console.SetCursorPosition(32, 8); Console.Write("1. REGISTRAR");
                Console.SetCursorPosition(32, 9); Console.Write("2. CONSULTAR VENTAS");
                Console.SetCursorPosition(32, 10); Console.Write("3. ACTUALIZAR");
                Console.SetCursorPosition(32, 11); Console.Write("4. ELIMINAR");
                Console.SetCursorPosition(32, 12); Console.Write("5. SALIR");


                Console.SetCursorPosition(32, 14); Console.Write("DIGITE LA OPCION QUE DESEE: ");

                opcion = Convert.ToByte(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Guardar();
                        break;

                    case 2:
                        Consultar();
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Aqui no hay na!");
                        break;

                    case 4:
                        Eliminar();
                        break;

                    case 5:
                        Console.SetCursorPosition(50, 16); Console.WriteLine("MUCHAS GRACIAS. ADIOS :)");
                        break;

                    default:
                        Console.SetCursorPosition(35, 16); Console.WriteLine("Opcion incorrecta, intente nuevamente");
                        break;
                }

            } while (opcion != 5);

        }

        private static void Guardar()
        {
            Console.Clear();
            Titulo();
            var factura = Registrar();
            string mensaje = facturaService.Guardar(factura);
            Console.WriteLine(mensaje);
        }

        static private Factura Registrar()
        {
            Factura factura
;           Random r = new Random();
            int codigoFactura = r.Next(200000, 500000);
            String identificacion, nombre;
            byte selecPresentacion, selecToppings, selecSabor;
            double valor = 0, totalHelado = 0;
            String presentacionHelado = "", saborHelado = "", toppingHelado = "";

            Titulo();

            codigoFactura.ToString();

            Console.SetCursorPosition(32, 7); Console.Write("DIGITE SU CEDULA: ");
            identificacion = Console.ReadLine();
            Console.SetCursorPosition(32, 8); Console.Write("------------------------------------------------------");

            Console.SetCursorPosition(32, 9); Console.Write("DIGITE SU NOMBRE: ");
            nombre = Console.ReadLine();
            Console.SetCursorPosition(32, 10); Console.Write("------------------------------------------------------");

            //Seleccionar la presentación del helado

            do
            {
                Console.SetCursorPosition(32, 11); Console.Write("1.CONO:2500                  " + "              2.VASO:3000");

                Console.SetCursorPosition(32, 13); Console.Write("DIGITE EL TIPO DE HELADO: ");
                selecPresentacion = byte.Parse(Console.ReadLine());
                Console.SetCursorPosition(32, 15); Console.Write("                                                      ");
                Console.SetCursorPosition(32, 14); Console.Write("------------------------------------------------------");

                if (selecPresentacion == 1)
                {
                    Console.SetCursorPosition(32, 15); Console.Write("Presentacion: CONO");
                    presentacionHelado = "CONO: 2500";
                    totalHelado = 2500;
                }
                else if (selecPresentacion == 2)
                {
                    Console.SetCursorPosition(32, 15); Console.Write("Presentacion: VASO");
                    presentacionHelado = "VASO: 3000";
                    totalHelado = 3000;
                }
                else
                {
                    Console.SetCursorPosition(32, 15); Console.Write("VALOR INCORRECTO, ESCOJA OTRA OPCION");
                }

            } while (selecPresentacion <= 0 || selecPresentacion > 2);

            Console.SetCursorPosition(32, 16); Console.Write("------------------------------------------------------");

            //Selecciona el sabor del helado

            do
            {
                Console.SetCursorPosition(32, 17); Console.Write("1.VAINILLA      " + "     2.CHOCOLATE" + "          3.ALMENDRA");
                Console.SetCursorPosition(32, 18); Console.Write("           4.FRESA                5.MENTA");

                Console.SetCursorPosition(32, 20); Console.Write("DIGITE EL SABOR DEL HELADO : ");
                selecSabor = byte.Parse(Console.ReadLine());
                Console.SetCursorPosition(32, 15); Console.Write("                                                      ");

                Console.SetCursorPosition(32, 21); Console.Write("------------------------------------------------------");

                if (selecSabor == 1)
                {
                    Console.SetCursorPosition(32, 22); Console.Write("Sabor: VAINILLA");
                    saborHelado = "Vainilla";
                }
                else if (selecSabor == 2)
                {
                    Console.SetCursorPosition(32, 22); Console.Write("Sabor: CHOCOLATE");
                    saborHelado = "Chocolate";
                }
                else if (selecSabor == 3)
                {
                    Console.SetCursorPosition(32, 22); Console.Write("Sabor: ALMENDRA");
                    saborHelado = "Almendra";
                }
                else if (selecSabor == 4)
                {
                    Console.SetCursorPosition(32, 22); Console.Write("Sabor: FRESA");
                    saborHelado = "Fresa";
                }
                else if (selecSabor == 5)
                {
                    Console.SetCursorPosition(32, 22); Console.Write("Sabor: MENTA");
                    saborHelado = "Menta";
                }
                else
                {
                    Console.SetCursorPosition(32, 22); Console.Write("VALOR INCORRECTO, ESCOJA OTRA OPCION");
                }

            } while (selecSabor <= 0 || selecSabor > 5);

            Console.SetCursorPosition(32, 23); Console.Write("------------------------------------------------------");

            //Selecciona el topping que desea añadirle al helado

            do
            {
                Console.SetCursorPosition(32, 24); Console.Write("1.CHIPS COLORES:1500           2.CHIPS CHOCOLATE:3000");
                Console.SetCursorPosition(32, 25); Console.Write("    3.MANI: 2000                    4. NO TOPPING");

                Console.SetCursorPosition(32, 27); Console.Write("DIGITE EL TOPPING QUE DESEA AGREGAR: ");
                selecToppings = byte.Parse(Console.ReadLine());
                Console.SetCursorPosition(32, 15); Console.Write("                                                      ");

                Console.SetCursorPosition(32, 28); Console.Write("------------------------------------------------------");

                if (selecToppings == 1)
                {
                    Console.SetCursorPosition(32, 29); Console.Write("Topping: MANI");
                    toppingHelado = "MANI: 2000";
                    totalHelado += 2000;
                }
                else if (selecToppings == 2)
                {
                    Console.SetCursorPosition(32, 29); Console.Write("Topping: CHISPAS DE CHOCOLATE");
                    toppingHelado = "CHISPAS DE CHOCOLATE: 3000";
                    totalHelado += 3000;
                }
                else if (selecToppings == 3)
                {
                    Console.SetCursorPosition(32, 29); Console.WriteLine("Topping: CHISPAS DE COLORES");
                    toppingHelado = "CHISPAS DE COLORES: 1500";
                    totalHelado += 1500;
                }
                else if (selecToppings == 4)
                {
                    Console.SetCursorPosition(32, 29); Console.WriteLine("Topping: NO TOPPING");
                    toppingHelado = "NO TOPPING";
                }
                else
                {
                    Console.SetCursorPosition(32, 29); Console.WriteLine("VALOR INCORRECTO, ESCOJA OTRA OPCION");
                }

            } while (selecToppings <= 0 || selecToppings > 4);

            valor = totalHelado;

            Console.SetCursorPosition(32, 31); Console.Write("------------------------------------------------------");

            //Llama al objeto factura

            factura = new Factura(codigoFactura, identificacion, nombre, presentacionHelado, saborHelado, toppingHelado, valor);

            //Muestra la factura de lo comprado

            Console.Clear();
            Titulo();
            Console.SetCursorPosition(32, 8); Console.Write("-----------------    F A C T U R A    ----------------");
            Console.SetCursorPosition(32, 9); Console.Write("Codigo:   " + factura.CodigoFactura);
            Console.SetCursorPosition(32, 10); Console.Write("Cedula:   " + factura.Identificacion);
            Console.SetCursorPosition(32, 11); Console.Write("Nombre:   " + factura.Nombre);
            Console.SetCursorPosition(32, 12); Console.Write("Present.: " + factura.TipoHelado);
            Console.SetCursorPosition(32, 13); Console.Write("Sabor:    " + factura.SaborHelado);
            Console.SetCursorPosition(32, 14); Console.Write("Toppings: " + factura.ToppingHelado);

            Console.SetCursorPosition(32, 16); Console.Write($"EL TOTAL A PAGAR ES DE: $" + factura.Valor);

            Console.SetCursorPosition(32, 18); Console.Write("Registro guardado... Presione ENTER para continuar");
            Console.ReadKey();

            return factura;
 
        }

        private static void Consultar()
        {
            Console.Clear();
            Titulo();
            Console.SetCursorPosition(55, 7); Console.WriteLine("VENTAS TOTALES");
            Console.SetCursorPosition(32, 8); Console.WriteLine("------------------------------------------------------");
            var respuesta = facturaService.Consultar();
            if (respuesta.Error)
            {
                Console.WriteLine(respuesta.Mensaje);
            }
            else
            {
                foreach (var item in respuesta.Personas)
                {
                    Console.WriteLine(item.ToString());
                    Console.WriteLine("                                ------------------------------------------------------");
                }
            }
        }


        static public void Eliminar()
        {

            Titulo();

            Console.SetCursorPosition(45, 7); Console.Write("ELIMINAR REGISTRO FACTURA");
            Console.SetCursorPosition(32, 8); Console.Write("------------------------------------------------------");
            Console.SetCursorPosition(32, 9); Console.Write("DIGITE CODIGO PARA ELIMINAR: ");
            int codeFactura = int.Parse(Console.ReadLine());
            string mensaje = facturaService.Eliminar(codeFactura);
            Console.WriteLine(mensaje);
            Console.ReadKey();

        }
    }
}
