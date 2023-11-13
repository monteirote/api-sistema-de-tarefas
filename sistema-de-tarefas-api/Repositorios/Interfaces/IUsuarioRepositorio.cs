using sistema_de_tarefas_api.Models;

namespace sistema_de_tarefas_api.Repositorios.Interfaces;

public interface IUsuarioRepositorio
{
    Task<List<UsuarioModel>> BuscarTodosUsuarios();

    Task<UsuarioModel> BuscarUsuarioPorId(int id);

    Task<UsuarioModel> AdicionarUsuario(UsuarioModel usuario);

    Task<UsuarioModel> AtualizarUsuario(UsuarioModel usuario, int id);

    Task<bool> Apagar(int id);
}