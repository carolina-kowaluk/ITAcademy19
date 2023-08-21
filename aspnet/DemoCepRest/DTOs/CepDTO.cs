using System.Security.AccessControl;
namespace DemoCepRest.DTOs;

using System.ComponentModel.DataAnnotations;
// só contem informação publica 
public class CepDTO
{
    //@ -> string literal ex: @"\n" não é uma nova linha
    [RegularExpression(@"^\d{8}$", ErrorMessage = "Cep deve ter 8 dígitos")] 
    public string Cep {get;set;} = null!;
    [RegularExpression(@"^[A-Z]{2}$", ErrorMessage = "Estado deve ser uma sigla com 2 letras maiúsculas")]
    public string Estado {get;set;} = null!;
    [StringLength(50, ErrorMessage = "Cidade deve ter no máximo 50 caracteres")]
    public string Cidade {get;set;} = null!;
    [StringLength(30, ErrorMessage = "Bairro deve ter no máximo 30 caracteres")]
    public string Bairro {get;set;} = null!;
    [StringLength(70, ErrorMessage = "Logradouro deve ter no máximo 70 caracteres")]
    public string Logradouro {get;set;} = null!;
}