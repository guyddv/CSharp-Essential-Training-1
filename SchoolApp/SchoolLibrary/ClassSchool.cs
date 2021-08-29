using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class ClassSchool
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        private string _twitteraddress;
        public string TwitterAddress

        {
            get { return _twitteraddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitteraddress = value;
                }
                else
                {
                    throw new Exception("The twitter address must begin with @");
                }
            }
        }

        public ClassSchool()
        {
            Name = "Untitled School";
            Phone = "555-1234";
        }

        public ClassSchool(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            Phone = SchoolPhoneNumber;
        }

        //public float AverageThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}

        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;
        
        public static int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Address);
            sb.Append(City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append("  ");
            sb.Append(Zip);

            return sb.ToString();
        }
    }
}
