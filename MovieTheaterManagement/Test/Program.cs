using DataAccessObject;
using ObjectLibrary.ObjectLibrary;
using Repositories;
using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRepository userRepository =new UserRepository();
            User p = userRepository.GetUser("Huyle", "1");
            Console.WriteLine(p.Role);
            Console.ReadLine();
        }
    }
}
