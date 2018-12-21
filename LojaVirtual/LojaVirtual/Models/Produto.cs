using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LojaVirtual.Models
{
    [Table("Produtos")]
    public class Produto
    {
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string Imagem { get; set; }

        public string Descricao { get; set; }

        public int Id { get; set; }

        public int CategoriaId { get; set; }

    }
}