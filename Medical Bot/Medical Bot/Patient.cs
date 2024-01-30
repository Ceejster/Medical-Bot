using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Medical_Bot
{
    internal class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public bool Diabetic { get; set; }
        public string SymptomCode { get; set; }
        public string Prescription { get; set; }

        public int Dosage { get; set; }

    }
}