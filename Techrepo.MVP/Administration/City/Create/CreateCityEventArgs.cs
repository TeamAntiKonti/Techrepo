﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techrepo.MVP.Administration.City.Create
{
    public class CreateCityEventArgs:EventArgs
    {
        public CreateCityEventArgs(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }
}
