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
            this.btnInserirCompromisso = new System.Windows.Forms.Button();
            this.btnEditarCompromisso = new System.Windows.Forms.Button();
            this.btnExcluirCompromisso = new System.Windows.Forms.Button();
            this.listVisualizarFuturos = new System.Windows.Forms.ListBox();
            this.btnContatoCompromisso = new System.Windows.Forms.Button();
            this.listVisualizarPassados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInserirCompromisso
            // 
            this.btnInserirCompromisso.Location = new System.Drawing.Point(44, 21);
            this.btnInserirCompromisso.Name = "btnInserirCompromisso";
            this.btnInserirCompromisso.Size = new System.Drawing.Size(112, 34);
            this.btnInserirCompromisso.TabIndex = 13;
            this.btnInserirCompromisso.Text = "Inserir";
            this.btnInserirCompromisso.UseVisualStyleBackColor = true;
            this.btnInserirCompromisso.Click += new System.EventHandler(this.btnInserirCompromisso_Click);
            // 
            // btnEditarCompromisso
            // 
            this.btnEditarCompromisso.Location = new System.Drawing.Point(180, 21);
            this.btnEditarCompromisso.Name = "btnEditarCompromisso";
            this.btnEditarCompromisso.Size = new System.Drawing.Size(112, 34);
            this.btnEditarCompromisso.TabIndex = 14;
            this.btnEditarCompromisso.Text = "Editar";
            this.btnEditarCompromisso.UseVisualStyleBackColor = true;
            this.btnEditarCompromisso.Click += new System.EventHandler(this.btnEditarCompromisso_Click);
            // 
            // btnExcluirCompromisso
            // 
            this.btnExcluirCompromisso.Location = new System.Drawing.Point(318, 21);
            this.btnExcluirCompromisso.Name = "btnExcluirCompromisso";
            this.btnExcluirCompromisso.Size = new System.Drawing.Size(112, 34);
            this.btnExcluirCompromisso.TabIndex = 15;
            this.btnExcluirCompromisso.Text = "Excluir";
            this.btnExcluirCompromisso.UseVisualStyleBackColor = true;
            this.btnExcluirCompromisso.Click += new System.EventHandler(this.btnExcluirCompromisso_Click);
            // 
            // listVisualizarFuturos
            // 
            this.listVisualizarFuturos.FormattingEnabled = true;
            this.listVisualizarFuturos.ItemHeight = 25;
            this.listVisualizarFuturos.Location = new System.Drawing.Point(44, 98);
            this.listVisualizarFuturos.Name = "listVisualizarFuturos";
            this.listVisualizarFuturos.Size = new System.Drawing.Size(577, 129);
            this.listVisualizarFuturos.TabIndex = 16;
            // 
            // btnContatoCompromisso
            // 
            this.btnContatoCompromisso.Location = new System.Drawing.Point(458, 21);
            this.btnContatoCompromisso.Name = "btnContatoCompromisso";
            this.btnContatoCompromisso.Size = new System.Drawing.Size(112, 34);
            this.btnContatoCompromisso.TabIndex = 17;
            this.btnContatoCompromisso.Text = "Visualizar";
            this.btnContatoCompromisso.UseVisualStyleBackColor = true;
            this.btnContatoCompromisso.Click += new System.EventHandler(this.btnContatoCompromisso_Click);
            // 
            // listVisualizarPassados
            // 
            this.listVisualizarPassados.FormattingEnabled = true;
            this.listVisualizarPassados.ItemHeight = 25;
            this.listVisualizarPassados.Location = new System.Drawing.Point(44, 259);
            this.listVisualizarPassados.Name = "listVisualizarPassados";
            this.listVisualizarPassados.Size = new System.Drawing.Size(577, 129);
            this.listVisualizarPassados.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Compromisso futuro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Compromisso Passado";
            // 
            // ListagemCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(660, 416);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listVisualizarPassados);
            this.Controls.Add(this.btnContatoCompromisso);
            this.Controls.Add(this.listVisualizarFuturos);
            this.Controls.Add(this.btnExcluirCompromisso);
            this.Controls.Add(this.btnEditarCompromisso);
            this.Controls.Add(this.btnInserirCompromisso);
            this.Name = "ListagemCompromisso";
            this.Text = "ListagemCompromisso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserirCompromisso;
        private System.Windows.Forms.Button btnEditarCompromisso;
        private System.Windows.Forms.Button btnExcluirCompromisso;
        private System.Windows.Forms.ListBox listVisualizarFuturos;
        private System.Windows.Forms.Button btnContatoCompromisso;
        private System.Windows.Forms.ListBox listVisualizarPassados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}