namespace eAgenda2._0WinFormsApp1
{
    partial class ListagemContato
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
            this.listContatos = new System.Windows.Forms.ListBox();
            this.btnExcluirContato = new System.Windows.Forms.Button();
            this.btnEditarContato = new System.Windows.Forms.Button();
            this.btnInserirContato = new System.Windows.Forms.Button();
            this.btnContato = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listContatos
            // 
            this.listContatos.FormattingEnabled = true;
            this.listContatos.ItemHeight = 25;
            this.listContatos.Location = new System.Drawing.Point(12, 81);
            this.listContatos.Name = "listContatos";
            this.listContatos.Size = new System.Drawing.Size(564, 354);
            this.listContatos.TabIndex = 9;
            // 
            // btnExcluirContato
            // 
            this.btnExcluirContato.Location = new System.Drawing.Point(286, 31);
            this.btnExcluirContato.Name = "btnExcluirContato";
            this.btnExcluirContato.Size = new System.Drawing.Size(112, 34);
            this.btnExcluirContato.TabIndex = 8;
            this.btnExcluirContato.Text = "Excluir";
            this.btnExcluirContato.UseVisualStyleBackColor = true;
            this.btnExcluirContato.Click += new System.EventHandler(this.btnExcluirContato_Click);
            // 
            // btnEditarContato
            // 
            this.btnEditarContato.Location = new System.Drawing.Point(148, 31);
            this.btnEditarContato.Name = "btnEditarContato";
            this.btnEditarContato.Size = new System.Drawing.Size(112, 34);
            this.btnEditarContato.TabIndex = 7;
            this.btnEditarContato.Text = "Editar";
            this.btnEditarContato.UseVisualStyleBackColor = true;
            this.btnEditarContato.Click += new System.EventHandler(this.btnEditarContato_Click);
            // 
            // btnInserirContato
            // 
            this.btnInserirContato.Location = new System.Drawing.Point(12, 31);
            this.btnInserirContato.Name = "btnInserirContato";
            this.btnInserirContato.Size = new System.Drawing.Size(112, 34);
            this.btnInserirContato.TabIndex = 6;
            this.btnInserirContato.Text = "Inserir";
            this.btnInserirContato.UseVisualStyleBackColor = true;
            this.btnInserirContato.Click += new System.EventHandler(this.btnInserirContato_Click);
            // 
            // btnContato
            // 
            this.btnContato.Location = new System.Drawing.Point(426, 31);
            this.btnContato.Name = "btnContato";
            this.btnContato.Size = new System.Drawing.Size(112, 34);
            this.btnContato.TabIndex = 10;
            this.btnContato.Text = "Visualizar";
            this.btnContato.UseVisualStyleBackColor = true;
            this.btnContato.Click += new System.EventHandler(this.btnContato_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(604, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 143);
            this.button2.TabIndex = 12;
            this.button2.Text = "Mostrar\r\ncontatos\r\nagrupados por \r\ncargo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListagemContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(722, 460);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnContato);
            this.Controls.Add(this.listContatos);
            this.Controls.Add(this.btnExcluirContato);
            this.Controls.Add(this.btnEditarContato);
            this.Controls.Add(this.btnInserirContato);
            this.Name = "ListagemContato";
            this.Text = "ListagemContato";
            this.Load += new System.EventHandler(this.Contato_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listContatos;
        private System.Windows.Forms.Button btnExcluirContato;
        private System.Windows.Forms.Button btnEditarContato;
        private System.Windows.Forms.Button btnInserirContato;
        private System.Windows.Forms.Button btnContato;
        private System.Windows.Forms.Button button2;
    }
}