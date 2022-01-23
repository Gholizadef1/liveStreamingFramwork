using System.Collections.Generic;

namespace Register
{
    public class Register:UserType
    {
        private string userName{ get; set; }
        private string password { get; set; }
        private userType UserType { get; set; }
        if(userName && password){
            Login();
        }
        else
        {
            Register();
        }
        public void Register(Stream stream)
        {
            Console.WriteLine("go to register");
        }
        public void Login(Stream stream)
        {
            Console.WriteLine("go to login");
        }
    }
}
