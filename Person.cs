using System;

namespace SharedIngest
{
    public static class Person
    {
        public static string CalculateAge(DateTime birthDate)
        {
            var age = DateTime.Now.Year - birthDate.Year;
            if(DateTime.Now.DayOfYear < birthDate.DayOfYear)
                age = age - 1;

            return age.ToString() + "  RELEASE";
        }
    }
}
