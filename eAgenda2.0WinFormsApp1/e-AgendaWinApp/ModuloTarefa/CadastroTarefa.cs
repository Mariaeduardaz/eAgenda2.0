﻿using System;
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
    public partial class CadastroTarefa : Form 
    {
        private Tarefa tarefa;
        public CadastroTarefa(Tarefa _tarefa)
        {
            InitializeComponent();
            tarefa = _tarefa;
            if(tarefa != null)
            {
                
            }
        }

       
        public Tarefa Tarefa
        {
            get 
            {
                return tarefa;
            }
            set
            {
                tarefa = value;
                txtPrioridade.Text = tarefa.Prioridad.ToString();
                txtTitulo.Text = tarefa.Titulo;
                txtData.Text = tarefa.DataCriacao.Date.ToString();
                
                
            }
        }

       

        private void btnGravar_Click(object sender, EventArgs e)
        {
           

            Tarefa.Titulo = txtTitulo.Text;
           
            
        }

      

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
