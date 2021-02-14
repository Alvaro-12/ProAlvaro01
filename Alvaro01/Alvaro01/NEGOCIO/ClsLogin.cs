using Alvaro01.DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alvaro01.NEGOCIO
{
    class ClsLogin
    {

        public int Ingresar(Login log)
        {
            int estado = 0;

            if (log.Ususario.Equals("Alvaro")&& log.Password.Equals("0123") ){
                estado = 1;
            
            }

            return  estado;
        }
    }
}
