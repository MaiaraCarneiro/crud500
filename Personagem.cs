using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.Models.Entidades
{
    [Table("Personagem")]
    public class Personagem
    {
        public int Id { get; set; }

        public string NomePersonagem {get; set; }
    }
}
