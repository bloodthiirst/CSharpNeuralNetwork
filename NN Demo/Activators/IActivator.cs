﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_Demo
{
    public interface IActivator
    {
        double ActivatorValue(double val);
        double ActivatorSlope(double val);
    }
}