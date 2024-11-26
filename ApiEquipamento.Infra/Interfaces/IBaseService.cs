namespace ApiEquipamento.Infra.Interfaces;

public interface IBaseService<T> where T : class
{
    Task<IEnumerable<T>> RecuperarTodosAsync();
    Task<T?> RecuperarPorIdAsync(int id);
    Task InserirAsync(T entidade);
    Task AtualizarAsync(T entidade);
    Task ExcluirAsync(int id);
}