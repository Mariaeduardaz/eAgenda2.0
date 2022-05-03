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
    public partial class CadastroTarefa : Form 
    {
        private Tarefa tarefa;
        public CadastroTarefa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                txtTitulo.Text = tarefa.Titulo;
                txtData.Text = tarefa.DataCriacao.Date.ToString();
                
                
            }
        }

       

        private void btnGravar_Click(object sender, EventArgs e)
        {
           

            Tarefa.Titulo = txtTitulo.Text;
           
            
        }

        private void CadastroTarefa_Load(object sender, EventArgs e)
        {
            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
