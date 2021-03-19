using Alvaro01.DAO;
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
            clear();
        }

        void clear() {
            TxtId.Clear();
            TxtNameUser.Clear();
            TxtApellido.Clear();
            TxtEdad.Clear();
            TxtPass.Clear();
        
        }
        void carga() {
            dtgListaUsuarios.Rows.Clear();
            ClsDUserlist clsDUserlist = new ClsDUserlist();
            List<UserList> Lista =  clsDUserlist.cargarDatosUserlist();




            foreach (var iteracion in Lista)
            {

                dtgListaUsuarios.Rows.Add(iteracion.Id, iteracion.NombreUsuario, iteracion.Apellido, iteracion.Edad, iteracion.pass);

            }

           
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (TxtId.Text.Equals("")) {  
            ClsDUserlist clsDUserlist = new ClsDUserlist();
            //clsDUserlist.SaveDatosUser(TxtNameUser.Text, TxtApellido.Text,Convert.ToInt32(TxtEdad.Text),TxtPass.Text);
            UserList userList = new UserList();
            userList.NombreUsuario = TxtNameUser.Text;
            userList.Apellido = TxtApellido.Text;
            userList.Edad = Convert.ToInt32(TxtEdad.Text);
            userList.pass = TxtPass.Text;
             clsDUserlist.SaveDatosUser(userList);
                }
            else
            {
                ClsDUserlist clsDUserlist = new ClsDUserlist();

                UserList userList = new UserList();
                userList.Id = Convert.ToInt32(TxtId.Text);
                userList.NombreUsuario = TxtNameUser.Text;
                userList.Apellido = TxtApellido.Text;
                userList.Edad = Convert.ToInt32(TxtEdad.Text);
                userList.pass = TxtPass.Text;
                clsDUserlist.updateuser(userList);

            }
            carga();
            clear();
        }  
        
private void button1_Click_1(object sender, EventArgs e)
        {
            ClsDUserlist clsDUserlist = new ClsDUserlist();
            clsDUserlist.deletusuarios(Convert.ToInt32(TxtId.Text));
            carga();
            clear();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            
            carga();
            clear();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void dtgListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String ID = dtgListaUsuarios.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtgListaUsuarios.CurrentRow.Cells[1].Value.ToString();
            String Apellido = dtgListaUsuarios.CurrentRow.Cells[2].Value.ToString();
            String Edad = dtgListaUsuarios.CurrentRow.Cells[3].Value.ToString();
            String Pass = dtgListaUsuarios.CurrentRow.Cells[4].Value.ToString();

            TxtId.Text = ID;
            TxtNameUser.Text = Nombre;
            TxtApellido.Text = Apellido;
            TxtEdad.Text = Edad;
            TxtPass.Text = Pass;
        }
    }  
}



