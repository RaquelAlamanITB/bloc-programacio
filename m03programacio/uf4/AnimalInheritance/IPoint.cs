﻿using System;

namespace oopsecond
{
    public interface IPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public double Distance(int X, int Y);
    }
}
