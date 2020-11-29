using System;

namespace TechReturners.Exercises
{
    public class Exercise002
    {
        public static bool IsFromManchester(Person person)
        {

            if (person.City == "Manchester")
            {
                return true;
            }
            else
            {
                return false;
            }
            
            throw new NotImplementedException();
        }

        public static bool CanWatchFilm(Person person, int ageLimit) 
        {
            if (person.Age <= ageLimit)
            {
                return false;
            }
            else
            {
                return true;
            }
            throw new NotImplementedException();
        }
    }
}
