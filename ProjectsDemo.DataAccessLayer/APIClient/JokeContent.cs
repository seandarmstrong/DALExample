using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectsDemo.DataAccessLayer.APIClient
{
    public class JokeContent
    {
        public int Id { get; set; }
        public string Joke { get; set; }
        public string[] Categories { get; set; }
    }
}
