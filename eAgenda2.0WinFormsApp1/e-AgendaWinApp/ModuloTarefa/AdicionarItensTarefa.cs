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
    public partial class AdicionarItensTarefa : Form
    {
        private readonly Tarefa tarefa;

        public AdicionarItensTarefa(Tarefa tarefa)
        {
            InitializeComponent();
            this.tarefa = tarefa;
            labelTituloTarefa.Text = tarefa.Titulo;
           

            foreach (ItemTarefa item in tarefa.Itens)
            {
                listItensTarefa.Items.Add(item);
            }
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public List<ItemTarefa> ItensAdicionados
        {
            get
            {
                return listItensTarefa.Items.Cast<ItemTarefa>().ToList();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            List<string> titulos = ItensAdicionados.Select(x => x.Titulo).ToList();


            if  (titulos.Count == 0 || titulos.Contains(txtTituloItem.Text) == false)
            {
                ItemTarefa itemTarefa = new ItemTarefa();

                itemTarefa.Titulo = txtTituloItem.Text;

                listItensTarefa.Items.Add(itemTarefa);

            }

           



        }

        private void AdicionarItensTarefa_Load(object sender, EventArgs e)
        {

        }
    }
}
