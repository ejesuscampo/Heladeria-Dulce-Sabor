using System;
using System.Collections.Generic;
using Datos;
using Entidad;

namespace Logica
{
    public class FacturaService
    {

        FacturaRepository facturaRepository = new FacturaRepository();

        public string Guardar(Factura factura)
        {
            try
            {
                if (facturaRepository.Buscar(factura.CodigoFactura) == null)
                {
                    facturaRepository.Guardar(factura);

                }
                return $"\n          La información no puede ser guardada, ya existe una factura con ese codigo: {factura.CodigoFactura}";
            }
            catch (Exception e)
            {
                return $"Error inesperado al GUARDAR: {e.Message}";
            }
        }

        public PersonaConsultaResponse Consultar()
        {
            try
            {
                return new PersonaConsultaResponse(facturaRepository.Consultar());
            }
            catch (Exception e)
            {
                return new PersonaConsultaResponse($"Error inesperado al CONSULTAR: {e.Message}");
            }
        }

        public string Eliminar(int codigo)
        {
            try
            {
                if (facturaRepository.Buscar(codigo) != null)
                {
                    facturaRepository.Eliminar(codigo);
                    return $"\n                                Se eliminó la factura con codigo: {codigo}";
                }
                return $"          No fue posible eliminar el registro, porque no existe ninguna factura con ese codigo: {codigo}";
            }
            catch (Exception e)
            {
                return $"Error inesperado al ELIMINAR: {e.Message}";
            }
        }


        public string Modificar(int codigo, Factura facturaNew)
        {
            try
            {
                if (facturaRepository.Buscar(codigo) == null)
                {
                    return $"No es posible realizar la modificación, la factura con codigo: {codigo}, no existe";
                }
                if (facturaRepository.Buscar(facturaNew.CodigoFactura) != null)
                {
                    return $"No es posible realizar la modificación, el codigo: {facturaNew.Identificacion} ya se encuentra asignada a otra persona";
                }
                facturaRepository.Modificar(codigo, facturaNew);

                return "Se realizó la Modificación Satisfactoriamente";

            }
            catch (Exception e)
            {

                return $"Error inesperado al Modificar: {e.Message}";
            }
        }
    }


    public class PersonaConsultaResponse
    {
        public List<Factura> Personas { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public PersonaConsultaResponse(List<Factura> personas)
        {
            Personas = personas;
            Error = false;
        }
        public PersonaConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
}