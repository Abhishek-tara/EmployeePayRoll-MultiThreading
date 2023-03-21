using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollOperations
{
    public class EmployeePayRoll
    {
        public List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();

        public void addEmployeePayRollList(List<EmployeeDetails> ListemployeeDetails)
        {
            ListemployeeDetails.ForEach(employeeData =>
            {
                Console.WriteLine("Employee added: " + employeeData.Name);
                this.addEmployeePayRollList(employeeData);
                Console.WriteLine("Employee added: " + employeeData.Name);
            });
        }

        private void addEmployeePayRollList(EmployeeDetails employeeDetail)
        {
            employeeDetails.Add(employeeDetail);
        }

        public void addEmployeePayRollListWithThread(List<EmployeeDetails> ListemployeeDetails)
        {
            ListemployeeDetails.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee added: " + employeeData.Name);
                    this.addEmployeePayRollList(employeeData);
                    Console.WriteLine("Employee added: " + employeeData.Name);
                }
                );
                thread.Start();
            }
            );
        }
    }
}
