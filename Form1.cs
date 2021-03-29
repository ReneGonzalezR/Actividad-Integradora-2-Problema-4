using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Integradora_2_Problema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblEnvio.Text = "0";
            lblTotal.Text = "0";
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            double cantidad = Convert.ToDouble(txtPedido.Text);
            double envio = 0.0;
            double total = 0.0;

            if (cantidad < 3000)
            {
                envio = cantidad * 0.20;
                total = cantidad + envio;
                lblEnvio.Text = string.Format("$ {0}", envio);
                lblTotal.Text = string.Format("$ {0}", total);
            }
            else if( cantidad >= 3000 && cantidad <20000 )
            {
                lblEnvio.Text = "Gratis";
                lblTotal.Text = string.Format("$ {0}", cantidad);
            }
            else if(cantidad >= 20000)
            {
                lblEnvio.Text = "¡¡¡¡¡Enviar por transferencia!!!!!";
                lblTotal.Text = string.Format("$ {0}", cantidad);
            }
        }
    }
}
