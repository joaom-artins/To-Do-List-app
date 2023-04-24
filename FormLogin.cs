using Sistema.Properties;
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

namespace Sistema
{
    public partial class FormLogin : Form
    {

        Thread N1;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_cad_Click(object sender, EventArgs e)
        {
            Settings.Default["Usuario"] = tb_usu.Text.Trim();
            Settings.Default["Senha"] = tb_sen.Text.Trim();
            Settings.Default["ConfirmaSenha"] = tb_csen.Text.Trim();
            if (tb_csen.Text=="" || tb_sen.Text=="" || tb_usu.Text=="")
            {
                MessageBox.Show("Não deixe campos em branco");
                return;
            }
            if(tb_sen.Text!=tb_csen.Text)
            {
                MessageBox.Show("As senhas são diferentes");
                tb_sen.Focus();
                return;
            }
            Settings.Default.Save();
            this.Close();
            N1 = new Thread(FormInicio);
            N1.SetApartmentState(ApartmentState.MTA);
            N1.Start();
           

        }

        private void FormInicio()
        {
            Application.Run(new Form1());
        }
    }
}
