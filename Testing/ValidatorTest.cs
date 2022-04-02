using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Validation.Validator;
using Dominio;

namespace Testing
{
    [TestClass]
    public class ValidationTests
    {
        [TestMethod]
        public void TestSinNumerosOK()
        {
            string test_string = "Horacio";

            bool result = SinNumeros(test_string);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestSinNumerosNOTOK()
        {
            string test_string = "Horacio123";

            bool result = SinNumeros(test_string);

            Assert.IsFalse (result);
        }

        [TestMethod]
        public void TestEsSeguraOK ()
        {
            string test_password = "Alfon1234";

            bool result = EsSegura(test_password);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestEsSeguraNOTOK ()
        {
            string test_password = "hola";

            bool result = EsSegura(test_password);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestEsValidoOK ()
        {
            string test_email = "valido@validez.com";

            bool result = EsValido(test_email);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestEsValidoNOTOK ()
        {
            string test_email = "invalido.com";

            bool result = EsValido(test_email);

            Assert.IsFalse(result);
        }
    }

    [TestClass]
    public class ClientTests
    {
        [TestMethod]
        public void TestIsValidOK ()
        {
            string test_name = "Alfonso";
            string test_last_name = "Zabala";
            string test_email = "zabala@alfonso.com";
            string test_password = "Alfon1234";

            bool result = Client.isValid(test_name, test_last_name, test_email, test_password);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestIsValidNOTOK ()
        {
            string test_name = "alf0ns0";
            string test_last_name = "Zabala";
            string test_email = "zabala@alfonso.com";
            string test_password = "alfon1234";

            bool result = Client.isValid(test_name, test_last_name, test_email, test_password);

            Assert.IsFalse(result);
        }
    }

    [TestClass]
    public class DishTests
    {
        [TestMethod]
        public void TestValidarDatosOK ()
        {
            string test_name = "Sushi";
            float test_price = 500;

            bool result = Dish.ValidarDatos(test_name, test_price);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestValidarDatosNOTOK()
        {
            string test_name = "";
            float test_price = 110;

            bool result = Dish.ValidarDatos(test_name, test_price);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestUpdateMinimumOK ()
        {
            float testUpdated = 200;

            Dish.UpdateMinimum(testUpdated);

            Assert.AreEqual(Dish.minimumPrice, testUpdated);
        }

    }
}
