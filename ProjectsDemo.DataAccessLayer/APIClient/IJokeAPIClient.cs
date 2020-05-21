using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectsDemo.DataAccessLayer.APIClient
{
    public interface IJokeAPIClient
    {
        JokeList GetListOfTenRandomJokes();
    }
}
