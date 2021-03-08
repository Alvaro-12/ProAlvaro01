using Alvaro01.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alvaro01.VISTA
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            carga();
        }
        void carga() {
            dataGridView1.Rows.Clear();
            
            using (programacionEntities db = new programacionEntities())
            {
                var Lista = db.UserList.ToList();

                foreach (var iteracion in Lista)
                {

                    dataGridView1.Rows.Add(iteracion.Id,iteracion.NombreUsuario,iteracion.Apellido,iteracion.Edad, iteracion.pass);

                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {

                    UserList userList = new UserList();

                    userList.NombreUsuario = TxtNameUser.Text;
                    userList.Apellido = TxtApellido.Text;
                    userList.Edad = Convert.ToInt32(TxtEdad.Text);
                    userList.pass = TxtPass.Text;

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
            carga();
        }  
        
private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                using (programacionEntities db = new programacionEntities())
                {
                    int Eliminar = Convert.ToInt32(TxtId.Text);
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
            carga();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {

                    int Update = Convert.ToInt32(TxtId.Text);
                    UserList user = db.UserList.Where(x => x.Id == Update).Select(x => x).FirstOrDefault();
                    user.NombreUsuario = TxtNameUser.Text;
                    user.Apellido = TxtApellido.Text;
                    user.Edad = Convert.ToInt32(TxtEdad.Text);
                    user.pass = TxtPass.Text;
                    db.SaveChanges();

                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            carga();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }
    }  
}



