using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDeFranceCyclist
{


    class Cyclist
    {
        // added a line
        
        private string resultTime;
        private string endPosition;
        public Cyclist(string Name, string Gender, string Country, string result, string endPos)
        {
            name = Name;
            gender = Gender;
            country = Country;
            this.resultTime = result;
            this.endPosition = endPos;
        }
        public string name { get; set; }
        public string gender { get; set; }
        public string country { get; set; }
    }


}

