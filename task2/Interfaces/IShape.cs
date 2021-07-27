﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Interfaces;

namespace task2
{
    public interface IShape : IMovable, IDraw
    {
        string ShapeName { get; }
    }
}
