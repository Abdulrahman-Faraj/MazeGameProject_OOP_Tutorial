﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGameProject
{
    interface IMazeObject
    {
        char Icon { get;  } // the shape of the maze object
        bool IsSolid { get; } // movement block
    }
}
