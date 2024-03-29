﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetonMe.Models.Repositories
{
    public interface ISelectionRepository
    {
        IEnumerable<Selection> AllSelections { get; }
        Selection GetSelectionById(int selectionId);
    }
}
