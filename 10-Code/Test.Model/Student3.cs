﻿using SevenTiny.Bantina.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Model
{
    public class Student3
    {
        [Mapper(TargetName = "BodyHigh")]
        public int Age { get; set; }
    }
}
