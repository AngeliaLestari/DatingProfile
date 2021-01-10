using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Dating_Profile
{
    class Profile
    {
        public string name;
        public int age;
        public string city;
        public string country;
        public string pronouns;
        public string[] hobbies;

        public Profile(string name, int age, string city, string country, string pronouns = "Ms/Mr")

        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = new string[0];
        }


        public string ViewProfile()
        {
            string ViewProfile = $"My name is {name},\n I am {age} years old,\n {pronouns} is coming from {city}, {country}";
            string CompleteViewProfile = ViewProfile;

            CompleteViewProfile += "\n Hobbies are";
            foreach (string hobby in hobbies)
                {
                CompleteViewProfile += $"\n {hobby}";          
                }

            return CompleteViewProfile;
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }

    
        
    }
}
