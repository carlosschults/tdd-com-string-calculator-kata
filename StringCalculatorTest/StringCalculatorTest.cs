using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCalculator;

namespace StringCalculatorTest
{
    class StringCalculatorTest
    {
        [Test]
        public void StringCalculator_String_Vazia_Deve_Retornar_Zero()
        {
            var valor = string.Empty;
            var sut = new StringCalculator();
            var esperado = 0;
            var obtido = sut.Add(valor);
            Assert.AreEqual(esperado, obtido);
        }
    }
}
