using System;
using Xunit;
using Sistema_Facturacion_Restaurantes;
using Sistema_Facturacion_Restaurantes.Controller;
using Sistema_Facturacion_Restaurantes.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Facturacion_Restaurantes.Data;

namespace Unit_test
{
    public class AuthTest
    {
        [Fact]
        public void InicioSesionExitoso()
        {
            var result = CUsuario.Validar_acceso("Rodian", "matey");

            Assert.Equal("Acceso exitoso", result.Rows[0][0].ToString());
        }
    }
}
