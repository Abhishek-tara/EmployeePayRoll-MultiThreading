using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollOperations
{
    public class EmployeeDetails
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public string JobDescription { get; set; }


        public EmployeeDetails(string name, string department, string address, string jobDescription)
        {
            this.Name = name;
            this.Department = department;
            this.Address = address;
            this.JobDescription = jobDescription;

        }
    }
}
