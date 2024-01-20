﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Gestor_Acadêmico.Models
{
    public class Nota
    {

        [Key]
        public int Id { get; set; }

        [Range(0, 100)]
        public decimal? Frequencia { get; set; }

        [Range(0, 10)]
        [DefaultValue(0)]
        public decimal PrimeiraAvaliacao { get; set; }

        [Range(0, 10)]
        [DefaultValue(0)]
        public decimal SegundaAvaliacao { get; set; }
        
        [Range(0, 10)]
        [DefaultValue(0)]
        public decimal Atividades { get; set; }

        public required int AlunoId { get; set; }
        public Aluno? Aluno { get; set; }

        public  required int DisciplinaId { get; set; }
        public Disciplina? Disciplina { get; set; }

        [DefaultValue(false)]
        public bool? NotasFechadas { get; set; }

        [Range(0, 10)]
        public decimal MediaGeral {  get; set; }
        public bool? Aprovado {  get; set;}

        public bool FoiAprovado()
        {
            return MediaGeral > 6;
        }


        

    }
}
