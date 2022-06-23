namespace RicardoLourenco
{
    partial class frmAlunos
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtCursoInscrito = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCartaoCidadao = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNAluno = new System.Windows.Forms.TextBox();
            this.btnLista = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RadioButtonSim = new System.Windows.Forms.RadioButton();
            this.RadioButtonNao = new System.Windows.Forms.RadioButton();
            this.btnCopiarDados = new System.Windows.Forms.Button();
            this.LabelInsert = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(456, 445);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Apagar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(375, 445);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 38;
            this.btnChange.Text = "Guardar";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(292, 445);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 37;
            this.btnInsert.Text = "Novo";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtCursoInscrito
            // 
            this.txtCursoInscrito.Location = new System.Drawing.Point(407, 203);
            this.txtCursoInscrito.Name = "txtCursoInscrito";
            this.txtCursoInscrito.Size = new System.Drawing.Size(100, 20);
            this.txtCursoInscrito.TabIndex = 36;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(407, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 35;
            // 
            // txtCartaoCidadao
            // 
            this.txtCartaoCidadao.Location = new System.Drawing.Point(407, 152);
            this.txtCartaoCidadao.Name = "txtCartaoCidadao";
            this.txtCartaoCidadao.Size = new System.Drawing.Size(100, 20);
            this.txtCartaoCidadao.TabIndex = 34;
            this.txtCartaoCidadao.Validating += new System.ComponentModel.CancelEventHandler(this.txt_INTEIRO_Validating);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(407, 121);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 33;
            this.txtTelefone.Validating += new System.ComponentModel.CancelEventHandler(this.txt_INTEIRO_Validating);
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(407, 94);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(100, 20);
            this.txtCodPostal.TabIndex = 32;
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(407, 68);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(100, 20);
            this.txtMorada.TabIndex = 31;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(407, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 30;
            // 
            // txtNAluno
            // 
            this.txtNAluno.Location = new System.Drawing.Point(407, 16);
            this.txtNAluno.Name = "txtNAluno";
            this.txtNAluno.Size = new System.Drawing.Size(100, 20);
            this.txtNAluno.TabIndex = 29;
            this.txtNAluno.Validating += new System.ComponentModel.CancelEventHandler(this.txt_NRAluno_Validating);
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(385, 404);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(75, 23);
            this.btnLista.TabIndex = 28;
            this.btnLista.Text = "Lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Curso Inscrito";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "E-mail pessoal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nº Cartão cidadão";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Telefone móvel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Código postal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Morada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nº Aluno";
            // 
            // RadioButtonSim
            // 
            this.RadioButtonSim.AutoSize = true;
            this.RadioButtonSim.Location = new System.Drawing.Point(338, 295);
            this.RadioButtonSim.Name = "RadioButtonSim";
            this.RadioButtonSim.Size = new System.Drawing.Size(42, 17);
            this.RadioButtonSim.TabIndex = 40;
            this.RadioButtonSim.TabStop = true;
            this.RadioButtonSim.Text = "Sim";
            this.RadioButtonSim.UseVisualStyleBackColor = true;
            this.RadioButtonSim.CheckedChanged += new System.EventHandler(this.RadioButtonSim_CheckedChanged);
            // 
            // RadioButtonNao
            // 
            this.RadioButtonNao.AutoSize = true;
            this.RadioButtonNao.Location = new System.Drawing.Point(463, 295);
            this.RadioButtonNao.Name = "RadioButtonNao";
            this.RadioButtonNao.Size = new System.Drawing.Size(45, 17);
            this.RadioButtonNao.TabIndex = 41;
            this.RadioButtonNao.TabStop = true;
            this.RadioButtonNao.Text = "Não";
            this.RadioButtonNao.UseVisualStyleBackColor = true;
            this.RadioButtonNao.CheckedChanged += new System.EventHandler(this.RadioButtonNao_CheckedChanged);
            // 
            // btnCopiarDados
            // 
            this.btnCopiarDados.Location = new System.Drawing.Point(366, 347);
            this.btnCopiarDados.Name = "btnCopiarDados";
            this.btnCopiarDados.Size = new System.Drawing.Size(110, 33);
            this.btnCopiarDados.TabIndex = 42;
            this.btnCopiarDados.Text = "Copiar Dados";
            this.btnCopiarDados.UseVisualStyleBackColor = true;
            this.btnCopiarDados.Click += new System.EventHandler(this.btnCopiarDados_Click);
            // 
            // LabelInsert
            // 
            this.LabelInsert.AutoSize = true;
            this.LabelInsert.Location = new System.Drawing.Point(326, 262);
            this.LabelInsert.Name = "LabelInsert";
            this.LabelInsert.Size = new System.Drawing.Size(246, 13);
            this.LabelInsert.TabIndex = 43;
            this.LabelInsert.Text = "O Aluno que está a inserir já existe como docente?";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(467, 505);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(28, 21);
            this.btnLast.TabIndex = 47;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(422, 505);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(28, 21);
            this.btnNext.TabIndex = 46;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(378, 505);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(28, 21);
            this.btnPrev.TabIndex = 45;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(334, 505);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(28, 21);
            this.btnFirst.TabIndex = 44;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // frmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 649);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.LabelInsert);
            this.Controls.Add(this.btnCopiarDados);
            this.Controls.Add(this.RadioButtonNao);
            this.Controls.Add(this.RadioButtonSim);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtCursoInscrito);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCartaoCidadao);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCodPostal);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtNAluno);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAlunos";
            this.Text = "frmAlunos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAlunos_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RadioButtonSim;
        private System.Windows.Forms.RadioButton RadioButtonNao;
        private System.Windows.Forms.Button btnCopiarDados;
        private System.Windows.Forms.Label LabelInsert;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnFirst;
        public System.Windows.Forms.TextBox txtCursoInscrito;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtCartaoCidadao;
        public System.Windows.Forms.TextBox txtTelefone;
        public System.Windows.Forms.TextBox txtCodPostal;
        public System.Windows.Forms.TextBox txtMorada;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtNAluno;
    }
}