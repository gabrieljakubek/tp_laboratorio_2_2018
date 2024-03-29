﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
{
    public enum ENacionalidad
    {
        Argentina,
        Extranjero
    }

    public abstract class Persona
    {
        #region Atributos
        private string _nombre;
        private string _apellido;
        private ENacionalidad _nacionalidad;
        private int _dni;
        #endregion

        #region Propiedades
        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        public int DNI
        {
            get { return this._dni; }
            set { this._dni = value; }
        }

        public ENacionalidad Nacionalidad
        {
            get { return this._nacionalidad; }
            set { this._nacionalidad = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string StringToDNI
        {
            set
            {

            }
        }
        #endregion

    }
}