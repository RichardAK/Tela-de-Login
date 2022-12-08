using System;
using System.Collections.Generic;

namespace Tela_de_Login.db;

public partial class TbUser
{
    public int CdUser { get; set; }

    public string? NmUser { get; set; }

    public string? NmSetor { get; set; }

    public string? NmUsario { get; set; }

    public string? CdSenha { get; set; }
}
