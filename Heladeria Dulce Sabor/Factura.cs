using System;
using System.Collections.Generic;
using System.Text;

namespace Heladeria_Dulce_Sabor
{
    class Factura
    {
        public Factura()
        {

        }

        public Factura(string identificacion, string nombre, String tipoHelado, String saborHelado, String toppingHelado, double valor)
        {
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.tipoHelado = tipoHelado;
            this.saborHelado = saborHelado;
            this.toppingHelado = toppingHelado;
            this.valor = valor;
            //this.vendedor = vendedor;
        }

        public String identificacion { get; set; }
        public String nombre { get; set; }
        public String tipoHelado { get; set; }
        public String saborHelado { get; set; }
        public String toppingHelado { get; set; }
        public double valor { get; set; }
        //public String vendedor { get; set; }
    }
}
