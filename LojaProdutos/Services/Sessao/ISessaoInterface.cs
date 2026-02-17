using LojaProdutos.Models;

namespace LojaProdutos.Services.Sessao
{
    public interface ISessaoInterface 
    {
        void CriarSessao(UsuarioModel usuario);

        void RemoverSessao();

       UsuarioModel BuscarSessao();
    }
}
