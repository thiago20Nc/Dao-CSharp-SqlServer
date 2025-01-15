using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao_CSharp_SQLServer.Model.Entities
{
    class Pessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int idade { get; set; } 


        public Pessoa() 
        { 
        }

        public Pessoa(string nome, int idade)
        { 
            this.Nome = nome;
            this.idade = idade;
        }
    }
}
