using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectsDemo.Data.Models;
using ProjectsDemo.DataAccessLayer.APIClient;
using ProjectsDemo.DataAccessLayer.Repositories;
using ProjectsDemo.Models;

namespace ProjectsDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepo;
        private readonly IJokeAPIClient _jokeClient;
        
        public HomeController(IUserRepository userRepo, IJokeAPIClient jokeAPIClient)
        {
            _userRepo = userRepo;
            _jokeClient = jokeAPIClient;
        }
        
        public IActionResult Index()
        {
            var users = _userRepo.GetAllUsers();
            var jokes = _jokeClient.GetListOfTenRandomJokes();
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
