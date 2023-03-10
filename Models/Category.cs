using System;
using System.Collections.Generic;

namespace fin;

public partial class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Account> Accounts { get; } = new List<Account>();

    public virtual ICollection<Transaction> Transactions { get; } = new List<Transaction>();
}
