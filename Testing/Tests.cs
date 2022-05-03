using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Validation.Validator;
using Dominio;
using System;

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

            bool result = Client.IsValid(test_name, test_last_name, test_email, test_password);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestIsValidNOTOK ()
        {
            string test_name = "alf0ns0";
            string test_last_name = "Zabala";
            string test_email = "zabala@alfonso.com";
            string test_password = "alfon1234";

            bool result = Client.IsValid(test_name, test_last_name, test_email, test_password);

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
    [TestClass]
    public class AutoIDTest
    {
        [TestMethod]
        public void AutoIDOK ()
        {
            Client client_test1 = new Client("Alfonso", "Capablanca", "alfonso@capablanca.com", "Alfon1234");
            Client client_test2 = new Client("Ramón", "Yedrabuena", "ramon@yedrabuena.com", "Ramon1234");

            Assert.AreNotEqual(client_test1.ID, client_test2.ID);

        }
    }

    [TestClass]
    public class AltasTests
    {
        [TestMethod]
        public void AltaPlatoOK ()
        {
            string testName = "Sushi";
            float testPrice = 400;
            Manager.Manager testManager = new Manager.Manager();

            Dish testDish = testManager.AltaPlato(testName, testPrice);

            Assert.IsNotNull(testDish);
        }

        [TestMethod]
        public void AltaClienteOK ()
        {
            string testName = "Alfonso";
            string testLastName = "Casales";
            string testEmail = "alfonso@casales.com";
            string testPassword = "Alfon1234";
            Manager.Manager testManager = new Manager.Manager();

            Client testClient = testManager.AltaCliente(testName, testLastName, testEmail, testPassword);

            Assert.IsNotNull(testClient);
        }

        [TestMethod]
        public void AltaMozoOK()
        {
            string testName = "Adolfo";
            string testLastName = "Bioy Casares";
            Manager.Manager testManager = new Manager.Manager();

            Waiter testWaiter = testManager.AltaMozo(testName, testLastName);

            Assert.IsNotNull(testWaiter);
        }
    }
}
