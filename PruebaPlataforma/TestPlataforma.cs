using Entidades;

namespace PruebaPlataforma
{
    [TestClass]
    public class TestPlataforma
    {
        [TestMethod]
        [ExpectedException(typeof(TraerDatosException))]
        public void TestValidarExcepcion()
        {
            DatosDAO datos = new DatosDAO();
            datos.TraerDatosClientes();
        }

        [TestMethod]
        public void TestListaInstaciada()
        {
            List<Producto> productos = new List<Producto>();
            Assert.IsNotNull(productos);
        }

        [TestMethod]
        public void TestProductos()
        {
            Producto p1 = new Producto(11, "asd", 123, 5);
            Producto p2 = new Producto(11, "asd", 123, 5);

            bool resultado = p1 == p2;

            Assert.IsTrue(resultado);   
        }

        [TestMethod]
        public void CalcularPrecioFinal_TipoEfectivo_DescuentoAplicado()
        {
            // Arrange
            TipoPago tipoPago = TipoPago.Efectivo;
            string cadena;
            double subtotal = 100.0;

            // Act
            double resultado = Venta.CalcularPrecioFinal(tipoPago, out cadena, subtotal);

            // Assert
            Assert.AreEqual(90.0, resultado);
            Assert.AreEqual("Descuento 10%:", cadena);
        }
    }
}