using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCardLibrary
{
    public enum Day
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public enum Time : byte
    {
        Morning,
        Afternoon,
        Evening
    }

    public class Shedule
    {
        private Day dayOfWeek;
        private Time timeOfDay;

        public Shedule(Day dayOfWeek, Time timeOfDay)
        {
            this.dayOfWeek = dayOfWeek;
            this.timeOfDay = timeOfDay;
        }
    }
}
