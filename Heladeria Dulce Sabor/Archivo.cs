using System;
using System.IO;

namespace Heladeria_Dulce_Sabor
{
    class Archivo
    {
        public void Guardar(Factura factura)
        {
            string ruta = @"FacturaHelado.txt";
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{factura.codigoFactura};{factura.identificacion};{factura.nombre};{factura.tipoHelado};{factura.saborHelado};{factura.toppingHelado};{factura.valor}");
            writer.Close();
            file.Close();
        }


        public void Consultar()
        {

            string ruta = @"FacturaHelado.txt";

            Console.SetCursorPosition(55, 7); Console.WriteLine("VENTAS TOTALES");

            try
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach (var linea in lineas)
                {
                    var val = linea.Split(";");
                    Console.WriteLine("                                ------------------------------------------------------");
                    Console.WriteLine("                                CODIGO:" + val[0]
                        + "\n                                IDENTIFICACION: " + val[1]
                        + "\n                                NOMBRE: " + val[2]
                        + "\n                                PRESENTACION: " + val[3]
                        + "\n                                SABOR: " + val[4]
                        + "\n                                TOPPING: " + val[5]
                        + "\n                                VALOR: " + val[6]);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("El archivo no se puede leer");
            }

            Console.WriteLine("");
            Console.WriteLine("                                PRESIONE ENTER PARA CONTINUAR");
            Console.ReadKey();
            Console.Clear();
        }

        public void Modificar()
        {
            String[] campos = new String[7];
            bool encontrado = false;
            byte opcionM;
            String nuevaCedula, nuevoNombre, nuevoSabor;
            try
            {
                StreamReader lector = File.OpenText(@"FacturaHelado.txt");
                StreamWriter temporal = File.CreateText(@"tmp.txt");
                Console.Write("INGRESE EL CODIGO QUE DESEA MODIFICAR: ");
                int codeFactura = int.Parse(Console.ReadLine());
                String cadena = lector.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(";");

                    if (campos[0].Trim().Equals(codeFactura))
                    {
                        encontrado = true;
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine("REGISTRO ENCONTRADO CON LOS SIGUIENTES DATOS");
                        Console.WriteLine("Codigo:   " + campos[0]);
                        Console.WriteLine("Cedula:   " + campos[1]);
                        Console.WriteLine("Nombre:   " + campos[2]);
                        Console.WriteLine("Present.: " + campos[3]);
                        Console.WriteLine("Sabor:    " + campos[4]);
                        Console.WriteLine("Topping:  " + campos[5]);
                        Console.WriteLine("Valor:    " + campos[6]);
                        Console.WriteLine("------------------------------------------------------");
                        Console.Write("Este es el registro?    (S/N)");
                        String respuesta = Console.ReadLine();
                        respuesta = respuesta.ToUpper();
                        if (respuesta.Equals("S"))
                        {
                            Console.WriteLine("Modificaciones");
                            Console.WriteLine("1. Cedula");
                            Console.WriteLine("2. Nombre");
                            Console.WriteLine("4. Sabor ");
                            Console.WriteLine("DIGITE LO QUE DESEA MODIFICAR: ");
                            opcionM = Convert.ToByte(Console.ReadLine());
                            switch (opcionM)
                            {
                                case 1:
                                    Console.Write("Digite la nueva cedula: ");
                                    nuevaCedula = Console.ReadLine();
                                    nuevaCedula = nuevaCedula.ToUpper();
                                    temporal.WriteLine(campos[0] + ";" + nuevaCedula + ";" + campos[2] + ";" + campos[3] + ";" + campos[4] + ";" + campos[5] + ";" + campos[6]);
                                    Console.WriteLine("Registro Modificado");
                                    break;

                                case 2:
                                    Console.Write("Digite el nuevo nombre: ");
                                    nuevoNombre = Console.ReadLine();
                                    nuevoNombre = nuevoNombre.ToUpper();
                                    temporal.WriteLine(campos[0] + ";" + campos[1] + ";" + nuevoNombre + ";" + campos[3] + ";" + campos[4] + ";" + campos[5] + ";" + campos[6]);
                                    Console.WriteLine("Registro Modificado");
                                    break;

                                case 3:
                                    Console.Write("Digite el nuevo sabor: ");
                                    nuevoSabor = Console.ReadLine();
                                    nuevoSabor = nuevoSabor.ToUpper();
                                    temporal.WriteLine(campos[0] + ";" + campos[1] + ";" + campos[2] + ";" + campos[3] + ";" + nuevoSabor + ";" + campos[5] + ";" + campos[6]);
                                    Console.WriteLine("Registro Modificado");
                                    break;

                                default:
                                    Console.WriteLine("Opcion incorrecta");
                                    break;
                            }
                        }
                        else
                        {
                            temporal.WriteLine(cadena);
                        }
                    }
                    else
                    {
                        temporal.WriteLine(cadena);
                    }

                    cadena = lector.ReadLine();
                }
                if (encontrado == false)
                {
                    Console.WriteLine("El codigo no se encuentra registrado en el archivo");
                }
                lector.Close();
                temporal.Close();

                File.Delete("FacturaHelado.txt");
                File.Move("tmp.txt", "FacturaHelado.txt");
            }
            catch (FileNotFoundException fn)
            {
                Console.WriteLine("Error" + fn.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e.Message);
            }
            finally
            {
               //lector.Close();
               //temporal.Close();
            }
        }
    }

}
