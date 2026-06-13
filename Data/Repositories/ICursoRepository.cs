using LP3.BlazorServer.Data.Repositories;
using LP3.BlazorServer.Domain.Entities;
using LP3.BlazorServer.Shared.DTOs;

public interface ICursoRepository : IRepository<Curso>
{
    Task<Curso?> GetByCodigoAsync(string codigo);
    Task<Curso?> GetByMatriculaAsync(string matricula);
}