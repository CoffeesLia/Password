using System;

class MetodoString
{
    public void containsNumber(string number)
    { 
        for (var i = 0; i < passwsord.Length; i++)
        {
            Console.WriteLine(password[i]);                    
            if (password[i] == '0' || password[i] == '1' || password[i] == '2' ||                        
            password[i] == '3' || password[i] == '4' || password[i] == '5' ||                        
            password[i] == '6' || password[i] == '7' || password[i] == '8' ||                        
            password[i] == '9')                    
            {                        
                Console.WriteLine("The password contains a number." + password[i]);                    
            }                
                return true;
            }else
            {
                    Console.WriteLine("The password does not contain a number.");
                    return false;

            }   
    }
}
