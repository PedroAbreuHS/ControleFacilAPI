namespace ControleFacil.Api.Contract_DTO.Usuario
{
    public class UsuarioResponseContract : UsuarioRequestContract
    {
        public long Id { get; set; }

        public DateTime DataCadastro { get; set; }

    }
}
