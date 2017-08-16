using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCardLibrary
{
    public class Doctor
    {
        private string name;
        private string surname;
        private DoctorExperience experience;
        private Hospital hospital;
        private int telephone;
        private int rate;
        private Shedule[] shedule;
        private double price;

        public Doctor(string name, string surname, int telephone, double price)
        {
            this.name = name;
            this.surname = surname;
            this.telephone = telephone;
            this.price = price;
        }
    }
}
