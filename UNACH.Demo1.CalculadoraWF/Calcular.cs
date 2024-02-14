using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNACH.Demo1.CalculadoraWF
{
    class Calcular
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor1"></param>
        /// <param name="valor2"></param>
        /// <returns></returns>
        public int Sumar(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
        public int Restar(int valor1, int valor2)
        {
            int resultado = valor1 - valor2;
            return resultado;
        }
        public int Multiplicar()
        {
            return Numero1 * Numero2;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public float Dividir()
        {
            float resultado = Numero1 / Numero2;
            return resultado;
        }
    }
}
