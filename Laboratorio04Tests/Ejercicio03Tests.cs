    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04Tests
{
    [TestClass]
    public class Ejercicio03Tests
    {
        [TestMethod]
        [DataRow("1", "5", "6")]
        [DataRow("0", "0", "0")]
        [DataRow("278", "19", "297")]
        [DataRow("1234567890", "0", "1234567890")]
        [DataRow("99", "99", "198")]
        [DataRow("999999999999", "88888888888888", "89888888888887")]
        [DataRow("0", "999999999999999999999999", "999999999999999999999999")]
        [DataRow("18446744073709551616", "18446744073709551616", "36893488147419103232")]
        public void SumarTest(string num1, string num2, string expectedResult)
        {
            var ejercicio03 = new Ejercicio03();

            string actualResult = ejercicio03.Sumar(num1, num2);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
