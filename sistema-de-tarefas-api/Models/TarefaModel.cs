using sistema_de_tarefas_api.Enums;

namespace sistema_de_tarefas_api.Models;

public class TarefaModel
{
    public int Id { get; set; }
    
    public string? Nome { get; set; }
    
    public string? Descricao { get; set; }

    public StatusTarefa Status { get; set; }
}