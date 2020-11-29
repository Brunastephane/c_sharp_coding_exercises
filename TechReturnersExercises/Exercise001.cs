using System;
using System.Collections.Generic;

namespace TechReturners.Exercises
{
    public class Exercise001
    {
        public static String CapitalizeWord(String word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1);
            throw new NotImplementedException();
        }

        public static String GenerateInitials(String firstName, String lastName)
        {
            return firstName.Substring(0, 1).ToUpper() + "." + lastName.Substring(0, 1).ToUpper();
            throw new NotImplementedException();
        }

        public static double AddVat(double originalPrice, double vatRate)
        {
            return Math.Round((originalPrice + (originalPrice * (vatRate / 100))), 2);
            throw new NotImplementedException();
        }

        public static String Reverse(String sentence)
        {
            string newsentence = "";
            for (int i = sentence.Length-1; i >= 0; i--)
            {
                newsentence = newsentence + sentence.Substring(i, 1);
            }
            return newsentence;
            throw new NotImplementedException();
        }

        public static int CountLinuxUsers(List<User> users) 
        {
            int count = 0;
           foreach(User user in users)
            {
                if(user.Type == "Linux")
                {
                    count++;
                }
            }
            return count;
            throw new NotImplementedException();
        }
    }
}
