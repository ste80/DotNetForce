﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetForce
{
    public class SfBooleanField<T> : SfFieldBase<T> where T: SfObjectBase
    {
        public SfBooleanField(string path) : base(path) { }
    }
}
