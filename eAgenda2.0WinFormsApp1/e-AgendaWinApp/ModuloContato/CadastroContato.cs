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
    public partial class CadastroContato : Form
    {
        Repositorio<Contato> _repositorioContato;
        private Contato? _contato;

        public CadastroContato(Contato contato)
        {
            InitializeComponent();
            _contato = contato;
            if (contato != null)
            {
                txtNome.Text = contato.Nome;
                txtemail.Text = contato.Email;
                txtTelefone.Text = contato.Telefone;
                txtEmpresa.Text = contato.Empresa;
                txtcargo.Text = contato.Cargo;
            }
        }

        public Contato Contato
        {

            get
            {
                return _contato!;
            }
            set
            {
                _contato = value;
                

            }
           
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }
        
      

        private void CadastroContato_Load(object sender, EventArgs e)
        {
           
        }
        
        public void btnGravar_Click(object sender, EventArgs e)
        {
            _contato!.Nome = txtNome.Text;
            _contato!.Email = txtemail.Text;
            _contato!.Telefone = txtTelefone.Text;
            _contato!.Empresa = txtEmpresa.Text;
            _contato!.Cargo = txtcargo.Text;
        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

