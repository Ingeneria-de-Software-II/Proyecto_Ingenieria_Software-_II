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
    public class TCCliente
    {
        [Fact]
        public void Insertar()
        {
            string Cedula = "8949565235M";
            string Nombres = "Bergolio";
            string Apellidos = "Du";
            string Telefono = "89845944";

            var resultado = CCliente.Insertar(Cedula, Nombres, Apellidos, Telefono);
            Assert.Equal("OK", resultado.ToString());
        }

        [Fact]
        public void Actualizar()
        {
            string Cedula = "8949565235M";
            string Nombres = "Maximo";
            string Apellidos = "Dergolio";
            string Telefono = "89845944";
            int ClienteID = 13;

            var resultado = CCliente.Actualizar(ClienteID, Cedula, Nombres, Apellidos, Telefono);
            Assert.Equal("OK", resultado.ToString());
        }

        [Fact]
        public void MostrarBebida()
        {
            var resultado = CCliente.MostrarCliente();
            int actual = 0;
            if (resultado.Rows.Count > 0)
                actual = 1;

            Assert.Equal(1, actual);
        }
    }
}
