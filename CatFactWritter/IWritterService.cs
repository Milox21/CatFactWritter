﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFactWritter
{
    internal interface IWritterService
    {
        Task SaveCatFactAsync(string catFact);
    }
}