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
    public partial class FrmJoinVista : Form
    {
        public FrmJoinVista()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            load();
        }

        void load() {
            dataGridView1.Rows.Clear();  
            using (programacionEntities db = new programacionEntities()) {

                var consulta = (from user in db.UserList1
                               from type in db.TypeOfUser
                               where user.IdTypeOfUser == type.IdTypeOfUser && user.NombreUsuario.Contains(textBox1.Text)
                               select new 
                               {
                                   user.NombreUsuario,
                                   type.TypeofUserName

                               }
                               ).ToList();
                foreach (var iteracion in consulta) {
                    dataGridView1.Rows.Add(iteracion.NombreUsuario, iteracion.TypeofUserName);
                }


            }
         
        
        }

        private void FrmJoinVista_Load(object sender, EventArgs e)
        {

        }
    }

}
