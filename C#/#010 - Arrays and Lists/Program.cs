using BethanysPieShopHRM.HR;

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);

Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);


#region First run Bethany

bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();
bethany.ReceiveWage();
bethany.DisplayEmployeeDetails();

#endregion


#region First run George

george.PerformWork(10);
george.PerformWork();
george.PerformWork();
george.ReceiveWage();
george.DisplayEmployeeDetails();

#endregion

Employee.taxRate = 0.02;//woohoo, less money to pay
Employee.DisplayTaxRate();


#region Second run Bethany

bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork();
bethany.ReceiveWage();
bethany.DisplayEmployeeDetails();

#endregion

#region Second run George

george.PerformWork();
george.PerformWork();
george.PerformWork();
george.ReceiveWage();
george.DisplayEmployeeDetails();

#endregion

Employee.DisplayTaxRate();

double calculatedWage = bethany.CalculateWage();
Console.WriteLine($"The estimated wage is {calculatedWage}.");

int[] sampleArray1 = new int[5];

int[] sampleArray2 = new int[] { 1, 2, 3, 4, 5 };

// int[] sampleArray3 = new int[5] { 1, 2, 3, 4, 5, 6 };  -error

Console.WriteLine("How many employees Ids do you want to register?");

int length = int.Parse(Console.ReadLine());
int[] employeeIds = new int[length];

var testId = employeeIds[0];
//var errorId = employeeIds[length]; - error

for (int i = 0; i < length; i++)
{
    Console.WriteLine("Enter the employee Id:");
    int id = int.Parse(Console.ReadLine());
    employeeIds[i] = id;
}

//display the employee Ids
foreach (var id in employeeIds)
{
    Console.WriteLine($"Employee Id: {id}");
}

Array.Sort(employeeIds);
Console.WriteLine("after sorting");

foreach (var id in employeeIds)
{
    Console.WriteLine($"Employee Id: {id}");
}

int[] employeeIdsCopy = new int[length];
employeeIds.CopyTo(employeeIdsCopy, 0);

Array.Reverse(employeeIdsCopy);


Employee bethany2 = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
Employee george2 = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);
Employee mary = new Employee("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30, EmployeeType.Manager);
Employee bobJunior = new Employee("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17, EmployeeType.Research);
Employee kevin = new Employee("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10, EmployeeType.StoreManager);
Employee kate = new Employee("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10, EmployeeType.StoreManager);
Employee kim = new Employee("Kim", "Jacobs", "kim@snowball.be", new DateTime(1975, 5, 14), 22, EmployeeType.StoreManager);

Employee[] employees = new Employee[] { bethany2, george2, mary, bobJunior, kevin, kate, kim };

foreach (var employee in employees)
{
    employee.DisplayEmployeeDetails();
    var numberOfHoursWorked = new Random().Next(25);
    employee.PerformWork(numberOfHoursWorked);
    employee.ReceiveWage();
}

List<int> employeeIds2 = new List<int>();

employeeIds2.Add(1);
employeeIds2.Add(2);
employeeIds2.Add(3);
employeeIds2.Add(4);
employeeIds2.Add(5);
// employeeIds2.Add("test"); -error

if (employeeIds2.Contains(3))
{
    Console.WriteLine("3 is found!");
}
int currentAmountOfEmployees = employeeIds2.Count;

var employeeIdsArray = employeeIds2.ToArray();

employeeIds2.Clear();


Console.WriteLine("How many employees Ids do you want to register?");

int length2 = int.Parse(Console.ReadLine());

for (int i = 0; i < length; i++)
{
    Console.WriteLine("Enter the employee Id:");
    int id = int.Parse(Console.ReadLine());
    employeeIds2.Add(id);
}

//display the employeeIds2
foreach (var id in employeeIds2)
{
    Console.WriteLine($"Employee Id: {id}");
}

Employee bethany3 = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
Employee george3 = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);
Employee mary3 = new Employee("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30, EmployeeType.Manager);
Employee bobJunior3 = new Employee("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17, EmployeeType.Research);
Employee kevin3 = new Employee("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10, EmployeeType.StoreManager);
Employee kate3 = new Employee("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10, EmployeeType.StoreManager);
Employee kim3 = new Employee("Kim", "Jacobs", "kim@snowball.be", new DateTime(1975, 5, 14), 22, EmployeeType.StoreManager);

List<Employee> employees1 = new List<Employee>();

employees1.Add(bethany3);
employees1.Insert(0, george3);
employees1.Add(mary3);
employees1.Add(bobJunior3);
employees1.Add(kevin3);
employees1.Add(kate3);
employees1.Add(kim3);

foreach (Employee employee in employees1)
{
    employee.DisplayEmployeeDetails();
}