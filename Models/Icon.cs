using System;
using System.Collections.Generic;

namespace fin;

public partial class Icon
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Account> Accounts { get; } = new List<Account>();
}
