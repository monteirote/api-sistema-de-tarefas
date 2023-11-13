using sistema_de_tarefas_api.Models;
using sistema_de_tarefas_api.Repositorios.Interfaces;

namespace sistema_de_tarefas_api.Repositorios;

public class UsuarioRepositorio : IUsuarioRepositorio
{
    
    public Task<List<UsuarioModel>> BuscarTodosUsuarios()
    {
        throw new NotImplementedException();
    }

    public Task<UsuarioModel> BuscarUsuarioPorId(int id)
    {
        throw new NotImplementedException();
    }

    public Task<UsuarioModel> AdicionarUsuario(UsuarioModel usuario)
    {
        throw new NotImplementedException();
    }

    public Task<UsuarioModel> AtualizarUsuario(UsuarioModel usuario, int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Apagar(int id)
    {
        throw new NotImplementedException();
    }
    
} 