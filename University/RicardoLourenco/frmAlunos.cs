using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RicardoLourenco
{
    public partial class frmAlunos : Form
    {
        public List<Aluno> c;
        public List<Docente> d;
        int i = 0;
        public frmAlunos()
        {
            InitializeComponent();
            RadioButtonNao.Hide();
            RadioButtonSim.Hide();
            btnCopiarDados.Hide();
            LabelInsert.Hide();
        }

        public void MostraDados(Aluno c)
        {
            txtNAluno.Text = c.NAluno.ToString();
            txtNome.Text = c.Nome;
            txtMorada.Text = c.Morada;
            txtCodPostal.Text = c.CodigoPostal;
            txtTelefone.Text = c.NumeroTelemovel.ToString();
            txtCartaoCidadao.Text = c.NumeroCartaoCidadao.ToString();
            txtEmail.Text = c.Email;
            txtCursoInscrito.Text = c.CursoInscrito;
        }

        public void LimpaCampos()
        {
            txtNAluno.Text = "";
            txtNome.Text = "";
            txtMorada.Text = "";
            txtCodPostal.Text = "";
            txtTelefone.Text = "";
            txtCartaoCidadao.Text = "";
            txtEmail.Text = "";
            txtCursoInscrito.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            RadioButtonNao.Show();
            RadioButtonSim.Show();
            btnCopiarDados.Show();
            LabelInsert.Show();
            RadioButtonNao.Checked = true;
            RadioButtonSim.Checked = false;
            btnCopiarDados.Enabled = false;
            Aluno novo = new Aluno();
            novo.n = new List<Notas>();
            c.Add(novo);
            i = c.Count - 1;
            MostraDados(c[i]);
            frmMenu variavel = (frmMenu)this.Owner;
            variavel.copia_dados = 1;


        }

        private void RadioButtonSim_CheckedChanged(object sender, EventArgs e)
        {
            btnCopiarDados.Enabled = true;
        }

        private void RadioButtonNao_CheckedChanged(object sender, EventArgs e)
        {
            btnCopiarDados.Enabled = false;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (c.Count > 0)
            {
                i = 0;
                MostraDados(c[i]);
                RadioButtonNao.Hide();
                RadioButtonSim.Hide();
                btnCopiarDados.Hide();
                LabelInsert.Hide();
            }
            else
                MessageBox.Show("A lista não tem elementos");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (c.Count > 0)
            {
                if (i > 0)
                {
                    i--;
                    MostraDados(c[i]);
                }
                else
                    MessageBox.Show("Não pode andar para trás");
                RadioButtonNao.Hide();
                RadioButtonSim.Hide();
                btnCopiarDados.Hide();
                LabelInsert.Hide();
            }
            else
                MessageBox.Show("A lista não tem elementos");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (c.Count > 0)
            {
                if (i < c.Count - 1)
                {
                    i++;
                    MostraDados(c[i]);
                }
                else
                    MessageBox.Show("Não pode andar para a frente");
                RadioButtonNao.Hide();
                RadioButtonSim.Hide();
                btnCopiarDados.Hide();
                LabelInsert.Hide();
            }
            else
                MessageBox.Show("A lista não tem elementos");
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (c.Count > 0)
            {
                i = c.Count - 1;
                MostraDados(c[i]);
                RadioButtonNao.Hide();
                RadioButtonSim.Hide();
                btnCopiarDados.Hide();
                LabelInsert.Hide();
            }
            else
                MessageBox.Show("A lista não tem elementos");
        }

        private void btnChange_Click(object sender, EventArgs e)
        {


            if (c.Count > 0)
            {
                Aluno[] alt = c.ToArray<Aluno>();
                
                    alt[i].Nome = txtNome.Text;
                    alt[i].Morada = txtMorada.Text;
                    alt[i].CodigoPostal = txtCodPostal.Text;
                    alt[i].NumeroTelemovel = int.Parse(txtTelefone.Text);
                    alt[i].NumeroCartaoCidadao = int.Parse(txtCartaoCidadao.Text);
                    alt[i].Email = txtEmail.Text;
                    frmMenu variavel = (frmMenu)this.Owner;
                foreach (Docente a in d)
                {
                    if (a.NumeroCartaoCidadao == int.Parse(txtCartaoCidadao.Text) && variavel.copia_dados == 1)
                    {
                        MessageBox.Show("Este Aluno que está a tentar inserir já existe na lista dos Docentes. Todos os dados foram copiados..");
                        alt[i].Nome = a.Nome;
                        alt[i].Morada = a.Morada;
                        alt[i].CodigoPostal = a.CodigoPostal;
                        alt[i].NumeroTelemovel = a.NumeroTelemovel;
                        alt[i].NumeroCartaoCidadao = a.NumeroCartaoCidadao;
                        alt[i].Email = a.Email;
                        txtNome.Text = a.Nome;
                        txtMorada.Text = a.Morada;
                        txtCodPostal.Text = a.CodigoPostal;
                        txtTelefone.Text = a.NumeroTelemovel.ToString();
                        txtCartaoCidadao.Text = a.NumeroCartaoCidadao.ToString();
                        txtEmail.Text = a.Email;
                        variavel.copia_dados = 0;

                    }
                }
                
                alt[i].NAluno = int.Parse(txtNAluno.Text);
                
                alt[i].CursoInscrito = txtCursoInscrito.Text;
                c = alt.ToList();
                RadioButtonNao.Hide();
                RadioButtonSim.Hide();
                btnCopiarDados.Hide();
                LabelInsert.Hide();
            }
            else
                MessageBox.Show("A lista não tem elementos");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (c.Count > 0)
            {
                c.RemoveAt(i);
                if (i > c.Count - 1)
                    i = c.Count - 1;
                if (c.Count > 0)
                    MostraDados(c[i]);
                else
                    LimpaCampos();
            }
            else
                MessageBox.Show("A lista não tem elementos");
        }

        private void frmAlunos_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenu f = (frmMenu)this.Owner;
            f.c = this.c;
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            if (c.Count > 0)
            {
                foreach (Form f in this.OwnedForms)
                    if (f.GetType() == typeof(frmListaAlunos))
                    {
                        f.Activate();
                        return;
                    }
                frmListaAlunos fl = new frmListaAlunos();
                //fl.n[i] = this.n[i];
                //fl.n = this.c[i].n;
                fl.n = c[i].n;
                fl.idx = i;
                fl.Show(this);
            }
            else
                MessageBox.Show("A lista não tem elementos");
        }

        private void btnCopiarDados_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.OwnedForms)
                if (f.GetType() == typeof(frmCopiarDadosAlunos))
                {
                    f.Activate();
                    return;
                }
            frmCopiarDadosAlunos fl = new frmCopiarDadosAlunos();
            fl.d = this.d;
            fl.c = this.c;
            fl.Show(this);
        }


         

private void txt_NRAluno_Validating(object sender, CancelEventArgs e)
{
    if (!string.IsNullOrEmpty(txtNAluno.Text))
    {
        int k = 0;
        if (!int.TryParse(txtNAluno.Text, out k))
        {
            MessageBox.Show("Tem de introduzir um número inteiro");
            e.Cancel = true;
                    return;
        }

                for (int j = 0; j < c.Count; j++)
                {
                    if (j != i)
                    {
                        int value;
                        if (int.TryParse(txtNAluno.Text, out value))
                        {
                            if (c[j].NAluno == value)
                            {
                                MessageBox.Show("Este número de aluno já existe. Insere um diferente");
                                e.Cancel = true;
                                return;
                            }
                        }
                    }
                }

            }
}

private void txt_INTEIRO_Validating(object sender, CancelEventArgs e)
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
