using System;
using System.Collections.Generic;

namespace DemoWebServiceScaffold.Models;

public partial class Emprestimo
{
    public int Id { get; set; }

    public DateTime Datadevolucao { get; set; }

    public DateTime Dataretirada { get; set; }

    public bool Entregue { get; set; }

    public int Idlivro { get; set; }

    public virtual Livro IdlivroNavigation { get; set; } = null!;
}
