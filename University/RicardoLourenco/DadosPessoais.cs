using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoLourenco
{
   public class DadosPessoais
    {
        public string Nome;
        public string Morada;
        public string CodigoPostal;
        public int NumeroTelemovel;
        public int NumeroCartaoCidadao;
        public string Email;

    }
    public struct ImportExport
    {
        public List<Docente> d;
        public List<Aluno> c;
        public List<DadosPessoais> dp;
    }
}
