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
    public class TCBebida
    {
        [Fact]
        public void insertar()
        {
            string nombre = "coca 12 onzas";
            int proveedorid = 1011;
            double precio = 15;

            var resultado = CBebida.Insertar(nombre, proveedorid, precio);
            Assert.Equal("OK", resultado.ToString());
        }

        [Fact]
        public void Actualizar()
        {
            String nombre = "Aloe";
            int proveedorID = 1011;
            double precio = 15;
            int bebidaID = 11;

            var resultado = CBebida.Actulizar(bebidaID, nombre, proveedorID, precio);
            Assert.Equal("OK", resultado.ToString());
        }

        [Fact]
        public void MostrarBebida()
        {
            var resultado = CBebida.MostrarBebida();
            int actual = 0;
            if (resultado.Rows.Count > 0)
                actual = 1;

            Assert.Equal(1, actual);
        }

        [Fact]
        public void EliminarBebida()
        {
            int BebidadID = 14;
            var resultado = CBebida.Eliminar(BebidadID);

            Assert.Equal("OK", resultado.ToString());
        }
    }
}
