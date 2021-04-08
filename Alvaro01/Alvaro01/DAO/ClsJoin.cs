
using Alvaro01.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alvaro01
{
    class ClsJoin
    {
        public List<List<Object>> joinUsuarioType() {
            List<List<Object>> Matriz = new List<List<Object>>();
            using (programacionEntities db = new programacionEntities())
            {

                //con esto se a creado un join, tecnicamente
                var lista = (from usuario in db.UserList1
                             from type in db.TypeOfUser
                             where usuario.IdTypeOfUser == type.IdTypeOfUser

                             select new
                             {
                                 usuario.Id,
                                 usuario.NombreUsuario,
                                 type.IdTypeOfUser,
                                 type.TypeofUserName
                             }).ToList();
                for (int i = 0; i < lista.Count; i++) {
                    Matriz.Add(new List<object>()
                    {
                        lista [i].Id,lista[i].NombreUsuario, lista [i].IdTypeOfUser, lista [i].TypeofUserName


                    });
                 
                 
                }

            }
                return Matriz;
        }
 
    }
}
