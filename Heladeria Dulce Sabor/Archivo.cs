using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
    }
}
