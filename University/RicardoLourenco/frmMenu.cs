using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace RicardoLourenco
{
    public partial class frmMenu : Form
    {
        public int copia_dados = 1;
        public List<Docente> d = new List<Docente>();
        public List<Aluno> c = new List<Aluno>();
        public List<DadosPessoais> dp;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.OwnedForms)
                if (f.GetType() == typeof(frmDocentes))
                {
                    f.Activate();
                    return;
                }
            frmDocentes fl = new frmDocentes();
            fl.d = this.d;
            fl.c = this.c;
            fl.Show(this);
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.OwnedForms)
                if (f.GetType() == typeof(frmAlunos))
                {
                    f.Activate();
                    return;
                }
            frmAlunos fl = new frmAlunos();
            fl.c = this.c;
            fl.d = this.d;
            fl.Show(this);
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            dp = new List<DadosPessoais>();
           dp = dp.Concat(c).ToList();
            dp = dp.Concat(d).ToList();
            dp.Sort(ComparaNome);

            foreach (Form f in this.OwnedForms)
                if (f.GetType() == typeof(frmLista))
                {
                    f.Activate();
                    return;
                }
            frmLista fl = new frmLista();
            fl.dp = this.dp;
            fl.Show(this);
        }

        private int ComparaNome(DadosPessoais d1, DadosPessoais d2)
        {
            return string.Compare(d1.Nome, d2.Nome);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (ofdImport.ShowDialog() != DialogResult.Cancel)
            {
                ImportExport ie = new ImportExport();
                string filename = ofdImport.FileName;

                StreamReader sr = new StreamReader(filename);
                XmlSerializer ser = new XmlSerializer(typeof(ImportExport));
                ie = (ImportExport)ser.Deserialize(sr);
                this.c = ie.c;
                this.d = ie.d;
                this.dp = ie.dp;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (sfdExport.ShowDialog(this) != DialogResult.Cancel)
            {
                ImportExport ie = new ImportExport();
                ie.c = this.c;
                ie.d = this.d;
                ie.dp = this.dp;
                string filename = sfdExport.FileName;
                if (File.Exists(filename))
                    File.Delete(filename);
                StreamWriter sw = new StreamWriter(filename);
                XmlSerializer ser = new XmlSerializer(typeof(ImportExport));
                ser.Serialize(sw, ie);
            }
        }
    }
}
