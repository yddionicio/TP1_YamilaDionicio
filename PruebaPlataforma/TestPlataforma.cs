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


    }
}