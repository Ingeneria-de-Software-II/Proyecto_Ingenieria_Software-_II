using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Facturacion_Restaurantes.Data;
using Sistema_Facturacion_Restaurantes.Controller;
using Xunit;

namespace Unit_test
{
    public class TCComidaDeOrden
    {
        [Fact]
        public void insertar()
        {
            int OrdenID = 1045;
            int PlatoID = 12;
            int Cantidad = 6;

            var resultado = CComidasDeOrden.Insertar(OrdenID, PlatoID, Cantidad);
            Assert.Equal("OK", resultado.ToString());
        }

        [Fact]
        public void Actualizar()
        {
            int OrdenID = 1045;
            int PlatoID = 12;
            int NewPlatoID = 13;
            int Cantidad = 6;

            var resultado = CComidasDeOrden.Actulizar(OrdenID, PlatoID, NewPlatoID, Cantidad);
            Assert.Equal("OK", resultado.ToString());
        }
    }
}
