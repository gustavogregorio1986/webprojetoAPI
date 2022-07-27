using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebprojetoAPI.Dominio.Dominio
{
    [Table("Tb_Pagamento")]
    public class Pagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPagamento { get; set; }

        public double Valor_Hora { get; set; }

        public int QtdeOcorrencia { get; set; }

        public Ocorrencia Ocorrencia { get; set; }

        [ForeignKey("Ocorrencia")]
        public int Id_Ocorrencia { get; set; }
    }
}
