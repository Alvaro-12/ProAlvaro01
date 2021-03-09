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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        public String usuarioEstao;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            label2.Text = usuarioEstao; 

        }

        private void clickAquiParaMasInformaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frm = new FrmAcercaDe();
            frm.MdiParent = this;
            frm.Show(); 
        }

        private void arreglosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaVisualDeUsuarios frmVisual = new FrmListaVisualDeUsuarios();
            frmVisual.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sumasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperaciones frmOperaciones = new  FrmOperaciones();
            frmOperaciones.Show();
        }

        private void restasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperaciones frmOperaciones = new FrmOperaciones();
            frmOperaciones.Show();
        }

        private void matematicasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.Show();
        }
    }
}
