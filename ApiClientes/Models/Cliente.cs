using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiClientes.Models;

public class Cliente
{
    [JsonIgnore]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required(ErrorMessage = "Nome obrigatório")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email obrigatório")]
    [EmailAddress(ErrorMessage = "Email inválido")]
    public string Email { get; set; } = string.Empty;
}
