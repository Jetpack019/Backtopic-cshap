using System;

namespace LoginFormApp{
    class LoginForm{
        static void Main(string[] args){
            string validUsername = "user123";
            string validPassword = "";

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            if(username == validUsername && password == validPassword){
                Console.WriteLine("Login successful!");
            }else{
                Console.WriteLine("Login Failed, Invalid credentials.");
            }
        }
    }
}