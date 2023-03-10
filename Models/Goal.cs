﻿using System;
using System.Collections.Generic;

namespace fin;

public partial class Goal
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? AmountAchieved { get; set; }

    public decimal? AmountToAchieve { get; set; }
}
