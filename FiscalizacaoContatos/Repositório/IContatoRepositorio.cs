using FiscalizacaoContatos.Models;
using System.Collections.Generic;

namespace FiscalizacaoContatos.Repositório
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
