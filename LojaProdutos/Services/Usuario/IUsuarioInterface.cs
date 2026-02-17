using LojaProdutos.Dto.Usuario;
using LojaProdutos.Models;

namespace LojaProdutos.Services.Usuario
{
    public interface IUsuarioInterface
    {
        Task<List<UsuarioModel>> BuscarUsuarios();
        Task<UsuarioModel> BuscarUsuarioPorId(int id);
        Task<bool> VerificaSeExisteEmail(CriarUsuarioDto criarUsuarioDto);
        Task<CriarUsuarioDto> Cadastar(CriarUsuarioDto criarUsuarioDto);
        Task<UsuarioModel> Editar(EditarUsuarioDto editarUsuarioDto);
        

    }
}
