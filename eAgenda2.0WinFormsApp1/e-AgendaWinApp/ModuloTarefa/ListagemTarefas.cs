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
    public partial class ListagemTarefas : Form
    {
        private RepositorioTarefa repositorioTarefa;
        public ListagemTarefas()
        {
            InitializeComponent();
            repositorioTarefa = new RepositorioTarefa();
            
            CarregarTarefas();
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            listTarefas.Items.Clear();
            foreach (Tarefa t in tarefas)
            {
                listTarefas.Items.Add(t);
            }
        }

        private void ListagemTarefas_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // cadastrar itens
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefas.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("selecione uma tarefa primeiro!",
                "Exclusao de tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;


            }
            AdicionarItensTarefa tela = new AdicionarItensTarefa(tarefaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itens = tela.ItensAdicionados;

                repositorioTarefa.AdicionarItens(tarefaSelecionada, itens);

                CarregarTarefas();
            }



        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastrarTarefas tela = new CadastrarTarefas();
            tela.Tarefa = new Tarefa();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Inserir(tela.Tarefa);
                CarregarTarefas();
            }







        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefas.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("selecione uma tarefa primeiro!",
                "Tarefa editada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;


            }

            CadastrarTarefas tela = new CadastrarTarefas();

            tela.Tarefa = tarefaSelecionada;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Editar(tela.Tarefa);
                CarregarTarefas();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefas.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("selecione uma tarefa primeiro!",
                "Exclusao de tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;


            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a tarefa?",
                "Exclusao de tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Excluir(tarefaSelecionada);
                CarregarTarefas();
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefas.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("selecione uma tarefa primeiro!",
                "Exclusao de tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;


            }
            VisualizacaoDaTarefa tela = new VisualizacaoDaTarefa(tarefaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itensConcluidos = tela.ItensConcluidos;

                List<ItemTarefa> itensPendentes = tela.ItensPendentes;

                repositorioTarefa.VisualizarItens(tarefaSelecionada, itensConcluidos, itensPendentes);
                CarregarTarefas();
            }
            
        }

        private void listTarefas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
