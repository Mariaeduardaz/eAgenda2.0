namespace eAgenda2._0WinFormsApp1
{
    partial class ListagemTarefas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionarIntens = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConcluirItens = new System.Windows.Forms.Button();
            this.listTarefas = new System.Windows.Forms.ListBox();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(12, 23);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(112, 34);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(144, 23);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 34);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionarIntens
            // 
            this.btnAdicionarIntens.Location = new System.Drawing.Point(406, 22);
            this.btnAdicionarIntens.Name = "btnAdicionarIntens";
            this.btnAdicionarIntens.Size = new System.Drawing.Size(156, 34);
            this.btnAdicionarIntens.TabIndex = 2;
            this.btnAdicionarIntens.Text = "Adicionar Itens";
            this.btnAdicionarIntens.UseVisualStyleBackColor = true;
            this.btnAdicionarIntens.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(275, 23);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(112, 34);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnConcluirItens
            // 
            this.btnConcluirItens.Location = new System.Drawing.Point(716, 20);
            this.btnConcluirItens.Name = "btnConcluirItens";
            this.btnConcluirItens.Size = new System.Drawing.Size(156, 34);
            this.btnConcluirItens.TabIndex = 4;
            this.btnConcluirItens.Text = "Concluir Itens";
            this.btnConcluirItens.UseVisualStyleBackColor = true;
            // 
            // listTarefas
            // 
            this.listTarefas.FormattingEnabled = true;
            this.listTarefas.ItemHeight = 25;
            this.listTarefas.Location = new System.Drawing.Point(12, 86);
            this.listTarefas.Name = "listTarefas";
            this.listTarefas.Size = new System.Drawing.Size(877, 354);
            this.listTarefas.TabIndex = 5;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(579, 20);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(112, 37);
            this.btnVisualizar.TabIndex = 6;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // ListagemTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(913, 468);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.listTarefas);
            this.Controls.Add(this.btnConcluirItens);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionarIntens);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ListagemTarefas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Agenda2.0";
            this.Load += new System.EventHandler(this.ListagemTarefas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionarIntens;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConcluirItens;
        private System.Windows.Forms.ListBox listTarefas;
        private System.Windows.Forms.Button btnVisualizar;
    }
}
