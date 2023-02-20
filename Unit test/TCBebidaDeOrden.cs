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
    public class TCBebidaDeOrden
    {
        [Fact]
        public void insertar()
        {
            int OrdenID = 1045;
            int BebidaID = 11;
            int Cantidad = 4;

            var resultado = CBebidasDeOrden.Insertar(OrdenID, BebidaID, Cantidad);
            Assert.Equal("OK", resultado.ToString());
        }

        [Fact]
        public void Actualizar()
        {
            int OrdenID = 1045;
            int BebidaID = 11;
            int NewBebidaID = 15;
            int Cantidad = 6;

            var resultado = CBebidasDeOrden.Actulizar(OrdenID, BebidaID, NewBebidaID, Cantidad);
            Assert.Equal("OK", resultado.ToString());
        }
    }
}
