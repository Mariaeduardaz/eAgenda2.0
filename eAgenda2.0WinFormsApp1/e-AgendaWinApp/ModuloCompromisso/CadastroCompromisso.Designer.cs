namespace eAgenda2._0WinFormsApp1
{
    partial class CadastroCompromisso
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
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.btnTelefone = new System.Windows.Forms.Label();
            this.btnAssunto = new System.Windows.Forms.Label();
            this.maskedBoxData = new System.Windows.Forms.MaskedTextBox();
            this.maskedBoxHorarioInicio = new System.Windows.Forms.MaskedTextBox();
            this.maskedBoxHorarioFinal = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxContato = new System.Windows.Forms.ComboBox();
            this.btnHorarioFinal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnData = new System.Windows.Forms.Label();
            this.btnContatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAssunto
            // 
            this.txtAssunto.AccessibleDescription = "";
            this.txtAssunto.AllowDrop = true;
            this.txtAssunto.Location = new System.Drawing.Point(134, 34);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(238, 31);
            this.txtAssunto.TabIndex = 40;
            this.txtAssunto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(276, 369);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 54);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(159, 369);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(111, 54);
            this.btnGravar.TabIndex = 38;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(134, 86);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(238, 31);
            this.txtLocal.TabIndex = 37;
            // 
            // btnTelefone
            // 
            this.btnTelefone.AutoSize = true;
            this.btnTelefone.Location = new System.Drawing.Point(54, 89);
            this.btnTelefone.Name = "btnTelefone";
            this.btnTelefone.Size = new System.Drawing.Size(56, 25);
            this.btnTelefone.TabIndex = 36;
            this.btnTelefone.Text = "Local:";
            // 
            // btnAssunto
            // 
            this.btnAssunto.AutoSize = true;
            this.btnAssunto.Location = new System.Drawing.Point(35, 34);
            this.btnAssunto.Name = "btnAssunto";
            this.btnAssunto.Size = new System.Drawing.Size(81, 25);
            this.btnAssunto.TabIndex = 35;
            this.btnAssunto.Text = "Assunto:";
            // 
            // maskedBoxData
            // 
            this.maskedBoxData.Location = new System.Drawing.Point(134, 193);
            this.maskedBoxData.Mask = "00/00/0000";
            this.maskedBoxData.Name = "maskedBoxData";
            this.maskedBoxData.Size = new System.Drawing.Size(238, 31);
            this.maskedBoxData.TabIndex = 41;
            // 
            // maskedBoxHorarioInicio
            // 
            this.maskedBoxHorarioInicio.Location = new System.Drawing.Point(134, 250);
            this.maskedBoxHorarioInicio.Mask = "00:00";
            this.maskedBoxHorarioInicio.Name = "maskedBoxHorarioInicio";
            this.maskedBoxHorarioInicio.Size = new System.Drawing.Size(238, 31);
            this.maskedBoxHorarioInicio.TabIndex = 42;
            this.maskedBoxHorarioInicio.ValidatingType = typeof(System.DateTime);
            // 
            // maskedBoxHorarioFinal
            // 
            this.maskedBoxHorarioFinal.Location = new System.Drawing.Point(134, 299);
            this.maskedBoxHorarioFinal.Mask = "00:00";
            this.maskedBoxHorarioFinal.Name = "maskedBoxHorarioFinal";
            this.maskedBoxHorarioFinal.Size = new System.Drawing.Size(238, 31);
            this.maskedBoxHorarioFinal.TabIndex = 43;
            this.maskedBoxHorarioFinal.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxContato
            // 
            this.comboBoxContato.FormattingEnabled = true;
            this.comboBoxContato.Location = new System.Drawing.Point(134, 136);
            this.comboBoxContato.Name = "comboBoxContato";
            this.comboBoxContato.Size = new System.Drawing.Size(238, 33);
            this.comboBoxContato.TabIndex = 44;
            // 
            // btnHorarioFinal
            // 
            this.btnHorarioFinal.AutoSize = true;
            this.btnHorarioFinal.Location = new System.Drawing.Point(12, 305);
            this.btnHorarioFinal.Name = "btnHorarioFinal";
            this.btnHorarioFinal.Size = new System.Drawing.Size(117, 25);
            this.btnHorarioFinal.TabIndex = 45;
            this.btnHorarioFinal.Text = "Horario Final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Horario Inicio";
            // 
            // btnData
            // 
            this.btnData.AutoSize = true;
            this.btnData.Location = new System.Drawing.Point(54, 199);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(53, 25);
            this.btnData.TabIndex = 47;
            this.btnData.Text = "Data:";
            // 
            // btnContatos
            // 
            this.btnContatos.AutoSize = true;
            this.btnContatos.Location = new System.Drawing.Point(28, 139);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(88, 25);
            this.btnContatos.TabIndex = 48;
            this.btnContatos.Text = "Contatos:";
            // 
            // CadastroCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.btnContatos);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHorarioFinal);
            this.Controls.Add(this.comboBoxContato);
            this.Controls.Add(this.maskedBoxHorarioFinal);
            this.Controls.Add(this.maskedBoxHorarioInicio);
            this.Controls.Add(this.maskedBoxData);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.btnTelefone);
            this.Controls.Add(this.btnAssunto);
            this.Name = "CadastroCompromisso";
            this.Text = "CadastroCompromisso";
            this.Load += new System.EventHandler(this.CadastroCompromisso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label btnTelefone;
        private System.Windows.Forms.Label btnAssunto;
        private System.Windows.Forms.MaskedTextBox maskedBoxData;
        private System.Windows.Forms.MaskedTextBox maskedBoxHorarioInicio;
        private System.Windows.Forms.MaskedTextBox maskedBoxHorarioFinal;
        private System.Windows.Forms.ComboBox comboBoxContato;
        private System.Windows.Forms.Label btnHorarioFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btnData;
        private System.Windows.Forms.Label btnContatos;
    }
}