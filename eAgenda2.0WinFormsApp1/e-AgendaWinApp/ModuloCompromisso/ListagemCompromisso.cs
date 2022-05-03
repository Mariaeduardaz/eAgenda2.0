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
    public partial class ListagemCompromisso : Form
    {
        private RepositorioCompromisso repositorioCompromisso;
        public ListagemCompromisso ()
        {
            repositorioCompromisso = new RepositorioCompromisso();
            InitializeComponent();
            CarregarCompromisso();
        }

        private void CarregarCompromisso()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            listCompromissos.Items.Clear();
            foreach (Compromisso cp in compromissos)
            {
                listCompromissos.Items.Add(cp);
            }
        }

        private void btnInserirCompromisso_Click(object sender, EventArgs e)
        { 
            CadastroCompromisso telaCompromisso = new CadastroCompromisso(new Compromisso());



            DialogResult resultado = telaCompromisso.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                repositorioCompromisso.Inserir(telaCompromisso.Compromisso);
                CarregarCompromisso();
            }
        }

        private void ListagemCompromisso_Load(object sender, EventArgs e)
        {

        }

        private void btnEditarPrioridade_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listCompromissos.SelectedItem;

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("selecione um compromisso primeiro!",
                "compromisso editado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;


            }

            CadastroCompromisso telacompromisso = new CadastroCompromisso(new Contato());

            telacompromisso.Compromisso = compromissoSelecionado;

            DialogResult resultado = telacompromisso.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Editar(telacompromisso.Compromisso);
                CarregarCompromisso();
            }

        }

        private void btnExcluirPrioridade_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listCompromissos.SelectedItem;

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("selecione um compromisso primeiro!",
                "Exclusao de compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;


            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir um compromisso?",
                "Exclusao de compromisso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Excluir(compromissoSelecionado);
                CarregarCompromisso();
            }
        }

        private void btnVisualizarFuturos_Click(object sender, EventArgs e)
        {
            List<Compromisso> compromissosFuturos = repositorioCompromisso.FiltrarCompromissos(x => x.DataCompromisso > DateTime.Now);
            listVisualizarFuturos.Items.Clear();
            foreach (Compromisso c in compromissosFuturos)
            {
                listVisualizarFuturos.Items.Add(c);
            }
        }

        private void btnVisualizarNaSemana_Click(object sender, EventArgs e)
        {
            List<Compromisso> compromissosPassados = repositorioCompromisso.FiltrarCompromissos(x => x.DataCompromisso <= DateTime.Now);
            listVisualizarNaSemana.Items.Clear();
            foreach (Compromisso c in compromissosPassados)
            {
                listVisualizarNaSemana.Items.Add(c);
            }
        }
    }
}
