using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebprojetoAPI.Dominio.Dominio
{
    public class Processo
    {
        public int IdProcesso { get; set; }

        public string NumProcesso { get; set; }

        public string NomeProcesso { get; set; }

        public Pessoa Pessoa { get; set; }

        public int Id_Pessoa { get; set; }
    }
}
