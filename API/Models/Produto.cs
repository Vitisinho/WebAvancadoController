using System;

namespace API.Models;

public class Produto
{
    public int id {get;set;}
    public string Nome {get;set} = string.Empty;

    public DateTime CriadoEm {get; set;} = DateTime.Now;
}
