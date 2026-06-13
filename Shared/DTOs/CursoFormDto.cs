namespace LP3.BlazorServer.Shared.DTOs;
using System.ComponentModel.DataAnnotations;
public class CursoFormDto
{
    public int? Id { get; set; }

    [Required(ErrorMessage = "El nombre del curso es obligatorio.")]
    [MaxLength(100, ErrorMessage = "El nombre del curso no puede exceder los 100 caracteres.")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "El código del curso es obligatorio.")]
    [MaxLength(20, ErrorMessage = "El código del curso no puede exceder los 20 caracteres.")]
    public string Codigo { get; set; } = string.Empty;

    [Range(1, 10, ErrorMessage = "Los créditos deben estar entre 1 y 10.")]
    public int Creditos { get; set; }

    public bool Activo { get; set; } = true;
}