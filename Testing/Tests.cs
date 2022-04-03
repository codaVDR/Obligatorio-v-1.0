using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Validation.Validator;
using Manager;
using Dominio;
using System;

namespace Testing
{
    [TestClass]
    public class Tests
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

    [TestClass]
    public class TestDelivery
    {
        [TestMethod]
        public void TestCalculateTotal ()
        {
            Client testClient1 = new Client("Rodolfo", "Mondolfo", "rodolfo@mondolfo.com", "Rodo1234");
            Client testClient2 = new Client("Américo", "Castro", "americo@castro.com", "Castro1234");
            Dish testDish1 = new Dish ("Sushi", 400);
            Dish testDish2 = new Dish("Rabas", 600);
            Local testLocal = new Local(DateTime.Now, 1);
            testLocal.AddDish(testDish1);
            testLocal.AddDish(testDish2);
            testLocal.AddGuest(testClient1);
            testLocal.AddGuest(testClient2);
            float cover = testLocal.Cover;

            float basePrice = 400 + 600 + testLocal.Guests.Count * cover;
            float expectedResult = (float)(basePrice * 1.1);

            Assert.AreEqual(expectedResult, testLocal.CalculateTotal());
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
    }
}
