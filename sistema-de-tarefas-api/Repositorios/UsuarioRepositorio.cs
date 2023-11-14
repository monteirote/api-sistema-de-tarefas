using Microsoft.EntityFrameworkCore;
using sistema_de_tarefas_api.Data;
using sistema_de_tarefas_api.Models;
using sistema_de_tarefas_api.Repositorios.Interfaces;

namespace sistema_de_tarefas_api.Repositorios;

public class UsuarioRepositorio : IUsuarioRepositorio
{

    private readonly SistemaTarefasDBContex _dbContext;
    public UsuarioRepositorio(SistemaTarefasDBContex sistemaTarefasDbContex)
    {
        _dbContext = sistemaTarefasDbContex;
    }
    
    public async Task<UsuarioModel> BuscarUsuarioPorId(int id)
    {
        return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
    }
    
    public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
    {
        return await _dbContext.Usuarios.ToListAsync();
    }
    
    public async Task<UsuarioModel> AdicionarUsuario(UsuarioModel usuario)
    {
        await _dbContext.Usuarios.AddAsync(usuario);
        await _dbContext.SaveChangesAsync();

        return usuario;
    }

    public async Task<UsuarioModel> AtualizarUsuario(UsuarioModel usuario, int id)
    {
        UsuarioModel usuarioBuscado = await BuscarUsuarioPorId(id);

        if (usuarioBuscado == null)
        {
            throw new Exception($"O usuário com o ID {id} não foi encontrado no banco de dados.");
        }

        usuarioBuscado.Nome = usuario.Nome;
        usuarioBuscado.Email = usuario.Email;

        _dbContext.Usuarios.Update(usuarioBuscado);
        await _dbContext.SaveChangesAsync();

        return usuarioBuscado;
    }

    public async Task<bool> Apagar(int id)
    {
        UsuarioModel usuarioBuscado = await BuscarUsuarioPorId(id);
        
        if (usuarioBuscado == null)
        {
            throw new Exception($"O usuário com o ID {id} não foi encontrado no banco de dados.");
        }

        _dbContext.Usuarios.Remove(usuarioBuscado);
        await _dbContext.SaveChangesAsync();

        return true;
    }
    
} 