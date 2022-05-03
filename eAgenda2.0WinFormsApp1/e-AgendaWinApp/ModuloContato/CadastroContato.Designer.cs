namespace eAgenda2._0WinFormsApp1
{
    partial class CadastroContato
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
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEmpresa = new System.Windows.Forms.Label();
            this.btnCargo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnTelefone = new System.Windows.Forms.Label();
            this.btnNome = new System.Windows.Forms.Label();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtemail
            // 
            this.txtemail.AccessibleDescription = "";
            this.txtemail.AllowDrop = true;
            this.txtemail.Location = new System.Drawing.Point(97, 155);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(238, 31);
            this.txtemail.TabIndex = 26;
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "e-mail";
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.AutoSize = true;
            this.btnEmpresa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnEmpresa.Location = new System.Drawing.Point(8, 262);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(83, 25);
            this.btnEmpresa.TabIndex = 24;
            this.btnEmpresa.Text = "Empresa ";
            this.btnEmpresa.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnCargo
            // 
            this.btnCargo.AutoSize = true;
            this.btnCargo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnCargo.Location = new System.Drawing.Point(13, 211);
            this.btnCargo.Name = "btnCargo";
            this.btnCargo.Size = new System.Drawing.Size(60, 25);
            this.btnCargo.TabIndex = 22;
            this.btnCargo.Text = "Cargo";
            // 
            // txtNome
            // 
            this.txtNome.AccessibleDescription = "";
            this.txtNome.AllowDrop = true;
            this.txtNome.Location = new System.Drawing.Point(97, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(238, 31);
            this.txtNome.TabIndex = 20;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(375, 323);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 54);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(248, 323);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(111, 54);
            this.btnGravar.TabIndex = 18;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(97, 101);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(238, 31);
            this.txtTelefone.TabIndex = 17;
            // 
            // btnTelefone
            // 
            this.btnTelefone.AutoSize = true;
            this.btnTelefone.Location = new System.Drawing.Point(12, 107);
            this.btnTelefone.Name = "btnTelefone";
            this.btnTelefone.Size = new System.Drawing.Size(77, 25);
            this.btnTelefone.TabIndex = 16;
            this.btnTelefone.Text = "Telefone";
            // 
            // btnNome
            // 
            this.btnNome.AutoSize = true;
            this.btnNome.Location = new System.Drawing.Point(12, 49);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(61, 25);
            this.btnNome.TabIndex = 15;
            this.btnNome.Text = "Nome";
            // 
            // txtcargo
            // 
            this.txtcargo.AccessibleDescription = "";
            this.txtcargo.AllowDrop = true;
            this.txtcargo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtcargo.Location = new System.Drawing.Point(97, 205);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(238, 31);
            this.txtcargo.TabIndex = 27;
            this.txtcargo.Text = "opcional";
            this.txtcargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.AccessibleDescription = "";
            this.txtEmpresa.AllowDrop = true;
            this.txtEmpresa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtEmpresa.Location = new System.Drawing.Point(97, 262);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(238, 31);
            this.txtEmpresa.TabIndex = 28;
            this.txtEmpresa.Text = "opcional";
            this.txtEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CadastroContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(515, 386);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.btnCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.btnTelefone);
            this.Controls.Add(this.btnNome);
            this.Name = "CadastroContato";
            this.Text = "CadastroContato";
            this.Load += new System.EventHandler(this.CadastroContato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label btnEmpresa;
        private System.Windows.Forms.Label btnCargo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label btnTelefone;
        private System.Windows.Forms.Label btnNome;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.TextBox txtEmpresa;
    }
}