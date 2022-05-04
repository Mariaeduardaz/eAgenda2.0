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
    public partial class CadastroCompromisso : Form
    {
        
            RepositorioContato _repositorioContato;
            Compromisso? _compromisso;
            public CadastroCompromisso(Compromisso compromissoVazio, RepositorioContato repositorioContato)
            {
                InitializeComponent();
                _compromisso = compromissoVazio;
                _repositorioContato = repositorioContato;

                List<Contato> contatos = _repositorioContato.SelecionarTodos();

                comboBoxContato.Items.Clear();
                foreach (Contato c in contatos)
            {
                comboBoxContato.Items.Add(c);
            }

            if (_compromisso != null)
               {
                txtAssunto.Text = _compromisso.Assunto;
                txtLocal.Text = _compromisso.Local;
                maskedBoxData.Text = _compromisso.DataCompromisso.ToString();
                maskedBoxHorarioInicio.Text = _compromisso.HoraInicio.ToString();
                maskedBoxHorarioFinal.Text = _compromisso.HoraFim.ToString();
                if (_compromisso.Contato.RetornarNome() != null)
                    comboBoxContato.Text = _compromisso.Contato.RetornarNome();

            }

            }
        public Compromisso Compromisso
        {
            get { return _compromisso!; }
            set { _compromisso = value; }
        }



        private void CadastroCompromisso_Load(object sender, EventArgs e)
            {

            }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            _compromisso!.Assunto = txtAssunto.Text;
            _compromisso.Local = txtLocal.Text;
            _compromisso.DataCompromisso = DateTime.Parse(maskedBoxData.Text);
            _compromisso.HoraInicio = TimeSpan.Parse(maskedBoxHorarioInicio.Text);
            _compromisso.HoraFim = TimeSpan.Parse(maskedBoxHorarioFinal.Text);

            comboBoxContato.Items.Insert(0, "(nenhum contato)");
            if (comboBoxContato.SelectedItem == null)
            {
                comboBoxContato.SelectedItem = _compromisso.Contato;
            }
            _compromisso.Contato = (Contato)comboBoxContato.SelectedItem;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
