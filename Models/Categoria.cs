﻿namespace APICatalogo.Models
{
    public class Categoria
    {
        public int Id { get; set; } 
        public string? Nome { get; set; }
        public int? ImageUrl { get; set; }

        public ICollection<Produto>? Produtos { get; set; }
    }
}
