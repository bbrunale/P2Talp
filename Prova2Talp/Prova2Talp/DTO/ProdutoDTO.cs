using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prova2Talp.DTO
{
    public class ProdutoDTO
    {
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }
        public double valorProduto { get; set; }
        public int qtdeProduto { get; set; }
        public int idTipoProduto { get; set; }
        public string descProduto { get; set; }
        public double custoProducao { get; set; }
    }
}