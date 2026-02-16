using LojaProdutos.Models;

namespace LojaProdutos.Services.Usuario
{
    public interface IUsuarioInterface
    {
        Task<List<UsuarioModel>> BuscarUsuarios();
            Task<UsuarioModel> BuscarUsuarioById(int id);
           
    }
}
