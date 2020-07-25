using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface INterfaceProdutoApp : INterfaceGenericaApp<Produto>
    {
        Task AddProduct(Produto produto);
        Task UpdateProduct(Produto produto);
    }
}
