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
    public partial class ListagemContato : Form
    {

        private RepositorioContato repositoriocontato;
        public ListagemContato()
        {
            repositoriocontato = new RepositorioContato();
            InitializeComponent();
            CarregarContatos();
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositoriocontato.SelecionarTodos();

            listContatos.Items.Clear();
            foreach (Contato c in contatos)
            {
                listContatos.Items.Add(c);
            }
        }

        private void btnInserirContato_Click(object sender, EventArgs e)
        {
            CadastroContato telaContato = new CadastroContato(new Contato());
            
           

            DialogResult resultado = telaContato.ShowDialog();

            if (resultado == DialogResult.OK)
            {
               
                repositoriocontato.Inserir(telaContato.Contato);
                CarregarContatos();
            }
        }

        private void Contato_Load(object sender, EventArgs e)
        {

        }

        private void btnEditarContato_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionada = (Contato)listContatos.SelectedItem;

            if (contatoSelecionada == null)
            {
                MessageBox.Show("selecione uma contato primeiro!",
                "contato editado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;


            }

            CadastroContato telacontato = new CadastroContato(new Contato());

            telacontato.Contato = contatoSelecionada;

            DialogResult resultado = telacontato.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositoriocontato.Editar(telacontato.Contato);
                CarregarContatos();
            }

        }

        private void btnExcluirContato_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("selecione uma contato primeiro!",
                "Exclusao de contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;


            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir um contato?",
                "Exclusao de contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositoriocontato.Excluir(contatoSelecionado);
                CarregarContatos();
            }
        }

        private void btnContato_Click(object sender, EventArgs e) // visualizar
        {
            CarregarContatos();
        }

        private void button2_Click(object sender, EventArgs e) //ordenado por cargo
        {
            List<Contato> contatos = repositoriocontato.SelecionarTodos();
            listContatos.Items.Clear();

            foreach (Contato c in contatos)
                listContatos.Items.Add(c);
        }
    }
    
}

