using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos
        private double numero;
        #endregion

        #region Propiedades
        private string SetNumero
        {
            set { this.numero = ValidarNumero(value); }
        }
        #endregion

        #region Constructores
        public Numero() : this("0")
        {
        }

        public Numero(double numero) : this("" + numero)
        {
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        #endregion

        #region Metodos
        public string DecimalBinario(string numero)
        {
            return this.DecimalBinario(double.Parse(numero));
        }

        public string DecimalBinario(double numero)
        {
            string retorno = "";
            int numeroAux = 0;
            int i;
            bool flag = true;
            char digitoBina;
            string binarioInverso = "";
            numeroAux = (int)numero;
            if (numeroAux != 0)
            {
                while (flag)
                {
                    if (numeroAux % 2 == 1 || numeroAux % 2 == 0)
                    {
                        binarioInverso = binarioInverso + (numeroAux % 2);
                        numeroAux /= 2;
                        if (numeroAux == 1)
                        {
                            binarioInverso = binarioInverso + numeroAux;
                            flag = false;
                        }
                    }
                    else
                    {
                        binarioInverso = "odilavni rolaV";
                        flag = false;
                    }
                }
            }
            else
            {
                binarioInverso = "odilavni rolaV";
            }

            for (i = binarioInverso.Length - 1; i >= 0; i--)
            {
                digitoBina = binarioInverso[i];
                retorno += digitoBina;
            }

            return retorno;
        }

        public string BinarioDecimal(string binario)
        {
            string retorno = "";
            int i;
            int j;
            int cantidad = 0;
            int potem = 0;
            int acumulador = 0;

            for (i = binario.Length - 1; i >= 0; i--)
            {
                if (binario[i] == '1')
                {
                    cantidad = (binario.Length - 1) - i;
                    potem = 1;
                    for (j = 1; j <= cantidad; j++)
                    {
                        potem *= 2;
                    }
                    acumulador += potem;

                }
                else if (binario[i] != '0')
                {
                    return "Valor invalido";
                }
            }
            retorno += acumulador;
            return retorno;
        }

        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;
            bool chequeo = false;
            chequeo = double.TryParse(strNumero, out retorno);
            if (chequeo != true)
            {
                retorno = 0;
            }
            return retorno;
        }
        #endregion

        #region Sobrecargas

        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero += num2.numero;
        }

        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero -= num2.numero;
        }

        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero *= num2.numero;
        }

        public static double operator /(Numero num1, Numero num2)
        {
            if (num2.numero != 0)
            {
                return num1.numero /= num2.numero;
            }
            return 0;
        }
        #endregion
    }
}
