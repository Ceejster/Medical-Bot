using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Bot
{
    internal class SurveyQuestions
    {
        public void GetName(Patient patient)
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
            Console.Clear();
        }

        public void GetAge(Patient patient)
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
            Console.Clear();
        }

        public void GetGender(Patient patient)
        {
            Console.Write("Whats your gender (m/f/other)? ");
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
            Console.Clear();
        }

        public void Diabetus(Patient patient)
        {
            Console.Write("Are you diabetic (y/n)? ");
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
                Diabetus(patient);
            }
            Console.Clear();
        }

        public void SymptomCode(Patient patient)
        {
            Console.WriteLine("What symptom are you feeling?");
            Console.WriteLine("S1: Headache");
            Console.WriteLine("S2: Skin rashes");
            Console.WriteLine("S3: Dizziness");
            Console.Write("Please enter the code (s1/s2/s3): ");

            string? symptomBig = Console.ReadLine();
            string symptom = symptomBig.ToLower();

            if (symptom == "s1")
            {
                patient.SymptomCode = "S1: Headache";
                patient.Prescription = "Ibuprofen";
            }
            else if (symptom == "s2")
            {
                patient.SymptomCode = "S2: Skin rashes";
                patient.Prescription = "Diphenhydramine";
            }
            else if (symptom == "s3")
            {
                patient.SymptomCode = "S3: Dizziness";
                
                if (patient.Diabetic == false)
                {
                    patient.Prescription = "Dimenhydrinate";
                }
                else
                {
                    patient.Prescription = "Metformin";
                }
            }
            else
            {
                Console.WriteLine("If your symptom isn't here we aren't able to help now, sorry.");
                Console.WriteLine("Exit (y/n)");

                string? exit = Console.ReadLine();
                string lowExit = exit.ToLower();

                if (lowExit == "y")
                {
                    Console.Clear();
                    Console.WriteLine("Thank you, goodbye.");
                }
                else
                {
                    SymptomCode(patient);
                }
            }
            Console.Clear();
        }

        public void GetDosage(Patient patient)
        {
            if (patient.Prescription == "Ibuprofen")
            {
                if (patient.Age < 18)
                {
                    patient.Dosage = 400;
                }
                else
                {
                    patient.Dosage = 800;
                }
            }
            else if (patient.Prescription == "Diphenhydramine")
            {
                if (patient.Age < 18)
                {
                    patient.Dosage = 50;
                }
                else
                {
                    patient.Dosage = 300;
                }
            }
            else if (patient.Prescription == "Dimenhydrinate")
            {
                if (patient.Age < 18)
                {
                    patient.Dosage = 50;
                }
                else
                {
                    patient.Dosage = 400;
                }
            }
            else
            {
                patient.Dosage = 500;
            }
        }
    }
}
