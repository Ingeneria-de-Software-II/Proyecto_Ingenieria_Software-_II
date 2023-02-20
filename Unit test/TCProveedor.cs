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
    public class TCProveedor
    {
        [Fact]
        public void MostrarProveedor()
        {
            var resultado = CProveedor.MostrarProveedor();
            int actual = 0;
            if (resultado.Rows.Count > 0)
                actual = 1;

            Assert.Equal(1, actual);
        }

        [Fact]
        public void insertar()
        {
            string NombreCompania = "Azus";
            string Telefono = "98098099";
            int LocalidadID = 7;
            string Direccion = "VRN";

            var resultado = CProveedor.Insertar(NombreCompania,Telefono, LocalidadID, Direccion);
            Assert.Equal("OK", resultado.ToString());
        }

        [Fact]
        public void EliminarProveedor()
        {
            int ProveedorID = 1012;
            var resultado = CProveedor.Eliminar(ProveedorID);

            Assert.Equal("OK", resultado.ToString());
        }
    }
}
