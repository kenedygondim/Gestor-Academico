﻿using Gestor_Acadêmico.Models;
using Gestor_Acadêmico.Interfaces;
using Gestor_Acadêmico.Context;
using Microsoft.EntityFrameworkCore;

namespace Gestor_Acadêmico.Repositories
{
    public class CursoRepository : ICursoRepository
    {
        private readonly GestorAcademicoContext _context;

        public CursoRepository(GestorAcademicoContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        public async Task<bool> CriarCurso(Curso curso)
        {
 
            await _context.AddAsync(curso);
            return await Save();
        }

        public async Task<Curso> GetCursoPeloId(int cursoId)
        {
            return await _context.Cursos.Where(cur => cur.Id == cursoId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Curso>> GetCursoPeloNome(string nomeDoCurso)
        {
            return await _context.Cursos.Where(cur => cur.NomeDoCurso.Contains(nomeDoCurso)).ToListAsync();
        }

        public async Task<IEnumerable<Curso>> GetCursos()
        {
            return await _context.Cursos.ToListAsync();
        }

        public async Task<bool> Save()
        {
            var saved = await _context.SaveChangesAsync();
            return saved > 0;
        }

        public async  Task<bool> AtualizarCurso(Curso curso)
        {
            _context.Update(curso);
            return await Save();
        }
    }
}