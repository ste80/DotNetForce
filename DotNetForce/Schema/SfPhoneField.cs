﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetForce
{
    public class SfPhoneField<T> : SfFieldBase<T> where T: SfObjectBase
    {
        public SfPhoneField(string path) : base(path) { }
    }
}
