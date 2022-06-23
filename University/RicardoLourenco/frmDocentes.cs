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
    
    public partial class frmDocentes : Form
    {
        public List<Docente> d;
        public List<Aluno> c;
        int i = 0;
        public frmDocentes()
        {
            InitializeComponent();
            RadioButtonNao.Hide();
            RadioButtonSim.Hide();
            btnCopiarDados.Hide();
            LabelInsert.Hide();
        }

        public void MostraDados(Docente d)
        {
            txtNDocente.Text = d.NDocente.ToString();
            txtNome.Text = d.Nome;
            txtMorada.Text = d.Morada;
            txtCodPostal.Text = d.CodigoPostal;
            txtTelefone.Text = d.NumeroTelemovel.ToString();
            txtCartaoCidadao.Text = d.NumeroCartaoCidadao.ToString();
            txtEmail.Text = d.Email;
            txtHoras.Text = d.HorasSemanais.ToString();
        }

        public void LimpaCampos()
        {
            txtNDocente.Text = "";
            txtNome.Text = "";
            txtMorada.Text = "";
            txtCodPostal.Text = "";
            txtTelefone.Text = "";
            txtCartaoCidadao.Text = "";
            txtEmail.Text = "";
            txtHoras.Text = "";
        }

        private void frmDocentes_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenu f = (frmMenu)this.Owner;
            f.d = this.d;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (d.Count > 0)
            {
                i = 0;
                MostraDados(d[i]);
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
            if (d.Count > 0)
            {
                if (i > 0)
                {
                    i--;
                    MostraDados(d[i]);
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
            if (d.Count > 0)
            {
                if (i < d.Count - 1)
                {
                    i++;
                    MostraDados(d[i]);
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
            if (d.Count > 0)
            {
                i = d.Count - 1;
                MostraDados(d[i]);
                RadioButtonNao.Hide();
                RadioButtonSim.Hide();
                btnCopiarDados.Hide();
                LabelInsert.Hide();
            }
            else
                MessageBox.Show("A lista não tem elementos");
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
            Docente novo = new Docente();
            novo.graus = new List<Graus>();
            d.Add(novo);
            i = d.Count - 1;
            MostraDados(d[i]);
            frmMenu variavel = (frmMenu)this.Owner;
            variavel.copia_dados = 1;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            frmMenu variavel = (frmMenu)this.Owner;
            if (d.Count > 0)
            {
                Docente[] alt = d.ToArray<Docente>();
                alt[i].Nome = txtNome.Text;
                alt[i].Morada = txtMorada.Text;
                alt[i].CodigoPostal = txtCodPostal.Text;
                alt[i].NumeroTelemovel = int.Parse(txtTelefone.Text);
                alt[i].NumeroCartaoCidadao = int.Parse(txtCartaoCidadao.Text);
                alt[i].Email = txtEmail.Text;

                foreach (Aluno a in c)
                {
                    if(a.NumeroCartaoCidadao == int.Parse(txtCartaoCidadao.Text) && variavel.copia_dados == 1)
                    {
                        MessageBox.Show("Este docente que está a tentar inserir já existe nos alunos. Todos os dados foram copiados..");
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
                
                alt[i].NDocente = int.Parse(txtNDocente.Text);
                alt[i].HorasSemanais = int.Parse(txtHoras.Text);
                d = alt.ToList();
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
            if (d.Count > 0)
            {
                d.RemoveAt(i);
                if (i > d.Count - 1)
                    i = d.Count - 1;
                if (d.Count > 0)
                    MostraDados(d[i]);
                else
                    LimpaCampos();
            }
            else
                MessageBox.Show("A lista não tem elementos");
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            if (d.Count > 0)
            {
                foreach (Form f in this.OwnedForms)
                    if (f.GetType() == typeof(frmListaDocentes))
                    {
                        f.Activate();
                        return;
                    }
                frmListaDocentes fl = new frmListaDocentes();
                //fl.n[i] = this.n[i];
                //fl.n = this.c[i].n;
                fl.graus = d[i].graus;
                fl.idf = i;
                fl.Show(this);
            }
            else
                MessageBox.Show("A lista não tem elementos");
        }

        private void frmDocentes_Shown(object sender, EventArgs e)
        {
        }

        private void btnCopiarDados_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.OwnedForms)
                if (f.GetType() == typeof(frmCopiarDadosDocentes))
                {
                    f.Activate();
                    return;
                }
            frmCopiarDadosDocentes fl = new frmCopiarDadosDocentes();
            fl.d = this.d;
            fl.c = this.c;
            fl.Show(this);
        }

        private void RadioButtonSim_CheckedChanged(object sender, EventArgs e)
        {
            btnCopiarDados.Enabled = true;
        }

        private void RadioButtonNao_CheckedChanged(object sender, EventArgs e)
        {
            btnCopiarDados.Enabled = false;
        }

        private void txt_NDocentes_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNDocente.Text))
            {
                int k = 0;
                if (!int.TryParse(txtNDocente.Text, out k))
                {
                    MessageBox.Show("Tem de introduzir um número inteiro");
                    e.Cancel = true;
                    return;
                }

                for (int j = 0; j < d.Count; j++)
                {
                    if (j != i)
                    {
                        int value;
                        if (int.TryParse(txtNDocente.Text, out value))
                        {
                            if (d[j].NDocente == value)
                            {
                                MessageBox.Show("Este número de docente já existe. Insere um diferente");
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
