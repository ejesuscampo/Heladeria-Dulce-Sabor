using Entidad;
using System;
using System.Collections.Generic;
using System.IO;

namespace Datos
{
    public class FacturaRepository
    {

        string ruta = @"FacturaHelado.txt";
        public void Guardar(Factura factura)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{factura.CodigoFactura};{factura.Identificacion};{factura.Nombre};{factura.TipoHelado};{factura.SaborHelado};{factura.ToppingHelado};{factura.Valor}");
            writer.Close();
            file.Close();
        }

        public List<Factura> Consultar()
        {
            List<Factura> facturas = new List<Factura>();
            StreamReader reader = new StreamReader(ruta);
            string linea;
            while ((linea = reader.ReadLine()) != null)
            {
                string[] datoFactura = linea.Split(';');

                Factura factura = new Factura()
                {
                    CodigoFactura = int.Parse(datoFactura[0]),
                    Identificacion = datoFactura[1],
                    Nombre = datoFactura[2],
                    TipoHelado = datoFactura[3],
                    SaborHelado = datoFactura[4],
                    ToppingHelado = datoFactura[5],
                    Valor = Convert.ToDouble(datoFactura[6])
                 };
                
                facturas.Add(factura);
            }
            reader.Close();
            return facturas;
        }

        public void Modificar(int codigo, Factura personaNew)
        {
            List<Factura> facturas = Consultar();
            File.Delete(ruta);

            foreach (var item in facturas)
            {
                if (!item.CodigoFactura.Equals(codigo))
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(personaNew);
                }
            }

        }

        public void Eliminar(int codigo)
        {
            List<Factura> facturas = Consultar();
            File.Delete(ruta);

            foreach (var item in facturas)
            {
                if (!item.CodigoFactura.Equals(codigo))
                {
                    Guardar(item);
                }
            }
        }

        public Factura Buscar(int codigo)
        {
            List<Factura> facturas = Consultar();
            foreach (var item in facturas)
            {
                if (item.CodigoFactura.Equals(codigo))
                {
                    return item;
                }
            }
            return null;
        }
    }
}

