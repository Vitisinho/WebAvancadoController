using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class AppDataContext : DbContext
{
 public DbSet<Produto> Produtos { get; set; }
}
