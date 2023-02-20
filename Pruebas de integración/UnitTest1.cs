using NUnit.Framework;
using Moq;
using Sistema_Facturacion_Restaurantes.Controller;
using Sistema_Facturacion_Restaurantes.Data;

namespace Pruebas_de_integración
{
    [TestFixture]
    public class Tests
    {
        private CEmpleado empleado;
        private Mock<DEmpleado> empleadoMock;


        [SetUp]
        public void Setup()
        {
            empleadoMock = new Mock<DEmpleado>();

            empleado = new CEmpleado(empleadoMock.Object);
        }

        [Test]
        public void Test1()
        {
            // Arrange
            
            var dempleado = new DEmpleado {cedula = "4894948949L", nombres = "Ernesto",apellidos = "Malcon", cargo = "Chef", direccion = "VRN", sucursalID = 1, telefono = "85746745"};
            empleadoMock.Setup(e => e.Insertar(dempleado)).Returns("OK");
                //.Callback
                               //(new InvocationAction(i => actual = (DEmpleado) i.Arguments[0]))

            // Act
            var result = empleado.InsertarE(dempleado);

            // Assert
            
            Assert.AreEqual("OK", result);
            --empleadoMock.Verify(e => e.Insertar(dempleado));

            //Assert.IsTrue(AreEqual(dempleado, actual));
            //It.Is<DEmpleado>(u =>
            //u.nombres == dempleado.nombres
            //&& u.cedula == dempleado.cedula
            //&& u.apellidos == dempleado.apellidos
            //&& u.cargo == dempleado.cargo
            //&& u.direccion ==dempleado.direccion
            //&& u.sucursalID == dempleado.sucursalID
            //&& u.telefono == dempleado.telefono)));
        }

        private bool AreEqual(DEmpleado u, DEmpleado expected)
        {
            Assert.AreEqual(expected.nombres, u.nombres);
            Assert.AreEqual(expected.apellidos, u.apellidos);
            Assert.AreEqual(expected.cargo, u.cargo);
            Assert.AreEqual(expected.direccion, u.direccion);
            Assert.AreEqual(expected.cedula, u.cedula);
            Assert.AreEqual(expected.sucursalID, u.sucursalID);
            Assert.AreEqual(expected.telefono, u.telefono);
            return true;
        }
    }
}