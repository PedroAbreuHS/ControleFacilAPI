namespace ControleFacil.Api.Contract_DTO.Usuario
{
    public class UsuarioRequestContract : UsuarioLoginRequestContract
    {
        public DateTime? DataInativacao { get; set; }

    }
}
