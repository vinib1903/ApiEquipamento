using ApiEquipamento.Dominio.ModuloGeral;
using ApiEquipamento.Dominio.ModuloTeste;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiEquipamento.Repositorio.ModuloTeste;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<Teste> Testes { get; set; }
    public DbSet<Pessoa> Pessoas { get; set; }
}