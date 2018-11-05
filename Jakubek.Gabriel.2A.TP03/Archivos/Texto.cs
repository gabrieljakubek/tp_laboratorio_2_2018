using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            bool retorno = false;

            try
            {

            }
            catch (Exception)
            {

                throw;
            }

            return retorno;
        }

        public bool Leer(string archivo, out string datos)
        {
            bool retorno = false;

            datos = "";

            try
            {

            }
            catch (Exception)
            {

                throw;
            }

            return retorno;
        }
    }
}
