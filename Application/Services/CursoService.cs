using LP3.BlazorServer.Data.Repositories;
using LP3.BlazorServer.Domain.Entities;
using LP3.BlazorServer.Shared.DTOs;
using LP3.BlazorServer.Shared.Extensions;

namespace LP3.BlazorServer.Application.Services;

public class CursoService(ICursoRepository cursoRepository) : ICursoService
{
    public async Task<ICollection<CursoDto>> GetAll()
    {
        var cursos = await cursoRepository.ListAsync();
        return cursos.Select(c => new CursoDto
        {
            Nombre = c.Nombre,
            Codigo = c.Codigo,
            Creditos = c.Creditos,
            Activo = c.Activo
        }).ToList();
    }

    public async Task<CursoDto?> GetByIdAsync(int id)
    {
        var curso = await cursoRepository.GetByIdAsync(id);
        return curso == null ? null : new CursoDto
        {
            Nombre = curso.Nombre,
            Codigo = curso.Codigo,
            Creditos = curso.Creditos,
            Activo = curso.Activo
        };
    }

    public async Task<CursoDto?> GetByCodigoAsync(string codigo)
    {
        var curso = await cursoRepository.GetByCodigoAsync(codigo);
        return curso == null ? null : new CursoDto
        {
            Nombre = curso.Nombre,
            Codigo = curso.Codigo,
            Creditos = curso.Creditos,
            Activo = curso.Activo
        };
    }

    public async Task<bool> CreateAsync(CursoDto dto)
    {
        try
        {
            var curso = new Curso
            {
                Nombre = dto.Nombre,
                Codigo = dto.Codigo,
                Creditos = dto.Creditos,
                Activo = dto.Activo
            };

            await cursoRepository.AddAsync(curso);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> UpdateAsync(int id, CursoDto dto)
    {
        try
        {
            var curso = await cursoRepository.GetByIdAsync(id);

            if (curso == null)
                return false;

            curso.Nombre = dto.Nombre;
            curso.Codigo = dto.Codigo;
            curso.Creditos = dto.Creditos;
            curso.Activo = dto.Activo;

            await cursoRepository.Update(curso);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> DeleteAsync(int id)
    {
        try
        {
            var curso = await cursoRepository.GetByIdAsync(id);

            if (curso == null)
                return false;

            await cursoRepository.Remove(curso);
            return true;
        }
        catch
        {
            return false;
        }
    }
}