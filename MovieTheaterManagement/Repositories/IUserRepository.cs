using ObjectLibrary.ObjectLibrary;
using System;
using System.Collections.Generic;

namespace Repositories
{
    public interface IUserRepository
    {
        void SaveUser(User p);
        User GetUser(string name, string pwd);
        void UpdateUser(User p);
    }
}
