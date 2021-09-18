﻿using StrattonOakmontModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontServices
{
    public interface ISecurityRepository
    {
        IEnumerable<Security> GetAllSecurities();
        IEnumerable<Security> AllSecurities { get; }
    }
}