namespace RicardoLourenco
{
    partial class frmDocentes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLista = new System.Windows.Forms.Button();
            this.txtNDocente = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCartaoCidadao = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.LabelInsert = new System.Windows.Forms.Label();
            this.btnCopiarDados = new System.Windows.Forms.Button();
            this.RadioButtonNao = new System.Windows.Forms.RadioButton();
            this.RadioButtonSim = new System.Windows.Forms.RadioButton();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Docente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Morada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Código postal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefone móvel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nº Cartão cidadão";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "E-mail pessoal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nº horas semanais";
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(218, 409);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(75, 23);
            this.btnLista.TabIndex = 8;
            this.btnLista.Text = "Lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // txtNDocente
            // 
            this.txtNDocente.Location = new System.Drawing.Point(239, 34);
            this.txtNDocente.Name = "txtNDocente";
            this.txtNDocente.Size = new System.Drawing.Size(100, 20);
            this.txtNDocente.TabIndex = 9;
            this.txtNDocente.Validating += new System.ComponentModel.CancelEventHandler(this.txt_NDocentes_Validating);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(239, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 10;
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(239, 86);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(100, 20);
            this.txtMorada.TabIndex = 11;
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(239, 112);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(100, 20);
            this.txtCodPostal.TabIndex = 12;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(239, 139);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 13;
            this.txtTelefone.Validating += new System.ComponentModel.CancelEventHandler(this.txt_INTEIRO_Validating);
            // 
            // txtCartaoCidadao
            // 
            this.txtCartaoCidadao.Location = new System.Drawing.Point(239, 170);
            this.txtCartaoCidadao.Name = "txtCartaoCidadao";
            this.txtCartaoCidadao.Size = new System.Drawing.Size(100, 20);
            this.txtCartaoCidadao.TabIndex = 14;
            this.txtCartaoCidadao.Validating += new System.ComponentModel.CancelEventHandler(this.txt_INTEIRO_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(239, 198);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(239, 221);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(100, 20);
            this.txtHoras.TabIndex = 16;
            this.txtHoras.Validating += new System.ComponentModel.CancelEventHandler(this.txt_INTEIRO_Validating);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(125, 450);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Novo";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(208, 450);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 18;
            this.btnChange.Text = "Guardar";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(289, 450);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Apagar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // LabelInsert
            // 
            this.LabelInsert.AutoSize = true;
            this.LabelInsert.Location = new System.Drawing.Point(144, 269);
            this.LabelInsert.Name = "LabelInsert";
            this.LabelInsert.Size = new System.Drawing.Size(248, 13);
            this.LabelInsert.TabIndex = 47;
            this.LabelInsert.Text = "O Docente que está a inserir já existe como Aluno?";
            // 
            // btnCopiarDados
            // 
            this.btnCopiarDados.Location = new System.Drawing.Point(206, 350);
            this.btnCopiarDados.Name = "btnCopiarDados";
            this.btnCopiarDados.Size = new System.Drawing.Size(110, 33);
            this.btnCopiarDados.TabIndex = 46;
            this.btnCopiarDados.Text = "Copiar Dados";
            this.btnCopiarDados.UseVisualStyleBackColor = true;
            this.btnCopiarDados.Click += new System.EventHandler(this.btnCopiarDados_Click);
            // 
            // RadioButtonNao
            // 
            this.RadioButtonNao.AutoSize = true;
            this.RadioButtonNao.Location = new System.Drawing.Point(319, 302);
            this.RadioButtonNao.Name = "RadioButtonNao";
            this.RadioButtonNao.Size = new System.Drawing.Size(45, 17);
            this.RadioButtonNao.TabIndex = 45;
            this.RadioButtonNao.TabStop = true;
            this.RadioButtonNao.Text = "Não";
            this.RadioButtonNao.UseVisualStyleBackColor = true;
            this.RadioButtonNao.CheckedChanged += new System.EventHandler(this.RadioButtonNao_CheckedChanged);
            // 
            // RadioButtonSim
            // 
            this.RadioButtonSim.AutoSize = true;
            this.RadioButtonSim.Location = new System.Drawing.Point(156, 302);
            this.RadioButtonSim.Name = "RadioButtonSim";
            this.RadioButtonSim.Size = new System.Drawing.Size(42, 17);
            this.RadioButtonSim.TabIndex = 44;
            this.RadioButtonSim.TabStop = true;
            this.RadioButtonSim.Text = "Sim";
            this.RadioButtonSim.UseVisualStyleBackColor = true;
            this.RadioButtonSim.CheckedChanged += new System.EventHandler(this.RadioButtonSim_CheckedChanged);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(300, 502);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(28, 21);
            this.btnLast.TabIndex = 51;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(255, 502);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(28, 21);
            this.btnNext.TabIndex = 50;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(211, 502);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(28, 21);
            this.btnPrev.TabIndex = 49;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(167, 502);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(28, 21);
            this.btnFirst.TabIndex = 48;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // frmDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 578);
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
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCartaoCidadao);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCodPostal);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtNDocente);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDocentes";
            this.Text = "frmDocentes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDocentes_FormClosing);
            this.Shown += new System.EventHandler(this.frmDocentes_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label LabelInsert;
        private System.Windows.Forms.Button btnCopiarDados;
        private System.Windows.Forms.RadioButton RadioButtonNao;
        private System.Windows.Forms.RadioButton RadioButtonSim;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnFirst;
        public System.Windows.Forms.TextBox txtNDocente;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtMorada;
        public System.Windows.Forms.TextBox txtCodPostal;
        public System.Windows.Forms.TextBox txtTelefone;
        public System.Windows.Forms.TextBox txtCartaoCidadao;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtHoras;
    }
}