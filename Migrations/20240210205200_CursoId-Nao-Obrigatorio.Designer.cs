﻿// <auto-generated />
using System;
using Gestor_Acadêmico.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gestor_Acadêmico.Migrations
{
    [DbContext(typeof(GestorAcademicoContext))]
    [Migration("20240210205200_CursoId-Nao-Obrigatorio")]
    partial class CursoIdNaoObrigatorio
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Gestor_Acadêmico.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("CursoId")
                        .HasColumnType("int");

                    b.Property<string>("DataDeNascimento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnderecoDeEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("IRA")
                        .HasColumnType("decimal(4,2)");

                    b.Property<string>("Matricula")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NomeCompleto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDeTelefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PeriodoDeIngresso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimeiroNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusDoAluno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.HasIndex("CursoId");

                    b.HasIndex("EnderecoDeEmail")
                        .IsUnique();

                    b.HasIndex("Matricula")
                        .IsUnique()
                        .HasFilter("[Matricula] IS NOT NULL");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("Gestor_Acadêmico.Models.AlunoDisciplina", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int");

                    b.HasKey("AlunoId", "DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("AlunoDisciplinas");
                });

            modelBuilder.Entity("Gestor_Acadêmico.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("CargaHoraria")
                        .HasColumnType("decimal(8,1)");

                    b.Property<string>("CategoriaDoCurso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DuracaoDoSemestreEmSemanas")
                        .HasColumnType("int");

                    b.Property<string>("Modalidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeDoCurso")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("QuantidadeDeSemestres")
                        .HasColumnType("int");

                    b.Property<string>("Turno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VagasNoPrimeiroSemestre")
                        .HasColumnType("int");

                    b.Property<int>("VagasNoSegundoSemestre")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NomeDoCurso")
                        .IsUnique();

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("Gestor_Acadêmico.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AulasPorSemana")
                        .HasColumnType("int");

                    b.Property<decimal>("CargaHoraria")
                        .HasColumnType("decimal(8,1)");

                    b.Property<string>("CodigoDaDisciplina")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<string>("NomeDaDisciplina")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.Property<int>("SemestreDeReferencia")
                        .HasColumnType("int");

                    b.Property<string>("SituacaoDaDisciplina")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplinas");
                });

            modelBuilder.Entity("Gestor_Acadêmico.Models.Nota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<bool?>("Aprovado")
                        .HasColumnType("bit");

                    b.Property<decimal?>("Atividades")
                        .HasColumnType("decimal(4,2)");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<decimal?>("FrequenciaDoAluno")
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal?>("MediaGeral")
                        .HasColumnType("decimal(4,2)");

                    b.Property<bool>("NotasFechadas")
                        .HasColumnType("bit");

                    b.Property<decimal?>("PrimeiraAvaliacao")
                        .HasColumnType("decimal(4,2)");

                    b.Property<decimal?>("SegundaAvaliacao")
                        .HasColumnType("decimal(4,2)");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("Gestor_Acadêmico.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DataDeNascimento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnderecoDeEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCompleto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDeTelefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimeiroNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.HasIndex("EnderecoDeEmail")
                        .IsUnique();

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("Gestor_Acadêmico.Models.Aluno", b =>
                {
                    b.HasOne("Gestor_Acadêmico.Models.Curso", "Curso")
                        .WithMany("Alunos")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("Gestor_Acadêmico.Models.AlunoDisciplina", b =>
                {
                    b.HasOne("Gestor_Acadêmico.Models.Aluno", "Aluno")
                        .WithMany("Disciplinas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gestor_Acadêmico.Models.Disciplina", "Disciplina")
                        .WithMany("Alunos")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Disciplina");
                });

            modelBuilder.Entity("Gestor_Acadêmico.Models.Disciplina", b =>
                {
                    b.HasOne("Gestor_Acadêmico.Models.Curso", "Curso")
                        .WithMany("Disciplinas")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("Gestor_Acadêmico.Models.Professor", "Professor")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("Gestor_Acadêmico.Models.Nota", b =>
                {
                    b.HasOne("Gestor_Acadêmico.Models.Aluno", "Aluno")
                        .WithMany("Notas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gestor_Acadêmico.Models.Disciplina", "Disciplina")
                        .WithMany("Notas")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Disciplina");
                });

            modelBuilder.Entity("Gestor_Acadêmico.Models.Aluno", b =>
                {
                    b.Navigation("Disciplinas");

                    b.Navigation("Notas");
                });

            modelBuilder.Entity("Gestor_Acadêmico.Models.Curso", b =>
                {
                    b.Navigation("Alunos");

                    b.Navigation("Disciplinas");
                });

            modelBuilder.Entity("Gestor_Acadêmico.Models.Disciplina", b =>
                {
                    b.Navigation("Alunos");

                    b.Navigation("Notas");
                });

            modelBuilder.Entity("Gestor_Acadêmico.Models.Professor", b =>
                {
                    b.Navigation("Disciplinas");
                });
#pragma warning restore 612, 618
        }
    }
}
