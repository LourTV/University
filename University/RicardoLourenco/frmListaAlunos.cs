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
    public partial class frmListaAlunos : Form
    {
        int i = 0;
        public int idx;
        public List<Notas> n;
        public frmListaAlunos()
        {
            InitializeComponent();
        }

        public void MostraDados(Notas n)
        {
            txtCadeira.Text = n.Cadeira;
            txtNota.Text = n.Nota.ToString();
        }
        private void LimpaCampos()
        {
            txtCadeira.Text = "";
            txtNota.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Notas novo = new Notas();
            n.Add(novo);
            i = n.Count - 1;
            MostraDados(n[i]);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (n.Count > 0)
            {
                Notas[] alt = n.ToArray<Notas>();
                alt[i].Nota = int.Parse(txtNota.Text);
                alt[i].Cadeira = txtCadeira.Text;
                n = alt.ToList();
            }
            else
                MessageBox.Show("A lista não tem elementos");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (n.Count > 0)
            {
                n.RemoveAt(i);
                if (i > n.Count - 1)
                    i = n.Count - 1;
                if (n.Count > 0)
                    MostraDados(n[i]);
                else
                    LimpaCampos();
            }
            else
                MessageBox.Show("A lista não tem elementos");
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (n.Count > 0)
            {
                i = 0;
                MostraDados(n[i]);
            }
            else
                MessageBox.Show("A lista não tem elementos");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (n.Count > 0)
                if (i > 0)
                    MostraDados(n[--i]);
                else
                    MessageBox.Show("Não pode andar mais para trás");
            else
                MessageBox.Show("A lista não tem elementos");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (n.Count > 0)
                if (i < n.Count - 1)
                    MostraDados(n[++i]);
                else
                    MessageBox.Show("Não pode andar mais para trás");
            else
                MessageBox.Show("A lista não tem elementos");
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (n.Count > 0)
                MostraDados(n[i = n.Count - 1]);
            else
                MessageBox.Show("A lista não tem elementos");
        }

        private void frmListaAlunos_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAlunos f = (frmAlunos)this.Owner;
            f.c[idx].n = this.n;
            n.Sort(ComparaDisciplina);

        }

        private int ComparaDisciplina(Notas n1, Notas n2)
        {
            return string.Compare(n1.Cadeira, n2.Cadeira);
        }

        private void frmListaAlunos_Shown(object sender, EventArgs e)
        {
            n.Sort(ComparaDisciplina);
        }

        private void txtNota_Validating(object sender, CancelEventArgs e)
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
