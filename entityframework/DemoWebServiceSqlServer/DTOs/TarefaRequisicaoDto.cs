using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using System;
namespace DemoWebServiceSqlServer.DTOs;
using System.ComponentModel.DataAnnotations;
public class TarefaRequisicaoDto
{
    [Required (ErrorMessage = "Nome obrigatório")]
    [MaxLength(30, ErrorMessage = "max 30 carac")]
    public string? Nome {get;set;} = null!;
    [MaxLength(150, ErrorMessage = "max 150 carac")]
    public string? Descricao {get;set;}
}