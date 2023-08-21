using System.ComponentModel.DataAnnotations;
namespace DemoAloMundoRest.DTOs;

public class Pessoa
{
    //model validation
    [StringLength(50, ErrorMessage = "Nome no máximo com 50 caracteres")]
    public string Nome {get;set;} = null!; //para o compilador não reclamar que esta null por padrão
    [Required(ErrorMessage = "Idade é obrigatória")]
    [Range(0,150,ErrorMessage = "Idae deve ser entre 0 e 150")]
    public int? Idade {get;set;}
}