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
        Repositorio<Contato> _repositorioContato;
        Compromisso? _compromisso;
        public CadastroCompromisso(Compromisso compromissoVazio, Repositorio<Contato> repositorioContato)
        {
            InitializeComponent();
            _compromisso = compromissoVazio;
            _repositorioContato = repositorioContato;

            List<Contato> contatos = _repositorioContato.SelecionarTodos();

           

            if (_compromisso != null)
            {
                btnAssunto.Text = _compromisso.Assunto;
                btnLocal.Text = _compromisso.Local;
                btnDataDoCompromisso.Text = _compromisso.DataCompromisso.ToString();
                btnHoraDeInicio.Text = _compromisso.HoraInicio.ToString();
                btnHoraDoTermino.Text = _compromisso.HoraFim.ToString();
               
            }
        }

        public Compromisso Compromisso
        {
            get { return _compromisso!; }
            set { _compromisso = value; }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            _compromisso!.Assunto = btnAssunto.Text;
            _compromisso.Local = btnLocal.Text;
            _compromisso.DataCompromisso = DateTime.Parse(btnDataDoCompromisso.Text);
            _compromisso.HoraInicio = TimeSpan.Parse(btnHoraDeInicio.Text);
            _compromisso.HoraFim = TimeSpan.Parse(btnHoraDoTermino.Text);

           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastroCompromisso_Load(object sender, EventArgs e)
        {

        }
    }
}
