﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetForce.Schema
{
    public class SfCurrencyField<T> : SfFieldBase<T> where T: SfObjectBase
    {
        public SfCurrencyField(string path) : base(path) { }
    }
}
