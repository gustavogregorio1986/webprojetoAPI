using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebprojetoAPI.Dominio.Dominio
{
    [Table("Tb_Ocorrencia")]
    public class Ocorrencia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOcorrencia { get; set; }

        public string NomeOcorrencia { get; set; }

        public int NumeroOcorrencia { get; set; }

        public string ObsOcorrencia { get; set; }

        public Processo Processo { get; set; }

        [ForeignKey("Processo")]
        public int Id_Processo { get; set; }
    }
}
