using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Validation.Validator;

namespace Testing
{
    [TestClass]
    public class ValidationTests
    {
        [TestMethod]
        public void TestSinNumerosValid()
        {
            string test_string = "Horacio";

            bool result = SinNumeros(test_string);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestSinNumerosInvalid ()
        {
            string test_string = "Horacio123";

            bool result = SinNumeros(test_string);

            Assert.IsFalse (result);
        }

        [TestMethod]
        public void TestEsSeguraValid ()
        {
            string test_password = "Alfon1234";

            bool result = EsSegura(test_password);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestEsSeguraInvalid ()
        {
            string test_password = "hola";

            bool result = EsSegura(test_password);

            Assert.IsFalse(result);
        }
    }
}
