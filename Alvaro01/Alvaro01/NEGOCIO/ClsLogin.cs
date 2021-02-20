using Alvaro01.DAO;
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

        ClsListaUsuarios cls = new ClsListaUsuarios();

        public int Ingresar(Login log)
        {
            int estado = 0;

            for (int i = 0; i < cls.user.Length; i++)
            {
                if (log.Ususario.Equals(cls.user[i]) && log.Password.Equals(cls.pass[i])) {
                    {
                        estado = 1;
                    }
                }
            }
            return  estado;
        }
    }
}
