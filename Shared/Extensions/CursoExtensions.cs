namespace LP3.BlazorServer.Shared.Extensions;
using LP3.BlazorServer.Shared.DTOs;
using LP3.BlazorServer.Domain.Entities;

public static class CursoExtensions
{
    public static CursoDto ToDto(this Curso c)
        => new()
        {
            Id          = c.Id,
            Nombre      = c.Nombre,
            Codigo      = c.Codigo,
            Creditos    = c.Creditos,
            Activo      = c.Activo
        };

    public static Curso ToEntity(this CursoFormDto dto)
        => new()
        {
            Nombre      = dto.Nombre,
            Codigo      = dto.Codigo,
            Creditos    = dto.Creditos,
            Activo      = dto.Activo
        };
}