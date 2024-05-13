using FourSix.Domain.Entities.ProdutoAggregate;
using Swashbuckle.AspNetCore.Annotations;

namespace FourSix.Controllers.Adapters.Produtos.NovoProduto
{
    public class NovoProdutoRequest
    {
        /// <summary>
        /// Nome do produto
        /// </summary>
        /// <example>FourSix Burguer Plus</example>
        [SwaggerSchema(Nullable = false)]
        public string Nome { get; set; }
        /// <summary>
        /// Descri��o do Produto
        /// </summary>
        /// <example>Lanche com hamburguer de carne, queijo, cebola e molho especial</example>
        [SwaggerSchema(Nullable = false)]
        public string Descricao { get; set; }
        /// <summary>
        /// Categoria
        /// </summary>
        /// <example>1</example>
        [SwaggerSchema(Nullable = false)]
        public EnumCategoriaProduto Categoria { get; set; }
        /// <summary>
        /// Pre�o deo produto
        /// </summary>
        /// <example>15.30</example>
        [SwaggerSchema(Nullable = false)]
        public decimal Preco { get; set; }

    }
}
