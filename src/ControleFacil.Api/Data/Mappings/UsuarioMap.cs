using ControleFacil.Api.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFacil.Api.Data.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario") //criar tabela
                .HasKey(x => x.Id); //informar id como chave

            builder.Property(x => x.Email)
                .HasColumnType("VARCHAR")
                .IsRequired();

            builder.Property(x => x.Senha)
                .HasColumnType("VARCHAR")
                .IsRequired();

            builder.Property(x => x.DataCadastro)
                .HasColumnType("timestamp")
                .IsRequired();

            builder.Property(x => x.DataInativacao)
                .HasColumnType("timestamp");
        }
    }
}
