﻿using Gestor_Acadêmico.Models;

namespace Gestor_Acadêmico.Interfaces
{
    public interface IDisciplinaRepository
    {
        Task<IEnumerable<Disciplina>> ObterDisciplinas();
        Task<Disciplina> ObterDisciplinaPeloId(int disciplinaId);
        Task<IEnumerable<Disciplina>> ObterDisciplinaPeloNome(string nomeDaDisciplina);
        Task<IEnumerable<Disciplina>> ObterDisciplinasDoCurso(int cursoId);
        Task<IEnumerable<Disciplina>> ObterDisciplinasDoProfessor(int professorId);
        Task<bool> CriarDisciplina(Disciplina disciplina);
        Task<bool> AtualizarDisciplina(Disciplina disciplina);
        Task<bool> Save();
    }
}
