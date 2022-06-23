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
    public partial class frmLista : Form
    {
        public List<DadosPessoais> dp;
        public frmLista()
        {
            InitializeComponent();
        }

        private void frmLista_Shown(object sender, EventArgs e)
        {
            listLista.Items.Clear();
            foreach (DadosPessoais f in dp)
            {
                listLista.Items.Add(f.Nome + "-" + f.NumeroTelemovel + "-" + f.Email);
            }
        }
    }
}
