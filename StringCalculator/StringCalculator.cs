using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string valor)
        {
            int resultado = 0;
            var partes = valor.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string parte in partes)
            {
                int numero = int.Parse(parte);

                if (numero < 0)
                    throw new ArgumentException("Números negativos não são permitidos.");

                resultado += numero;
            }

            return resultado;
        }
    }
}