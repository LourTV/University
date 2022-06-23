namespace RicardoLourenco
{
    partial class frmCopiarDadosAlunos
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
            this.txtNumCC = new System.Windows.Forms.TextBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero do Cartão de Cidadão";
            // 
            // txtNumCC
            // 
            this.txtNumCC.Location = new System.Drawing.Point(205, 35);
            this.txtNumCC.Name = "txtNumCC";
            this.txtNumCC.Size = new System.Drawing.Size(100, 20);
            this.txtNumCC.TabIndex = 1;
            this.txtNumCC.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumCC_Validating);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(157, 99);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(75, 23);
            this.btnCopiar.TabIndex = 2;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // frmCopiarDadosAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 186);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.txtNumCC);
            this.Controls.Add(this.label1);
            this.Name = "frmCopiarDadosAlunos";
            this.Text = "frmCopiarDadosAlunos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumCC;
        private System.Windows.Forms.Button btnCopiar;
    }
}