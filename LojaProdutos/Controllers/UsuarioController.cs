using LojaProdutos.Dto.Usuario;
using LojaProdutos.Services.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace LojaProdutos.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioInterface _usuarioInterface;

        public UsuarioController(IUsuarioInterface usuarioInterface)
        {
            _usuarioInterface = usuarioInterface;
        }
        public async Task<IActionResult> Index()
        {
            var usuarios = await _usuarioInterface.BuscarUsuarios();
            return View(usuarios);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(CriarUsuarioDto criarUsuarioDto)
        {

            if (ModelState.IsValid)
            {
                if(await _usuarioInterface.VerificaSeExisteEmail(criarUsuarioDto))
                {
                    TempData["MensagemErro"] = "Já existe usuário cadastrado com esse Email";
                    return View(criarUsuarioDto);
                }

                var usuario = await _usuarioInterface.Cadastar(criarUsuarioDto);

                TempData["MensagemSucesso"] = "Usuário cadastrado com sucesso!";

                return RedirectToAction("Index");
            }

            else
            {
                TempData["MensagemErro"] = "Verifique os dados informados!";
                return View(criarUsuarioDto);
            }


        }
    }
}
