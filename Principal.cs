using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class FormPrin : Form
    {
        string tarefa;
        List<string>Tarefas=new List<string>();
        public FormPrin()
        {
            InitializeComponent();
            
        }
        private void atualiza_lb(ListBox lb, List<string> l)
        {
            lb.DataSource = null;
            lb.DataSource = l;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_Tarefa.Text == "")
            {
                MessageBox.Show("Não deixe o espaço em branco");
                tb_Tarefa.Focus();
            }
            else
            {
                tarefa= tb_Tarefa.Text.Trim();
               
                Tarefas.Add(tarefa); 
                lb_Tarefas.Items.Add(tarefa);
                tb_Tarefa.Clear();
                tb_Tarefa.Focus();
                
            }
            
        }

        private void FormPrin_Load(object sender, EventArgs e)
        {

        }

        private void btn_Conc_Click(object sender, EventArgs e)
        {
            
            if (lb_Tarefas.SelectedIndex < 0)
            {
                MessageBox.Show("Não há itens para remover");
                return;
            }
            else
            {
                Tarefas.RemoveAt(lb_Tarefas.SelectedIndex);
                atualiza_lb(lb_Tarefas, Tarefas);
            }
        }
        
    }
}
