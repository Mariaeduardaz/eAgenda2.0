namespace eAgenda2._0WinFormsApp1
{
    partial class CadastrarTarefas
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
            this.txtPrioridade = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnTelefone = new System.Windows.Forms.Label();
            this.btnNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPrioridade
            // 
            this.txtPrioridade.AccessibleDescription = "";
            this.txtPrioridade.AllowDrop = true;
            this.txtPrioridade.Location = new System.Drawing.Point(135, 41);
            this.txtPrioridade.Name = "txtPrioridade";
            this.txtPrioridade.Size = new System.Drawing.Size(238, 31);
            this.txtPrioridade.TabIndex = 34;
            this.txtPrioridade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(272, 226);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 54);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(155, 226);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(111, 54);
            this.btnGravar.TabIndex = 32;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(135, 93);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(238, 31);
            this.txtTitulo.TabIndex = 31;
            // 
            // btnTelefone
            // 
            this.btnTelefone.AutoSize = true;
            this.btnTelefone.Location = new System.Drawing.Point(36, 99);
            this.btnTelefone.Name = "btnTelefone";
            this.btnTelefone.Size = new System.Drawing.Size(56, 25);
            this.btnTelefone.TabIndex = 30;
            this.btnTelefone.Text = "Titulo";
            // 
            // btnNome
            // 
            this.btnNome.AutoSize = true;
            this.btnNome.Location = new System.Drawing.Point(36, 41);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(93, 25);
            this.btnNome.TabIndex = 29;
            this.btnNome.Text = "Prioridade";
            this.btnNome.Click += new System.EventHandler(this.btnNome_Click);
            // 
            // CadastrarTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(396, 304);
            this.Controls.Add(this.txtPrioridade);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.btnTelefone);
            this.Controls.Add(this.btnNome);
            this.Name = "CadastrarTarefas";
            this.Text = "CadastrarTarefas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPrioridade;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label btnTelefone;
        private System.Windows.Forms.Label btnNome;
    }
}