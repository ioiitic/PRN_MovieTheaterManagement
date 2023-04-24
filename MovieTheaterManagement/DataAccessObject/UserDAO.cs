using ObjectLibrary.ObjectLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObject
{
    public class UserDAO
    {


        private static UserDAO instance = null;
        private static readonly object instanceLock = new object();
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }

        public void SaveUser(User p)
        {
            try
            {
                using PRN_PRJContext user = new PRN_PRJContext();
                user.Users.Add(p);
                user.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateProduct(User p)
        {
            try
            {
                using PRN_PRJContext product = new PRN_PRJContext();
                product.Entry<User>(p).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                product.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
        public User GetUser(string name, string pwd) 
        {
            User user = null;
            using PRN_PRJContext context = new PRN_PRJContext();
            user = context.Users.FirstOrDefault(u => u.Username == name && u.Password == pwd);
            return user;
        }

        public void SaveProduct(User p)
        {
            throw new NotImplementedException();
        }
    }
}

