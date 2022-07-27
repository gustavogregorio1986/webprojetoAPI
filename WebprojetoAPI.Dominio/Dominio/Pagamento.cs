using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebprojetoAPI.Dominio.Dominio
{
    public class Pagamento
    {
        public int IdPagamento { get; set; }

        public double Valor_Hora { get; set; }

        public int QtdeOcorrencia { get; set; }

        public Ocorrencia Ocorrencia { get; set; }

        public int Id_Ocorrencia { get; set; }
    }
}
