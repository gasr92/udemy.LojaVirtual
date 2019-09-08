using System;

namespace LojaVirtual.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Decimal Valor { get; set; }
        
    }
}