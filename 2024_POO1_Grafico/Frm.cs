﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_POO1_Grafico
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }
        public virtual void Sair()
        {
            Close();
        }
        public virtual void ConhecaObj(Object obj)
        { 
        
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }
    }
}