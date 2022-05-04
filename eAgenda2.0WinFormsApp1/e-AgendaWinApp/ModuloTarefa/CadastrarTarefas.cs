using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda2._0WinFormsApp1
{
    public partial class CadastrarTarefas : Form
    {
        private Tarefa tarefa;
        public CadastrarTarefas()
        {
            InitializeComponent();
        }

       
        public Tarefa Tarefa
        {
            get
            {
                return tarefa;
            }
            set
            {
                tarefa = value;
                txtPrioridade.Text = tarefa.Prioridad.ToString();
                txtPrioridade.Text = tarefa.Titulo;
               


            }
        }
      

        private void btnNome_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Tarefa.Titulo = txtTitulo.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
