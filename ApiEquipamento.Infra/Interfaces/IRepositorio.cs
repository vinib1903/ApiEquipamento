namespace ApiEquipamento.Infra.Interfaces;

public interface IRepositorio<T> where T : class
{
    Task<IEnumerable<T>> ObterTodosAsync();
    Task<T?> ObterPorIdAsync(int id);
    Task<IEnumerable<T>> ObterPorFiltrosAsync(Func<T, bool> filtro);
    Task AdicionarAsync(T entidade);
    Task AtualizarAsync(T entidade);
    Task RemoverAsync(int id);
}