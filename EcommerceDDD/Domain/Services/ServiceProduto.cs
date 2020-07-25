using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceProduto : IServiceProduct
    {
        private readonly IProduct _iproduct;
        public ServiceProduto(IProduct product)
        {
            _iproduct = product;
        }
        public async Task AddProduct(Produto produto)
        {
            var validaNome = produto.ValidarPropriedadeString(produto.Nome, "Nome");

            var validaValor = produto.ValidarPropriedadeDecimal(produto.Valor, "Valor");

            if(validaNome && validaValor)
            {
                produto.Estado = true;
                await _iproduct.Add(produto);

            }
        }

        public async Task UpdateProduct(Produto produto)
        {
            var validaNome = produto.ValidarPropriedadeString(produto.Nome, "Nome");

            var validaValor = produto.ValidarPropriedadeDecimal(produto.Valor, "Valor");

            if (validaNome && validaValor)
            {
                produto.Estado = true;
                await _iproduct.Update(produto);

            }
        }

    }
}
