﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// La clase Producto no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {
        public enum EMarca
        {
            Serenisima, Campagnola, Arcor, Ilolay, Sancor, Pepsico
        }

        #region Atributos
        EMarca marca;
        string codigoDeBarras;
        ConsoleColor colorPrimarioEmpaque;
        #endregion

        #region Propiedades
        /// <summary>
        /// ReadOnly: Retornará la cantidad de ruedas del vehículo
        /// </summary>
        protected abstract short CantidadCalorias { get; }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor del producto
        /// </summary>
        /// <param name="patente">El codigo de barraras del producto</param>
        /// <param name="marca">La marca del producto</param>
        /// <param name="color">El color primario del paquete</param>
        public Producto(string patente, EMarca marca, ConsoleColor color)
        {
            this.codigoDeBarras = patente;
            this.marca = marca;
            this.colorPrimarioEmpaque = color;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        #endregion

        #region Sobrecargas
        public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CODIGO DE BARRAS: " + p.codigoDeBarras);
            sb.AppendLine("MARCA          : " + p.marca.ToString());
            sb.AppendLine("COLOR EMPAQUE  : " + p.colorPrimarioEmpaque.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto v1, Producto v2)
        {
            return (v1.codigoDeBarras == v2.codigoDeBarras);
        }
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto v1, Producto v2)
        {
            return !(v1.codigoDeBarras == v2.codigoDeBarras);
        }
        #endregion
    }
}