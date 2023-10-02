﻿using ControleFacil.Api.Data;
using ControleFacil.Api.Domain.Models;
using ControleFacil.Api.Domain.Repository.Interfaces_;
using Microsoft.EntityFrameworkCore;

namespace ControleFacil.Api.Domain.Repository.Classes
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly ApplicationContext _contexto;

        public UsuarioRepository(ApplicationContext context)
        {
            _contexto = context;
        }

        public async Task<Usuario> Adicionar(Usuario entidade)
        {
            await _contexto.Usuario.AddAsync(entidade);
            await _contexto.SaveChangesAsync();

            return entidade;
        }

        public async Task<Usuario> Atualizar(Usuario entidade)
        {
            Usuario entidadeBanco = await _contexto.Usuario
                .Where(u => u.Id == entidade.Id)
                .FirstOrDefaultAsync();
            
            _contexto.Entry(entidadeBanco).CurrentValues.SetValues(entidade);

            _contexto.Update<Usuario>(entidadeBanco);

            await _contexto.SaveChangesAsync();

            return entidadeBanco;
        }

        public async Task Deletar(Usuario entidade)
        {
            //Aqui é para deletar fisicamente, deleta primeiro no contexto e depois no banco.
            _contexto.Entry(entidade).State = EntityState.Detached;
            await _contexto.SaveChangesAsync(); 
        }

        public async Task<Usuario?> Obter(string email)
        {
            return await _contexto.Usuario.AsNoTracking()
                .Where(u => u.Email == email)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Usuario>> Obter()
        {
            return await _contexto.Usuario.AsNoTracking()
                                          .OrderBy(u => u.Id)
                                          .ToListAsync();
        }

        public async Task<Usuario?> Obter(long id)
        {
            return await _contexto.Usuario.AsNoTracking()
                .Where(u => u.Id == id)
                .FirstOrDefaultAsync();

        }
    }
}