using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        #region Metodos
        public double Operar(Numero num1, Numero num2, string operador)
        {
            string chequeo;
            chequeo = ValidarOperador(operador);
            if (chequeo == "+")
            {
                return num1 + num2;
            }
            else if (chequeo == "-")
            {
                return num1 - num2;
            }
            else if (chequeo == "*")
            {
                return num1 * num2;
            }
            else
            {
                return num1 / num2;
            }
        }

        private static string ValidarOperador(string operador)
        {
            if (operador != "/" && operador != "*" && operador != "+" && operador != "-")
            {
                return "+";
            }
            return operador;
        }
        #endregion
    }
}
