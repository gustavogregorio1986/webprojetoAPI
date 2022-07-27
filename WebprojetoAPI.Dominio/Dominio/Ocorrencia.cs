using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebprojetoAPI.Dominio.Dominio
{
    public class Ocorrencia
    {
        public int IdOcorrencia { get; set; }

        public string NomeOcorrencia { get; set; }

        public int NumeroOcorrencia { get; set; }

        public string ObsOcorrencia { get; set; }

        public Processo Processo { get; set; }

        public int Id_Processo { get; set; }
    }
}
