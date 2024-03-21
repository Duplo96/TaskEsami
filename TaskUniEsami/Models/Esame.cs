using System;
using System.Collections.Generic;

namespace TaskUniEsami.Models;

public partial class Esame
{
    public int EsameId { get; set; }

    public string Titolo { get; set; } = null!;

    public DateOnly DataEsame { get; set; }

    public int Crediti { get; set; }

    public virtual ICollection<Studente> StudenteRifs { get; set; } = new List<Studente>();
}
