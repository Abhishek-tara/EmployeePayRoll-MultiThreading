using EmployeePayRollOperations;
namespace EmployeePayRollOperationsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenEmployee_WhenAddedToList()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails("John", "Hr", "Chennai", "Marketing"));
            employeeDetails.Add(new EmployeeDetails("Sk", "ASh", "Delhi", "Writer"));
            employeeDetails.Add(new EmployeeDetails("Yash", "Jo", "Pune", "Sports"));
            employeeDetails.Add(new EmployeeDetails("Bruece", "Hr", "Hyd", "Marketing"));
            employeeDetails.Add(new EmployeeDetails("Clark", "Hr", "Raipur", "Communication"));

            EmployeePayRoll employeePayRoll= new EmployeePayRoll();
            //employeePayRoll.addEmployeePayRollList(employeeDetails);
            employeePayRoll.addEmployeePayRollListWithThread(employeeDetails);
        }
    }
}