using System;
using System.Collections.Generic;
using MetodoString;

namespace Password
{    
    class Program    
    {        
        static void Main(string[] args)        
        {            
            Console.WriteLine("Create your password: ");           
            string password = Console.ReadLine();      

            var utils = new MetodoString();
            utils.containsNumber();

            if (isPasswordValid)            
            {                
                Console.WriteLine("Password created!");                
                bool containsNumber = false;                
                for (var i = 0; i < password.Length; i++)                
                {
                    Console.WriteLine(password[i]);
                    class MetodoString : numeros{}           
                }
                }
            }            
            else            
            {                
                Console.WriteLine("Your password is too common.");            
            }        
        }    

            List<string> passwordList = new List<string>            
            {                
                "password", "Password", "abcdefg", "123456",
                "12345", "password123", "abcd123", "654321"            
            };            
            
            bool isPasswordValid = true;            
            for (int i = 0; i<passwordList.Count; i++)            
            {                
                if (password == passwordList[i])                
                {                    
                    isPasswordValid = false;                    
                    break;                
                }            
    }        
}
