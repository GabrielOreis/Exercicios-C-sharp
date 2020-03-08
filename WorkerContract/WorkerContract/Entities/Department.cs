﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerContract.Entities
{
    class Department
    {
        public string Name { get; set; }

        public Department(string name)
        {
            Name = name;
        }

        public Department() { }

    }

}
