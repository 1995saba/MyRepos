using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCardLibrary
{
    public class Person
    {
        private int id;
        private string name;
        private string surname;
        private DateTime dateOfBirth;
        private Disease[] disease;
        private string homeAddress;
        private int telephone;

        public Person(int id, string name, string surname, DateTime dateOfBirth, Disease[] disease, string homeAddress, int telephone)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.disease = disease;
            this.homeAddress = homeAddress;
            this.telephone = telephone;
        }
    }
}
