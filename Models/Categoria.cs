namespace APICatalogo.Models
{
    public class Categoria
    {
        public int Id { get; set; } 
        public string? Nome { get; set; }
        public string? ImageUrl { get; set; }

        public ICollection<Produto>? Produtos { get; set; }
    }
}
