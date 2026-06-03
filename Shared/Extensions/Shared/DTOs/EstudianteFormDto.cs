using System.ComponentModel.DataAnnotations;
using LP3.BlazorServer.Domain.Constants;
using LP3.BlazorServer.Domain.Enums;

public class EstudianteFormDto
{
    public int? Id { get; set; }

    [Required(ErrorMessage = ReglasDominio.ErrorNombreRequerido)]
    [MaxLength(ReglasDominio.NombreMaxLongitud)]
    public string Nombre { get; set; } = string.Empty;

    [Required]
    [MaxLength(80)]
    public string Apellido { get; set; } = string.Empty;

    [Required]
    [MaxLength(ReglasDominio.MatriculaMaxLongitud)]
    public string Matricula { get; set; } = string.Empty;

    [Required]
    [EmailAddress(ErrorMessage = ReglasDominio.ErrorEmailInvalido)]
    public string Email { get; set; } = string.Empty;

    public EstadoEstudiante Estado { get; set; } = EstadoEstudiante.Activo;
}