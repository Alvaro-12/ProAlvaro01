using Alvaro01.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alvaro01.DAO
{
    class ClsDUserlist
    {
        public List<UserList> cargarDatosUserlist(){
            List<UserList> Lista;

            using (programacionEntities db = new programacionEntities())
            {
                 Lista = db.UserList.ToList();

                //foreach (var iteracion in Lista)
                //{

                //    dtgListaUsuarios.Rows.Add(iteracion.Id, iteracion.NombreUsuario, iteracion.Apellido, iteracion.Edad, iteracion.pass);

                //}

            }


            return null;
        }

        //public void SaveDatosUser(string Nombre, string Apellido, int Edad, String Pass)
        //{
        //    try
        //    {
        //        using (programacionEntities db = new programacionEntities())
        //        {

        //            UserList userList = new UserList();

        //            userList.NombreUsuario = Nombre;
        //            userList.Apellido = Apellido;
        //            userList.Edad = Edad;
        //            userList.pass = Pass;

        //            //igual a un inser//
        //            db.UserList.Add(userList);
        //            ////
        //            db.SaveChanges();

        //            MessageBox.Show("Save");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }



        //}
        public void SaveDatosUser(UserList user)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {

                    UserList userList = new UserList();

                    userList.NombreUsuario = user.NombreUsuario;
                    userList.Apellido = user.Apellido;
                    userList.Edad = user.Edad;
                    userList.pass = user.pass;

                    //igual a un inser//
                    db.UserList.Add(userList);
                    ////
                    db.SaveChanges();

                    MessageBox.Show("Save");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void deletusuarios(int iD )
        {
            try
            {

                using (programacionEntities db = new programacionEntities())
                {
                    int Eliminar = Convert.ToInt32(iD);
                    UserList userList = db.UserList.Where(x => x.Id == Eliminar).Select(x => x).FirstOrDefault();
                    //new UserList();
                    // userList = db.UserList.Find(TxtId.Text);
                    db.UserList.Remove(userList);
                    db.SaveChanges();

                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }



        }

        public void updateuser(UserList user)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {

                    int Update = Convert.ToInt32(user.Id);
                    UserList userList = db.UserList.Where(x => x.Id == Update).Select(x => x).FirstOrDefault();
                    
                    
                    user.NombreUsuario = user.NombreUsuario;
                    user.Apellido = user.Apellido;
                    user.Edad = user.Edad;
                    user.pass = user.pass;
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

    }

}
