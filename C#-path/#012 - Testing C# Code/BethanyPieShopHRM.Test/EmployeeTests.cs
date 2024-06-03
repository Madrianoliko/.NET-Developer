using BethanysPieShopHRM.HR;

namespace BethanyPieShopHRM.Test
{
    public class EmployeeTests
    {
        [Fact]
        public void PerformWork_Adds_NumberOfHours()
        {
            //Arrange
            Employee employee = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);

            int numberOfHours = 5;

            //Act
            employee.PerformWork(numberOfHours);

            //Assert
            Assert.Equal(numberOfHours, employee.NumberOfHoursWorked);
        }
        //write another test where use PerformWork() without parameter
        [Fact]
        public void PerformWork_Adds_DefaultNumberOfHours_IfNoValueSpecifed()
        {
            Employee employee = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);

            employee.PerformWork();

            Assert.Equal(1, employee.NumberOfHoursWorked);
        }
    }
}