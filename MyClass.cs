﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    public class MyClass
    {
        public static void DoSomething(DateTime dt)
        {
            Console.WriteLine(dt.ToUniversalTime());
        }
    }
}
