﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revisao1
{
    public partial class divisao : Form
    {
        public divisao()
        {
            InitializeComponent();
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tx_valor1.Text);
            int b = Convert.ToInt32(tx_valor2.Text);

            int c = a / b;


           lb_resultado.Text = c.ToString();
            
       

        
    }
}
