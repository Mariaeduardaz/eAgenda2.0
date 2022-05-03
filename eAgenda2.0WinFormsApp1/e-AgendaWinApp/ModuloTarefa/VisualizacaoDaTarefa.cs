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
    public partial class VisualizacaoDaTarefa : Form
    {
        private readonly Tarefa tarefa;

        public VisualizacaoDaTarefa(Tarefa tarefa)
        {
            InitializeComponent();
            this.tarefa = tarefa;

            labelVisualizacaoTarefa.Text = tarefa.Titulo;
            ApresentarItensTarefas(tarefa);

        }

        private void ApresentarItensTarefas(Tarefa tarefa)
        {
            int i = 0;

            foreach (var item in tarefa.Itens)
            {
                listItensTarefa.Items.Add(item);

                if (item.Concluido)
                    listItensTarefa.SetItemChecked(0, true);


                i++;
            }
        }

        public List<ItemTarefa> ItensConcluidos
        {
            get
            {
                return listItensTarefa.CheckedItems.Cast<ItemTarefa>().ToList();
            }
        }

        public List<ItemTarefa> ItensPendentes
        {
            get
            {
                return listItensTarefa.Items
                    .Cast<ItemTarefa>()
                    .Except(ItensConcluidos)
                    .ToList();
            }
        }

        private void VisualizacaoDaTarefa_Load(object sender, EventArgs e)
        {

        }
       
    }
}
