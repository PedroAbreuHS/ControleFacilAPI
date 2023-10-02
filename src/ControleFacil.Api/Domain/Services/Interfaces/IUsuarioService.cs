using ControleFacil.Api.Contract_DTO.Usuario;

namespace ControleFacil.Api.Domain.Services.Interfaces
{
    public interface IUsuarioService : IService<UsuarioRequestContract, UsuarioLoginResponseContract, long>
    {
        Task<UsuarioLoginResponseContract> Autenticar(UsuarioLoginRequestContract usuarioLoginRequest);
    }
}
