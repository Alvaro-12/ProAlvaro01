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
    public partial class FrmOperaciones : Form
    {
        public FrmOperaciones()
        {
            InitializeComponent();
        }

        private void Lable1_Click(object sender, EventArgs e)
        {

        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            try
            {

                int resta;
                resta = Convert.ToInt32(TxtDato1.Text) - Convert.ToInt32(TxtDato2.Text);

                TxtResultado.Text = resta.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese bien sus datos");
            }


        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            try
            {

                int suma;
                suma = Convert.ToInt32(TxtDato1.Text) + Convert.ToInt32(TxtDato2.Text);

                TxtResultado.Text = suma.ToString();

            }
            catch (Exception ) {

                MessageBox.Show("Ingrese bien sus datos");
             }
            //TxtResultado.Text = TxtDato1.Text + TxtDato2.Text;
        }
    }
}
