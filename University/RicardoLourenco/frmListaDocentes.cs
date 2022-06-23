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
    public partial class frmListaDocentes : Form
    {
        int i = 0;
        public int idf;
        public List<Graus> graus;
        public frmListaDocentes()
        {
            InitializeComponent();
        }

        public void MostraDados(Graus graus)
        {
            txtGrauAcademico.Text = graus.GrauAcademico;
            txtDataObtencao.Text = graus.DataObtencao.ToShortDateString();
            txtInstitutoObtencao.Text = graus.InstituicaoObtencao;
        }
        private void LimpaCampos()
        {
            txtGrauAcademico.Text = "";
            txtDataObtencao.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Graus novo = new Graus();
            graus.Add(novo);
            i = graus.Count - 1;
            MostraDados(graus[i]);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (graus.Count > 0)
            {
                Graus[] alt = graus.ToArray<Graus>();
                alt[i].DataObtencao = DateTime.Parse(txtDataObtencao.Text);
                alt[i].GrauAcademico = txtGrauAcademico.Text;
                alt[i].InstituicaoObtencao = txtInstitutoObtencao.Text;
                graus = alt.ToList();
            }
            else
                MessageBox.Show("A lista não tem elementos");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (graus.Count > 0)
            {
                graus.RemoveAt(i);
                if (i > graus.Count - 1)
                    i = graus.Count - 1;
                if (graus.Count > 0)
                    MostraDados(graus[i]);
                else
                    LimpaCampos();
            }
            else
                MessageBox.Show("A lista não tem elementos");
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (graus.Count > 0)
            {
                i = 0;
                MostraDados(graus[i]);
            }
            else
                MessageBox.Show("A lista não tem elementos");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (graus.Count > 0)
                if (i > 0)
                    MostraDados(graus[--i]);
                else
                    MessageBox.Show("Não pode andar mais para trás");
            else
                MessageBox.Show("A lista não tem elementos");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (graus.Count > 0)
                if (i < graus.Count - 1)
                    MostraDados(graus[++i]);
                else
                    MessageBox.Show("Não pode andar mais para trás");
            else
                MessageBox.Show("A lista não tem elementos");
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (graus.Count > 0)
                MostraDados(graus[i = graus.Count - 1]);
            else
                MessageBox.Show("A lista não tem elementos");
        }

        private void frmListaDocentes_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDocentes f = (frmDocentes)this.Owner;
            f.d[idf].graus = this.graus;
            graus.Sort(ComparaData);
        }

        private static int ComparaData(Graus g1, Graus g2)
        {
            return g2.DataObtencao.CompareTo(g1.DataObtencao);
        }

        private void frmListaDocentes_Shown(object sender, EventArgs e)
        {
            graus.Sort(ComparaData);
        }
    }
}
