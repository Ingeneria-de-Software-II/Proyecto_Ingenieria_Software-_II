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
    public class TCCombobox
    {
        [Fact]
        public void CargarDepartamento()
        {
            var resultado = CComboxes.CargarDepartamentos();

            int actual = 0;
            if (resultado.Rows.Count > 0)
                actual = 1;

            Assert.Equal(1, actual);
        }

        [Fact]
        public void CargarEmpleados()
        {
            var resultado = CComboxes.CargarEmpleados();

            int actual = 0;
            if (resultado.Rows.Count > 0)
                actual = 1;

            Assert.Equal(1, actual);
        }

        [Fact]
        public void CargarMesa()
        {
            var resultado = CComboxes.CargarMesas(1);

            int actual = 0;
            if (resultado.Rows.Count > 0)
                actual = 1;

            Assert.Equal(1, actual);
        }
    }
}
