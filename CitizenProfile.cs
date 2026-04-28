using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAffairsDigitalIdentityProcessor
{
     class CitizenProfile

    {

    public string FullName;
       public string IDNumber;
      public int Age;
        public string CitizenshipStatus;

        public CitizenProfile(string name,string id,string citizenship)

        {
            // enter name,id and citizenship

          FullName = name;
            IDNumber = id;
           CitizenshipStatus = citizenship;
            Age = CalculateAge();

        }

        private int CalculateAge()

        {

          int year = int.Parse(IDNumber.Substring(0, 2));
           int month = int.Parse(IDNumber.Substring(2, 2));
            int day = int.Parse(IDNumber.Substring(4, 2));

            //calculate

            int fullYear = (year <= DateTime.Now.Year % 100) ? 2000 + year : 1900 + year;

            DateTime birthDate = new DateTime(fullYear, month, day);

            int age = DateTime.Now.Year - birthDate.Year;

            if (birthDate > DateTime.Now.AddYears(-age)) age--;

            //return the final age

            return age;

        }

        public string ValidateID()

        {

            //make sure ID is 13 caracthers 

        if (IDNumber.Length != 13)

  return "Invalid ID: ID must be 13 digits.";

        //check if ID number consust out of numbers onlyss

      if (!long.TryParse(IDNumber, out _))

       return "Invalid ID: ID must be numeric.";

          return $"Valid ID. Citizen is {Age} years old.";

        }
    }
}

   