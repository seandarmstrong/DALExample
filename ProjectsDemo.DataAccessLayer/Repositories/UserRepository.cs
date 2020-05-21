using ProjectsDemo.Data;
using ProjectsDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectsDemo.DataAccessLayer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ProjectsDemoContext _context;

        public UserRepository(ProjectsDemoContext context)
        {
            _context = context;
        }

        public List<TaskUser> GetAllUsers()
        {
            var users = _context.Users.ToList();
            return users;
        }

        public TaskUser GetSpecificUser(int id)
        {
            var user = _context.Users.Where(x => x.Id == id).FirstOrDefault();
            return user;
        }

        public void CreateNewUser(TaskUser user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUser(TaskUser user)
        {
            _context.Update(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = _context.Users.Where(x => x.Id == id).FirstOrDefault();
            _context.Remove(user);
            _context.SaveChanges();
        }
    }
}
