﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectsDemo.DataAccessLayer.APIClient
{
    public class JokeList
    {
        public string Type { get; set; }
        public JokeContent[] Value { get; set; }
    }
}
