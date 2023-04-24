using DataAccessObject;
using ObjectLibrary.ObjectLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        UserDAO UserDAO = new UserDAO();

        public User GetUser(string name, string pwd) => UserDAO.GetUser(name, pwd); 

        public void SaveUser(User p) => UserDAO.SaveProduct(p);
        public void UpdateUser(User p) => UserDAO.UpdateProduct(p);
    }
}
