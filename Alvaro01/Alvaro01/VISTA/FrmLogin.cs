using Alvaro01.DOMINIO;
using Alvaro01.NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alvaro01
{
    public partial class PanelLogin : Form
    {
        public PanelLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Login log = new Login();

            log.Ususario = TxtUser.Text;
            log.Password = TxtPass.Text;

            ClsLogin ClsL = new ClsLogin();

            int VariableDeEvaluacion = ClsL.Ingresar(log);

            if (VariableDeEvaluacion == 1)
            {

                MessageBox.Show("Welcome");

            }
            else {
                MessageBox.Show("La contraseña o el Usuario No coinciden.");
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
