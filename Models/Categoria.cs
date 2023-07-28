using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace APICatalogo.Models
{
    public class Categoria
    {
        public Categoria() 
        { 
            Produtos = new Collection<Produto>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string? Nome { get; set; }
        [Required]
        [MaxLength(300)]
        public string? ImageUrl { get; set; }

        public ICollection<Produto>? Produtos { get; set; }
    }
}
