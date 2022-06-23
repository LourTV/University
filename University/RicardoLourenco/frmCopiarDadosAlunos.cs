using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RicardoLourenco
{
    public partial class frmCopiarDadosAlunos : Form
    {
        public List<Aluno> c;
        public List<Docente> d;
        int encontrado = 0;
        public frmCopiarDadosAlunos()
        {
            InitializeComponent();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            frmMenu variavel = (frmMenu)this.Owner.Owner;
            foreach (Docente a in d)
            {
                Docente[] alt = d.ToArray<Docente>();
                if (a.NumeroCartaoCidadao == int.Parse(txtNumCC.Text))
                {
                    frmAlunos f = null;
                    foreach (Form frm in Application.OpenForms)
                        if (frm.GetType() == typeof(frmAlunos))
                            f = (frmAlunos)frm;
                    
                    if (f != null)
                    {
                        f.txtNome.Text = a.Nome;
                        f.txtMorada.Text = a.Morada;
                        f.txtCodPostal.Text = a.CodigoPostal;
                        f.txtTelefone.Text = a.NumeroTelemovel.ToString();
                        f.txtCartaoCidadao.Text = a.NumeroCartaoCidadao.ToString();
                        f.txtEmail.Text = a.Email;
                        variavel.copia_dados = 0;
                        MessageBox.Show("Dados copiados com sucesso!!");
                        encontrado = 1;
                      
                    }
                }
            }
            if (encontrado == 0)
                MessageBox.Show("O número de Cartão de cidadão introduzido não está inserido nos docentes");
            encontrado = 0;
        }

        private void txtNumCC_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!string.IsNullOrEmpty(txt.Text))
            {
                int k = 0;
                if (!int.TryParse(txt.Text, out k))
                {
                    MessageBox.Show("Tem de introduzir um número inteiro");
                    e.Cancel = true;
                }
            }
        }
    }
}
