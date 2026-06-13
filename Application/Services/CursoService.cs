using LP3.BlazorServer.Data.Repositories;
using LP3.BlazorServer.Domain.Entities;
using LP3.BlazorServer.Shared.DTOs;
using LP3.BlazorServer.Shared.Extensions;

namespace LP3.BlazorServer.Application.Services;
public class CursoService(ICursoRepository  CursoRepository): ICursoService
{
    public async Task<ICollection<CursoDto>> GetAll()
    {
        var Curso1 = await CursoRepository.ListAsync();
        return Curso1.Select(c => c.ToDto()).ToList();
    }

    public async Task<CursoDto?> GetByIdAsync(int id)
    {
        var Curso2 = await CursoRepository.GetByIdAsync(id);
        return Curso2?.ToDto();
    }

   public async Task<CursoDto?> GetByCodigoAsync(string codigo)
    {
        var Curso3 = await CursoRepository.GetByCodigoAsync(codigo);
        return Curso3?.ToDto();
    }

    public async Task<bool> CreateAsync(CursoDto dto)
    {
        try
        {
            var Curso = new Curso
            {
                Nombre      = dto.Nombre,
                Codigo      = dto.Codigo,
                Creditos    = dto.Creditos,
                Activo      = dto.Activo
            };

            await CursoRepository.AddAsync(Curso);
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
            var Curso = await CursoRepository.GetByIdAsync(id);
            if (Curso == null) return false;

            Curso.Nombre = dto.Nombre;
            Curso.Codigo = dto.Codigo;
            Curso.Creditos = dto.Creditos;
            Curso.Activo = dto.Activo;

            await CursoRepository.Update(Curso);
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
            var Curso = await CursoRepository.GetByIdAsync(id);
            if (Curso == null) return false;

            await CursoRepository.Remove(Curso);
            return true;
        }
        catch
        {
            return false;
        }
    }
}