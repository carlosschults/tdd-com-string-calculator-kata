using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCalculatorKata;

namespace StringCalculatorTest
{
    class StringCalculatorTest
    {
        [Test]
        public void StringCalculator_String_Vazia_Deve_Retornar_Zero()
        {
            // arrange
            string valor = string.Empty;
            StringCalculator sut = new StringCalculator();
            int esperado = 0;

            // act
            int obtido = sut.Add(valor);

            // assert
            Assert.AreEqual(esperado, obtido);
        }

        [TestCase("5", 5)]
        [TestCase("1", 1)]
        [TestCase("10", 10)]
        [TestCase("7", 7)]        
        public void StringCalculator_String_Contendo_Um_Numero_Deve_Retornar_O_Proprio_Numero(string valor, int esperado)
        {
            // arrange
            StringCalculator sut = new StringCalculator();

            // act
            int obtido = sut.Add(valor);

            // assert
            Assert.AreEqual(esperado, obtido);
        }

        [TestCase("5, 0", 5)]
        [TestCase("1, 1", 2)]
        [TestCase("10, 3", 13)]
        [TestCase("7, 4", 11)]
        public void StringCalculator_String_Contendo_Dois_Numeros_Deve_Retornar_Sua_Soma(string valor, int esperado)
        {
            // arrange
            StringCalculator sut = new StringCalculator();

            // act
            int obtido = sut.Add(valor);

            // assert
            Assert.AreEqual(esperado, obtido);
        }

        [TestCase("5, 0, 3", 8)]
        [TestCase("1, 1, 1", 3)]
        [TestCase("10, 3, 5", 18)]
        [TestCase("7, 4, 1", 12)] 
        public void StringCalculator_String_Contendo_Tres_Numeros_Deve_Retornar_Sua_Soma(string valor, int esperado)
        {
            // arrange
            StringCalculator sut = new StringCalculator();

            // act
            int obtido = sut.Add(valor);

            // assert
            Assert.AreEqual(esperado, obtido);
        }

        [TestCase("5", 5)]
        [TestCase("1, 1", 2)]
        [TestCase("10, 3", 13)]
        [TestCase("7, 4, 1, 3", 15)]
        public void StringCalculator_String_Contendo_Qualquer_Quantidade_De_Numeros_Deve_Retornar_Sua_Soma(string valor, int esperado)
        {
            // arrange
            StringCalculator sut = new StringCalculator();

            // act
            int obtido = sut.Add(valor);

            // assert
            Assert.AreEqual(esperado, obtido);
        }

        [TestCase("-5")]
        [TestCase("-1")]
        [TestCase("10, -3")]
        [TestCase("7, -4, 1, -3")]
        [TestCase("-1, 1, 1, 2, 3")]
        public void StringCalculator_String_Contendo_Numero_Negativo_Deve_Disparar_Excecao(string valor)
        {
            StringCalculator sut = new StringCalculator();
            Assert.That(() => sut.Add(valor), Throws.TypeOf<ArgumentException>());
        }
    }
}