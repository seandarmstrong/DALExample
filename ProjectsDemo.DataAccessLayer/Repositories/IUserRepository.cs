using ProjectsDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectsDemo.DataAccessLayer.Repositories
{
    public interface IUserRepository
    {
        List<TaskUser> GetAllUsers();
        TaskUser GetSpecificUser(int id);
        void CreateNewUser(TaskUser user);
        void UpdateUser(TaskUser user);
        void DeleteUser(int id);
    }
}
