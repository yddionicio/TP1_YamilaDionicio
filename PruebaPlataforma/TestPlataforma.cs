using Entidades;

namespace PruebaPlataforma
{
    [TestClass]
    public class TestPlataforma
    {
        //[TestMethod]
       // [ExpectedException(typeof(VentaInvalidaException))]
        //public void TestValidarExcepcion()
        //{
            //Arrange: Inicializar las variables
            //List<Producto> productos = new List<Producto>();
            //Cliente cliente = new Cliente("aa", "bb", 123456, "asd@",465789);

            ////Act: llamar al metodo a testear
            //Venta venta = new Venta(productos, cliente, DateTime.Now);
            
            //Assert: comprobar el valor con el esperado
       // }

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