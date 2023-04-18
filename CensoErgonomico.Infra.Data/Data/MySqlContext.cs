using CensoErgonomico.Domain.Enums;
using CensoErgonomico.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CensoErgonomico.Infra.Data.Data
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var setor = new Setor()
            {
                Id = Guid.NewGuid(),
                Nome = "BENEFICIAMENTO"
            };
            modelBuilder.Entity<Setor>()
              .HasData(setor);

            var funcao = new Funcao()
            {
                Id = Guid.NewGuid(),
                Nome = "OP MÁQUINA III",
                SetorId = setor.Id
            };
            modelBuilder.Entity<Funcao>()
              .HasData(funcao);

            var pessoa = new Pessoa()
            {
                Id = Guid.NewGuid(),
                Nome = "José da Cunha",
                CPF = "12345678902",
                DataNascimento = DateTime.ParseExact("04/09/2001", "dd/MM/yyyy", null ),
                Sexo = TipoSexo.Masculino
            };
            modelBuilder.Entity<Pessoa>()
               .HasData(pessoa);

            var colaborador = new Colaborador()
            {
                Id = Guid.NewGuid(),
                Cadastro = "24644",
                Turno = TipoTurno.Segundo,
                SetorId = setor.Id,
                FuncaoId = funcao.Id,
                PessoaId = pessoa.Id,
            };
            modelBuilder.Entity<Colaborador>()
               .HasData(colaborador);

            var imc = new IMC()
            {
                Id = Guid.NewGuid(),
                Altura = 1.78,
                Peso = 84,
                PessoaId = pessoa.Id
            };
            modelBuilder.Entity<IMC>()
             .HasData(imc);

            var sintomas = new Sintomas()
            {
                Id = Guid.NewGuid(),
                Dor = true,
                Cansaco = true,
                Estalos = false,
                Choques = false,
                Dolorimento = false,
                Formigamento = false,
                ReducaoForca = false,
                LimitacaoMovimento = false,
                TempoQueixa = TipoTempoQueixa.MaisUmAno
            };
            modelBuilder.Entity<Sintomas>()
              .HasData(sintomas);

            var locaisDores = new LocaisDores()
            {
                Id = Guid.NewGuid(),
                PescoçoE = TipoDor.Leve,
                PescoçoD = TipoDor.Leve,
                CostasSuperiorE = TipoDor.Nenhuma,
                CostasSuperiorD = TipoDor.Nenhuma,
                CostasInferiorE = TipoDor.Moderada,
                CostasInferiorD = TipoDor.Moderada,
                OmbroE = TipoDor.Leve,
                OmbroD = TipoDor.Nenhuma,
                BraçoE = TipoDor.Nenhuma,
                BraçoD = TipoDor.Nenhuma,
                CotoveloE = TipoDor.Moderada,
                CotoveloD = TipoDor.Nenhuma,
                AntebracoE = TipoDor.Nenhuma,
                AntebracoD = TipoDor.Nenhuma,
                PunhoE = TipoDor.Nenhuma,
                PunhoD = TipoDor.Nenhuma,
                MaoE = TipoDor.Nenhuma,
                MaoD = TipoDor.Nenhuma,
                QuadrilE = TipoDor.Nenhuma,
                QuadrilD = TipoDor.Nenhuma,
                CoxaE = TipoDor.Nenhuma,
                CoxaD = TipoDor.Nenhuma,
                JoelhoE = TipoDor.Nenhuma,
                JoelhoD = TipoDor.Nenhuma,
                PernaE = TipoDor.Nenhuma,
                PernaD = TipoDor.Nenhuma,
                TornozeloE = TipoDor.Nenhuma,
                TornozeloD = TipoDor.Nenhuma,
                PeE = TipoDor.Nenhuma,
                PeD = TipoDor.Nenhuma
            };
            modelBuilder.Entity<LocaisDores>()
              .HasData(locaisDores);


            var acoes = new Acoes() 
            {
                Id = Guid.NewGuid(),
                PiorHrExtra = false,
                PiorJornadaNormal = false,
                PiorFinalDia = true,
                PiorAtivDomestica = false,
                MelhorNoite = false,
                MelhorFimSemana = true,
                MelhorRevezamento = false,
                MelhorFerias = false,
                Medicamento = Domain.Enums.TipoMedicamento.Sim
            };
            modelBuilder.Entity<Acoes>()
               .HasData(acoes);

            var censoErgonomico = new Domain.Models.CensoErgonomico()
            {
                Id = Guid.NewGuid(),
                DataCadastro = DateTime.Now,
                ColaboradorId = colaborador.Id,
                IMCId = imc.Id,
                Fumante = false,
                PraticaExercicio = true,
                SenteDor = true,
                ConsideracaoMotivoDor = "MANUSEAR QUÍMICOS",
                SugestaoMelhoria = "TROCAR DE BRAÇOS, ALIVIA A DOR DO COTOVELO",
                AcoesId = acoes.Id,
                LocaisDoresId = locaisDores.Id,
                SintomasId = sintomas.Id,
            }; 
            modelBuilder.Entity<Domain.Models.CensoErgonomico>()
               .HasData(censoErgonomico);
            base.OnModelCreating(modelBuilder);
        }

        #region DbSets
        public DbSet<Acoes> Acoes { get; set; }
        public DbSet<Domain.Models.CensoErgonomico> CensoErgonomico { get; set; }
        public DbSet<Colaborador> Colaborador { get; set; }
        public DbSet<Funcao> Funcao { get; set; }
        public DbSet<IMC> IMC { get; set; }
        public DbSet<LocaisDores> LocaisDores { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Setor> Setor { get; set; }
        public DbSet<Sintomas> Sintomas { get; set; }
        #endregion
    }
}
