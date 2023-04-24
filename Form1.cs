using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Sistema.Properties;

namespace Sistema
{
   
    public partial class Form1 : Form
    {
        string Usuario, senha;
       
        Thread N1;
        Thread N2;
        public Form1()
        {
            InitializeComponent();
            Usuario = Properties.Settings.Default.Usuario;
            senha= Properties.Settings.Default.Senha;
        }

        private void btn_cad_Click(object sender, EventArgs e)
        {
            this.Close();
            N1 = new Thread(Formlogin);
            N1.SetApartmentState(ApartmentState.MTA);
            N1.Start();
        }

        private void btn_ent_Click(object sender, EventArgs e)
        {
            if (txt_use.Text == Usuario.Trim() && txt_sen.Text == senha)
            {
                this.Close();
                N2 = new Thread(FormPrin);
                N2.SetApartmentState(ApartmentState.MTA);
                N2.Start();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos");
                return;
            }
            
        }

        private void FormPrin()
        {
            Application.Run(new FormPrin());
            
        }

        private void Formlogin()
        {
            Application.Run(new FormLogin());
        }
    }
}
