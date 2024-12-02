using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academica
{
    public partial class FrmInicio : Form
    {
     
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "usuario" && txtClave.Text == "clave")
            {
                principal principal = new principal();
                this.Hide();
                principal.Show();

            }
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "usuario" && txtClave.Text == "clave")
            {
                principal principal = new principal();
                this.Hide();
                principal.Show();

            }
            else
            {
                MessageBox.Show("los datos ingresados son incorrectos");
            }
        }
    }
}


            
       
   



