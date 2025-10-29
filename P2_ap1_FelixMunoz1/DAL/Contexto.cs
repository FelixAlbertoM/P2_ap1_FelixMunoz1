using Microsoft.EntityFrameworkCore;
using P2_ap1_FelixMunoz.Models;

namespace P2_ap1_FelixMunoz1.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    public DbSet<Registro> Registro { get; set; }

}
