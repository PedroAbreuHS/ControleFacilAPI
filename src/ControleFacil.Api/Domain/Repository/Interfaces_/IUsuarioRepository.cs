using ControleFacil.Api.Domain.Models;

namespace ControleFacil.Api.Domain.Repository.Interfaces_
{
    public interface IUsuarioRepository : IRepository<Usuario, long>
    {
        //Buscar por email
        Task<Usuario?> Obter(string email);

    }
}
