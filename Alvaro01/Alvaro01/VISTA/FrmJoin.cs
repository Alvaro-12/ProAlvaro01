﻿using System;
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
    public partial class FrmJoin : Form
    {
        public FrmJoin()
        {
            InitializeComponent();
        }

        private void FrmJoin_Load(object sender, EventArgs e)
        {
            ClsJoin join = new ClsJoin();
            List<List<Object>> Matriz = new List<List<Object>>();
            Matriz = join.joinUsuarioType();

            for (int i = 0; i < Matriz.Count; i++) {
                dataGridView1.Rows.Add(Matriz[i][0], Matriz[i][1], Matriz[i][2], Matriz[i][3]);
            
            }
        }
    }
}
