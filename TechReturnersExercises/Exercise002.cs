using System;

namespace TechReturners.Exercises
{
    public class Exercise002
    {
        public static bool IsFromManchester(Person person)
        {

            return person.City == "Manchester" ? true : false;

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
        }
    }
}
