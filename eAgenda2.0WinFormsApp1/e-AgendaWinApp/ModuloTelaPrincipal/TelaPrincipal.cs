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
    public partial class TelaPrincipal : Form
    {
        RepositorioContato repositorioContato = new();
        RepositorioCompromisso repositorioCompromisso = new();
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //tarefa
        {
            ListagemTarefas listagemtarefa = new ListagemTarefas();
            listagemtarefa.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) //contatos
        {
            ListagemContato listagemContato = new ListagemContato();
            listagemContato.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           ListagemCompromisso listagemCompromisso = new ListagemCompromisso(repositorioCompromisso, repositorioContato);
            listagemCompromisso.ShowDialog();
        }
    }
}
