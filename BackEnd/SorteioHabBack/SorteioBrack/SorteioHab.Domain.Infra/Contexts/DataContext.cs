using Microsoft.EntityFrameworkCore;
using SorteioHab.Domain.Entities;

namespace SorteioHab.Domain.Infra.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }

        public DbSet<Participante> Participantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Participante>().ToTable("Tb_participantes");
            modelBuilder.Entity<Participante>().Property(x => x.Id);
            modelBuilder.Entity<Participante>().Property(x => x.Nome).HasMaxLength(120).HasColumnType("varchar(120)");
            modelBuilder.Entity<Participante>().Property(x => x.Cpf).HasMaxLength(14).HasColumnType("varchar(14)");
            modelBuilder.Entity<Participante>().Property(x => x.Dt_nascimento).HasColumnType("datetime");
            modelBuilder.Entity<Participante>().Property(x => x.Renda).HasColumnType("decimal");
            modelBuilder.Entity<Participante>().Property(x => x.Cota);
            modelBuilder.Entity<Participante>().Property(x => x.Cid).HasMaxLength(5).HasColumnType("varchar(5)");
        }
    }
}