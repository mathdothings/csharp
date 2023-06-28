using Microsoft.EntityFrameworkCore;
using MyTodo.Models;

namespace MyTodo.Data;

public class DatabaseContext : DbContext
{
  public DbSet<Todo> Todos { get; set; }
  protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("DataSource=app.db;Cache=Shared");
}