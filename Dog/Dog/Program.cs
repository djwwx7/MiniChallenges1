using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    class Dog
    {

        public string name;
        public string owner;
        public int age;
        public Gender gender;

        public enum Gender
        {
            Male, Female
        };

        public static string getGender(Gender gender)
        {
            if (gender == Gender.Male)
            {
                return "His";
            }
                return "Her";
        }

        public Dog(string name_, string owner_, int age_, Gender gender_)
        {
            name = name_;
            owner = owner_;
            age = age_;
            gender = gender_;
        }

        public void bark(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("Woof! ");

            }

            Console.WriteLine();
        }

        public string getTag()
        {
            string hisHer = getGender(gender).ToString();

            string heShe;

            string yearYears;

            if (hisHer == "His")
            {
                heShe = "he";
            }
            else
            {
                heShe = "she";
            }

            if(age == 1)
            {
                yearYears = "year";
            }
            else
            {
                yearYears = "years";
            }

            return "If lost, call " + owner + ". " + hisHer + " name is " + name + " and " + heShe + " is " + age + " " + yearYears + " old.";
        }

        static void Main(string[] args)
        {

            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);
            puppy.bark(3);
            Console.WriteLine(puppy.getTag());


            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);
            myDog.bark(1);
            Console.WriteLine(myDog.getTag());
        }
    }
}
