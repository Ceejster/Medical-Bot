using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Bot
{
    internal class MedicalBot
    {
        const string BotName = "Bob";

        public static void Bob ()
        {
            Console.WriteLine($"Hello my name is {BotName}");
            Console.WriteLine("I have a few questions to ask you to see how I can help.");

            SurveyQuestions questionnaire = new SurveyQuestions();
            Patient patient = new Patient();

            //getting name
            questionnaire.GetName(patient);

            //getting age
            questionnaire.GetAge(patient);

            //getting gender
            questionnaire.GetGender(patient);

            //getting diabetic info
            questionnaire.Diabetus(patient);

            //getting symptom
            questionnaire.SymptomCode(patient);

            //getting dosage amount
            questionnaire.GetDosage(patient);

            Console.WriteLine("Heres your informationand what I'd recommend:");
            Console.WriteLine($"Name: {patient.Name}");
            Console.WriteLine($"Age: {patient.Age}");
            Console.WriteLine($"Gender: {patient.Gender}");
            Console.WriteLine($"Diabetic: {patient.Diabetic}");
            Console.WriteLine($"Symptom Code: {patient.SymptomCode}");
            Console.WriteLine($"{patient.Prescription} {patient.Dosage}mg");

        }
    }
}
