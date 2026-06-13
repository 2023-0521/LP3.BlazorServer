using LP3.BlazorServer.Data;
using LP3.BlazorServer.Data.Repositories;
using LP3.BlazorServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class CursoRepository(ApplicationDbContext context) : Repository<Curso>(context), ICursoRepository
{
	public async Task<Curso?> GetByCodigoAsync(string codigo)
	{
		return await context.Cursos
			.AsNoTracking()
			.FirstOrDefaultAsync(c => c.Codigo == codigo);
	}

	public async Task<Curso?> GetByMatriculaAsync(string Matricula)
	{
		return await context.Cursos
			.AsNoTracking()
			.FirstOrDefaultAsync(c => c.Codigo == Matricula);
	}
}
