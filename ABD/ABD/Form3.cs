﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABD
{
    public partial class Form3 : Form
    {
        Form2 f2 = new Form2();
        Ventana1 v = new Ventana1();
        public Form3()
        {
            InitializeComponent();
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            bdusetxt.Text =f2.nombrebd.Text;
            v.ListaDirectorio(dirUso);
        }
    }
}
