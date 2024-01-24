using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Bot
{
    internal class SurveyQuestions
    {
        Patient patient = new Patient();

        public void GetName()
        {
            while (patient.Name == null || patient.Name == "")
            {
                Console.Write("Enter name: ");
                var nameInput = Console.ReadLine();

                if (nameInput != null && nameInput != "")
                {
                    patient.Name = nameInput;
                }
                else
                {
                    Console.WriteLine("Invalid name");
                    continue;
                }
            }
        }

        public void GetAge()
        {
            while (patient.Age == 0)
            {
                Console.Write("Enter your age: ");
                var ageInput = Console.ReadLine();
                bool success = int.TryParse(ageInput, out var age);
                if (success)
                {
                    patient.Age = age;
                }
                else
                {
                    Console.WriteLine("Invalid age");
                    continue;
                }

            }
        }

        public void GetGender()
        {
            Console.WriteLine("Whats your gender? (m/f/other)");
            string? genderInput = Console.ReadLine();
            string gender = genderInput.ToLower();

            if (gender == "m")
            {
                patient.Gender = "Male";
            }
            else if (gender == "f")
            {
                patient.Gender = "Female";
            }
            else if (gender == "other")
            {
                patient.Gender = "Other";
            }
            else
            {
                patient.Gender = "N/A";
            }
        }

        public void Diabetus()
        {
            Console.WriteLine("Are you diabetic? (y/n)");
            string? isDiabetic = Console.ReadLine();
            string lowerDiabetic = isDiabetic.ToLower();

            if (lowerDiabetic == "y")
            {
                patient.Diabetic = true;
            }
            else if (lowerDiabetic == "n")
            {
                patient.Diabetic = false;
            }
            else
            {
                Console.WriteLine("Invalid response");
                Diabetus();
            }
        }
    }
}
