using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class FormBienvenida : Form
    {
        public FormBienvenida()
        {
            InitializeComponent();
        }

        private void FormBienvenida_Load(object sender, EventArgs e)
        {

        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnINICIARSESION_Click(object sender, EventArgs e)
        {
            FormLogin formuLogin = new FormLogin();

            formuLogin.Show();
        }

        private void btnREGISTRARME_Click(object sender, EventArgs e)
        {
            FormRegistro formuRegistro = new FormRegistro();

            formuRegistro.Show();
        }
    }
}
