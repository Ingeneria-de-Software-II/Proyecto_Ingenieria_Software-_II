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
    public class TCInsumo
    {
        [Fact]
        public void insertar()
        {
            string nombre = "Maiz";
            int proveedorID = 1011;

            var resultado = CInsumo.Insertar(nombre, proveedorID);
            Assert.Equal("OK", resultado.ToString());
        }

        [Fact]
        public void Actualizar()
        {
            String nombre = "Papa";
            int proveedorID = 1011;
            int InsumoID = 5;

            var resultado = CInsumo.Actulizar(InsumoID, nombre, proveedorID);
            Assert.Equal("OK", resultado.ToString());
        }

        [Fact]
        public void MostrarInsumo()
        {
            var resultado = CInsumo.MostrarInsumo();
            int actual = 0;
            if (resultado.Rows.Count > 0)
                actual = 1;

            Assert.Equal(1, actual);
        }
    }
}
