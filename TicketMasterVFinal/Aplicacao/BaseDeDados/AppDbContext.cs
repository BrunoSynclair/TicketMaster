using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TicketMasterVFinal.Aplicacao.Modelos;

public class AppDbContext : DbContext
{
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Tickets> Tickets { get; set; }

    private static string GetConnectionString()
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        return config.GetConnectionString("DefaultConnection");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(GetConnectionString());
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Funcionario>().ToTable("funcionarios");
        modelBuilder.Entity<Tickets>().ToTable("tickets");
    }

    /*
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Funcionario>().ToTable("funcionarios").Property();
        modelBuilder.Entity<Funcionario>(entity =>
        {
            // Definindo a chave primária explicitamente
            entity.HasKey(p => p.Id);

            // Definindo o comprimento máximo do Nome
            entity.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            // Configurações para o Preço (deve ser maior que 0 e até 9999.99)
            entity.Property(p => p.Preco)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            // Definindo um valor padrão para a quantidade
            entity.Property(p => p.Quantidade)
                .HasDefaultValue(0);

            // Definindo que DataCriacao deve ser obrigatória
            entity.Property(p => p.DataCriacao)
                .HasColumnType("datetime")
                .IsRequired();
        });

        base.OnModelCreating(modelBuilder);

    }
    */

}