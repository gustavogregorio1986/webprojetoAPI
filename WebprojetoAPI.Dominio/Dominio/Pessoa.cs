using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebprojetoAPI.Dominio.Dominio
{
    [Table("Tb_Pessoa")]
    public class Pessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPessoa { get; set; }

        public string Nome { get; set; }

        public string Sexo { get; set; }

        public string Email { get; set; }
    }
}
