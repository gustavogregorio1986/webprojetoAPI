using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebprojetoAPI.Dominio.Dominio
{
    [Table("Tb_Processo")]
    public class Processo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProcesso { get; set; }

        public string NumProcesso { get; set; }

        public string NomeProcesso { get; set; }

        public Pessoa Pessoa { get; set; }

        public int Id_Pessoa { get; set; }
    }
}
