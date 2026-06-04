using LP3.BlazorServer.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LP3.BlazorServer.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Estudiante> Estudiantes => Set<Estudiante>();
	public DbSet<Curso> Cursos => Set<Curso>();
	public DbSet<Matriculacion> Matriculaciones => Set<Matriculacion>();
}
