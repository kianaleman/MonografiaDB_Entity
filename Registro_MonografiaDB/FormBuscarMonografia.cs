﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_MonografiaDB
{
    public partial class FormBuscarMonografia : Form
    {
        public FormBuscarMonografia()
        {
            InitializeComponent();
        }

        private void FormBuscarMonografia_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}