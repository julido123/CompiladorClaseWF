using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorClaseWF.DataCache
{
    public class codigoIngresoUsuario
    {
        private static codigoIngresoUsuario instancia;
        public TextBox Codigo { get; set; }

        private codigoIngresoUsuario()
        {

        }

        public static codigoIngresoUsuario ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new codigoIngresoUsuario();
            }
            return instancia;
        }

    }
}
