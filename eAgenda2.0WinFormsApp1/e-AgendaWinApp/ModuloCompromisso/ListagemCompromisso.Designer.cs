namespace eAgenda2._0WinFormsApp1
{
    partial class ListagemCompromisso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnContatoPrioridade = new System.Windows.Forms.Button();
            this.listCompromissos = new System.Windows.Forms.ListBox();
            this.btnExcluirPrioridade = new System.Windows.Forms.Button();
            this.btnEditarPrioridade = new System.Windows.Forms.Button();
            this.btnInserirPrioridade = new System.Windows.Forms.Button();
            this.listVisualizarNaSemana = new System.Windows.Forms.Button();
            this.listVisualizarFuturos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnContatoPrioridade
            // 
            this.btnContatoPrioridade.Location = new System.Drawing.Point(435, 12);
            this.btnContatoPrioridade.Name = "btnContatoPrioridade";
            this.btnContatoPrioridade.Size = new System.Drawing.Size(112, 34);
            this.btnContatoPrioridade.TabIndex = 15;
            this.btnContatoPrioridade.Text = "Visualizar";
            this.btnContatoPrioridade.UseVisualStyleBackColor = true;
            // 
            // listCompromissos
            // 
            this.listCompromissos.FormattingEnabled = true;
            this.listCompromissos.ItemHeight = 25;
            this.listCompromissos.Location = new System.Drawing.Point(12, 110);
            this.listCompromissos.Name = "listCompromissos";
            this.listCompromissos.Size = new System.Drawing.Size(535, 354);
            this.listCompromissos.TabIndex = 14;
            // 
            // btnExcluirPrioridade
            // 
            this.btnExcluirPrioridade.Location = new System.Drawing.Point(295, 12);
            this.btnExcluirPrioridade.Name = "btnExcluirPrioridade";
            this.btnExcluirPrioridade.Size = new System.Drawing.Size(112, 34);
            this.btnExcluirPrioridade.TabIndex = 13;
            this.btnExcluirPrioridade.Text = "Excluir";
            this.btnExcluirPrioridade.UseVisualStyleBackColor = true;
            this.btnExcluirPrioridade.Click += new System.EventHandler(this.btnExcluirPrioridade_Click);
            // 
            // btnEditarPrioridade
            // 
            this.btnEditarPrioridade.Location = new System.Drawing.Point(157, 12);
            this.btnEditarPrioridade.Name = "btnEditarPrioridade";
            this.btnEditarPrioridade.Size = new System.Drawing.Size(112, 34);
            this.btnEditarPrioridade.TabIndex = 12;
            this.btnEditarPrioridade.Text = "Editar";
            this.btnEditarPrioridade.UseVisualStyleBackColor = true;
            this.btnEditarPrioridade.Click += new System.EventHandler(this.btnEditarPrioridade_Click);
            // 
            // btnInserirPrioridade
            // 
            this.btnInserirPrioridade.Location = new System.Drawing.Point(21, 12);
            this.btnInserirPrioridade.Name = "btnInserirPrioridade";
            this.btnInserirPrioridade.Size = new System.Drawing.Size(112, 34);
            this.btnInserirPrioridade.TabIndex = 11;
            this.btnInserirPrioridade.Text = "Inserir";
            this.btnInserirPrioridade.UseVisualStyleBackColor = true;
            this.btnInserirPrioridade.Click += new System.EventHandler(this.btnInserirCompromisso_Click);
            // 
            // listVisualizarNaSemana
            // 
            this.listVisualizarNaSemana.Location = new System.Drawing.Point(21, 52);
            this.listVisualizarNaSemana.Name = "listVisualizarNaSemana";
            this.listVisualizarNaSemana.Size = new System.Drawing.Size(275, 34);
            this.listVisualizarNaSemana.TabIndex = 16;
            this.listVisualizarNaSemana.Text = "Visualizar da semana";
            this.listVisualizarNaSemana.UseVisualStyleBackColor = true;
            this.listVisualizarNaSemana.Click += new System.EventHandler(this.btnVisualizarNaSemana_Click);
            // 
            // listVisualizarFuturos
            // 
            this.listVisualizarFuturos.Location = new System.Drawing.Point(302, 52);
            this.listVisualizarFuturos.Name = "listVisualizarFuturos";
            this.listVisualizarFuturos.Size = new System.Drawing.Size(245, 34);
            this.listVisualizarFuturos.TabIndex = 17;
            this.listVisualizarFuturos.Text = "Visualizar futuros";
            this.listVisualizarFuturos.UseVisualStyleBackColor = true;
            this.listVisualizarFuturos.Click += new System.EventHandler(this.btnVisualizarFuturos_Click);
            // 
            // ListagemCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(588, 486);
            this.Controls.Add(this.listVisualizarFuturos);
            this.Controls.Add(this.listVisualizarNaSemana);
            this.Controls.Add(this.btnContatoPrioridade);
            this.Controls.Add(this.listCompromissos);
            this.Controls.Add(this.btnExcluirPrioridade);
            this.Controls.Add(this.btnEditarPrioridade);
            this.Controls.Add(this.btnInserirPrioridade);
            this.Name = "ListagemCompromisso";
            this.Text = "ListagemCompromisso";
            this.Load += new System.EventHandler(this.ListagemCompromisso_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContatoPrioridade;
        private System.Windows.Forms.ListBox listCompromissos;
        private System.Windows.Forms.Button btnExcluirPrioridade;
        private System.Windows.Forms.Button btnEditarPrioridade;
        private System.Windows.Forms.Button btnInserirPrioridade;
        private System.Windows.Forms.Button listVisualizarNaSemana;
        private System.Windows.Forms.Button listVisualizarFuturos;
    }
}