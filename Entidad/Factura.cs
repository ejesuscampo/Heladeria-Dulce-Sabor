using System;

namespace Entidad
{
    public class Factura
    {
        public Factura()
        {

        }

        public Factura(int codigoFactura, string identificacion, string nombre, string tipoHelado, string saborHelado, string toppingHelado, double valor)
        {
            this.CodigoFactura = codigoFactura;
            this.Identificacion = identificacion;
            this.Nombre = nombre;
            this.TipoHelado = tipoHelado;
            this.SaborHelado = saborHelado;
            this.ToppingHelado = toppingHelado;
            this.Valor = valor;
        }

        public int CodigoFactura { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string TipoHelado { get; set; }
        public string SaborHelado { get; set; }
        public string ToppingHelado { get; set; }
        public double Valor { get; set; }

        public override string ToString()
        {
            return $"                                CODIGO:   {CodigoFactura}"
                + $"\n                                IDENTIFICACION:   {Identificacion}"
                + $"\n                                NOMBRE:   {Nombre}"
                + $"\n                                PRESENTACION:   {TipoHelado}"
                + $"\n                                SABOR:   {SaborHelado}" 
                + $"\n                                TOPPING:   {ToppingHelado}"
                + $"\n                                VALOR:   {Valor}";
        }
    }
}

