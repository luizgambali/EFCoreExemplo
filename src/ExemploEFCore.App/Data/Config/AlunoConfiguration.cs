
using ExemploEFCore.App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploEFCore.App.Configuration
{
    public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Alunos");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).IsRequired().HasMaxLength(50).HasColumnName("Nome").HasColumnType("varchar2");            
            builder.Property(p => p.Idade).IsRequired().HasDefaultValue(0).HasColumnName("Idade");
            builder.Property(p => p.Email).IsRequired().HasMaxLength(100).HasColumnName("Email").HasColumnType("varchar2");
        }
    }
}

