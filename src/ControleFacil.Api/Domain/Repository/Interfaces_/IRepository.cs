namespace ControleFacil.Api.Domain.Repository.Interfaces_
{
    public interface IRepository<T, I> where T : class
    {
        //Método que devolve uma coleção genérica, todos registros
        Task<IEnumerable<T>> Obter();

        //Retornar por ID
        Task<T?> Obter(I id);

        //Adicionar
        Task<T> Adicionar(T entidade);

        //Atualizar
        Task<T> Atualizar(T entidade);

        //Deletar (na aplicação seria inativar)
        Task Deletar(T entidade);
    }
}
