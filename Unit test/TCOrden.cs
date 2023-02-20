using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Facturacion_Restaurantes.Data;
using Sistema_Facturacion_Restaurantes.Controller;
using Xunit;
using Sistema_Facturacion_Restaurantes.Forms;

namespace Unit_test
{
    public class TCOrden
    {
        [Fact]
        public void insertar()
        {
            int EmpleadoID = 19;
            int MesaID = 4;
            int ClienteID = 1;
            string FechaRealizacion = DateTime.Now.ToString();

            var resultado = COrden.Insertar(EmpleadoID, MesaID, ClienteID, FechaRealizacion);
            Assert.Equal("OK", resultado.ToString());
        }

        [Fact]
        public void Actualizar()
        {
            int OrdenID = 1045;
            int EmpleadoID = 19;
            int MesaID = 1;
            int ClienteID = 2;
            string FechaRealizacion = DateTime.Now.ToString();

            var resultado = COrden.Actualizar(OrdenID, EmpleadoID, MesaID, ClienteID, FechaRealizacion);
            Assert.Equal("OK", resultado.ToString());
        }

        [Fact]
        public void EliminarOrden()
        {
            int OrdenID = 1044;
            var resultado = COrden.Eliminar(OrdenID);

            Assert.Equal("OK", resultado.ToString());
        }
    }
}
