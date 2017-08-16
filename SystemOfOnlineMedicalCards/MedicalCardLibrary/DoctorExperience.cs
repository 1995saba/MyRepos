using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCardLibrary
{
    public class DoctorExperience
    {
        private DateTime date;
        private string attainment;

        public DoctorExperience(DateTime date, string attainment)
        {
            this.date = date;
            this.attainment = attainment;
        }
    }
}
