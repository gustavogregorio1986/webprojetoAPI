using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebprojetoAPI.Dominio.Dominio
{
    public class Endereco
    {
        public int IdEndereco { get; set; }

        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }

        public Pessoa Pessoa { get; set; }

        public int Id_Pessoa { get; set; }
    }
}
