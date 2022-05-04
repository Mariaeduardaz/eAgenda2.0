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
        private RepositorioCompromisso _repositorioCompromisso;
        private RepositorioContato? _repositorioContato;

        public ListagemCompromisso(RepositorioCompromisso repositorioCompromisso, RepositorioContato repositorioContato)
        {
            InitializeComponent();
            _repositorioCompromisso = repositorioCompromisso;   
            _repositorioContato = repositorioContato;
            VisualizarFuturos();
            VisualizarPassados();
        }

        private void CarregarCompromisso()
        {
            VisualizarFuturos();
            VisualizarPassados();
        }



        private void btnInserirCompromisso_Click(object sender, EventArgs e)
        {
            CadastroCompromisso telaCompromisso = new ( new Compromisso(), _repositorioContato!);

            DialogResult resultado = telaCompromisso.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                _repositorioCompromisso.Inserir(telaCompromisso.Compromisso);
                VisualizarFuturos();
                VisualizarPassados();
            }



        }
        private void btnEditarCompromisso_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado =  null;

            if(listVisualizarPassados.SelectedIndex > -1)
            {
                compromissoSelecionado = (Compromisso)listVisualizarPassados.SelectedItem;
            }
            else
            {
                compromissoSelecionado = (Compromisso)listVisualizarFuturos.SelectedItem;          
            }

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("selecione um compromisso primeiro!",
                "compromisso editado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            


            Compromisso telacompromisso = new ();

            bool TemAlgo = VerificarSeTemRegistro(compromissoSelecionado, "Editar");
            if (!TemAlgo)
                return;

            telacompromisso.Assunto = compromissoSelecionado.Assunto;
            telacompromisso.Local = compromissoSelecionado.Local;
            telacompromisso.DataCompromisso = compromissoSelecionado.DataCompromisso;
            telacompromisso.HoraInicio = compromissoSelecionado.HoraInicio;
            telacompromisso.HoraFim = compromissoSelecionado.HoraFim;

            if(compromissoSelecionado.Contato != null)
             telacompromisso.Contato = compromissoSelecionado.Contato;

            CadastroCompromisso cadastroCompromisso = new(telacompromisso, _repositorioContato!);


            

            DialogResult resultado = cadastroCompromisso.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                _repositorioCompromisso.Editar(cadastroCompromisso.Compromisso);
                CarregarCompromisso();
            }
        }
        private void btnExcluirCompromisso_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = null;

            if (listVisualizarPassados.SelectedIndex > -1)
            {
                compromissoSelecionado = (Compromisso)listVisualizarPassados.SelectedItem;
            }
            else
            {
                compromissoSelecionado = (Compromisso)listVisualizarFuturos.SelectedItem;
            }


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
                _repositorioCompromisso.Excluir(compromissoSelecionado);
                CarregarCompromisso();
            }
        }
        private void VisualizarFuturos()
        {
            List<Compromisso> compromissosFuturos = _repositorioCompromisso.FiltrarCompromissos(x => x.DataCompromisso > DateTime.Now);
            listVisualizarFuturos.Items.Clear();
            foreach (Compromisso c in compromissosFuturos)
            {
                listVisualizarFuturos.Items.Add(c);
            }
        }

        private void VisualizarPassados()
        {
            List<Compromisso> compromissosPassados = _repositorioCompromisso.FiltrarCompromissos(x => x.DataCompromisso <= DateTime.Now);
            listVisualizarPassados.Items.Clear();
            foreach (Compromisso c in compromissosPassados)
            {
                listVisualizarPassados.Items.Add(c);
            }
        }
        private void btnContatoCompromisso_Click(object sender, EventArgs e)
        {

        }
        private bool VerificarSeTemRegistro(Compromisso compromissoSelecionado, string tipo)
        {
            bool temAlgo = _repositorioCompromisso.RegistroExistente();
            if (!temAlgo)
            {
                MessageBox.Show($"Nenhum compromisso para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (compromissoSelecionado == null)
            {
                MessageBox.Show($"Selecione um compromisso para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
    }

}
