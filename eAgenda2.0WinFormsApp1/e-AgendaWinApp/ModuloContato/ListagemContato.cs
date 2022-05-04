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

        RepositorioContato repositoriocontato;
        public ListagemContato(RepositorioContato _repositorioContato)
        {

            InitializeComponent();
            repositoriocontato = _repositorioContato;
            MostrarContatosNaTela();
        }



        private void btnInserirContato_Click(object sender, EventArgs e)
        {

            CadastroContato telaContato = new CadastroContato();
            telaContato.Contato = new Contato();

            DialogResult resultado = telaContato.ShowDialog();

            
            if (resultado == DialogResult.OK)
            {
                Contato descriocaCntt = telaContato.Contato;
                bool tituloNovo = VerificarExistentente(descriocaCntt);
                if (!tituloNovo)
                    return;

                string status = repositoriocontato.Inserir(telaContato.Contato);

                if (status.Trim() == "REGISTRO_VALIDO")
                    MessageBox.Show("Contato cadastrado com sucesso!", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"{status}\nTente novamente", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Error);


                MostrarContatosNaTela();
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
                MostrarContatosNaTela();
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
                MostrarContatosNaTela();
            }
        }

        private void btnContato_Click(object sender, EventArgs e) // visualizar
        {
            MostrarContatosNaTela();

        }


        private void MostrarContatosNaTelaPorCargo()
        {
            var contatosPorCargo = repositoriocontato.SelecionarTodos()
                                                   .OrderBy(x => x.Cargo)
                                                   .ToList();

            listContatos.Items.Clear();

            foreach (var c in contatosPorCargo)
            {
                listContatos.Items.Add(c);
            }

        }

        private void MostrarContatosNaTela()
        {
            List<Contato> contatos = repositoriocontato.SelecionarTodos();
            listContatos.Items.Clear();

            foreach (Contato c in contatos)
            {
                listContatos.Items.Add(c);
            }
        }

        private void button2_Click(object sender, EventArgs e) //ordenado por cargo
        {


            MostrarContatosNaTelaPorCargo();


        }
        private bool VerificarSeTemRegistro(Contato contatoSelecionado, string tipo)
        {
            bool temAlgo = repositoriocontato.RegistroExistente();
            if (!temAlgo)
            {
                MessageBox.Show($"Nenhum contato para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (contatoSelecionado == null)
            {
                MessageBox.Show($"Selecione um contato para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        private bool VerificarExistentente(Contato temp)
        {
            List<Contato> todosContatos = repositoriocontato.SelecionarTodos();

            foreach (Contato contatoJaRegistrado in todosContatos)
            {
                if (contatoJaRegistrado.Nome == temp.Nome)
                {
                    MessageBox.Show("O Nome do contato já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (contatoJaRegistrado.Email == temp.Email)
                {
                    MessageBox.Show("O Email do contato já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (contatoJaRegistrado.Telefone == temp.Telefone)
                {
                    MessageBox.Show("O Telefone do contato já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;


        }

    }
}

