﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetForce
{
    public class SfAnyTypeField<T> : SfFieldBase<T> where T: SfObjectBase
    {
        public SfAnyTypeField(string path) : base(path) { }
    }
}
