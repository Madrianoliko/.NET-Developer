

using _009___Classes_and_Custom_Types.Accounting;
using _009___Classes_and_Custom_Types.HR;

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);

Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);


bethany.DisplayEmployeeDetails();

bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();

double receivedWageBethany = bethany.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from Program): {receivedWageBethany}");

//bethany.firstName = "John";
//bethany.hourlyRate = 10;

bethany.DisplayEmployeeDetails();
bethany.PerformWork();
bethany.PerformWork(12);
bethany.PerformWork();
bethany.ReceiveWage();


Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

george.DisplayEmployeeDetails();
george.PerformWork();
george.PerformWork();
george.PerformWork(3);
george.PerformWork();
george.PerformWork(8);

var receivedWageGeorge = george.ReceiveWage(true);


//int a = 42;
//int aCopy = a;
//aCopy = 100;
//Console.WriteLine($"Value of a: {a} and value of copy of a: {aCopy}");

//Employee testEmployee = bethany;
//testEmployee.firstName = "Gill";

//testEmployee.DisplayEmployeeDetails();
//bethany.DisplayEmployeeDetails();

//bethany.PerformWork(25);

//int minimumBonus = 100;
//int receivedBonus = bethany.CalculateBonus(minimumBonus);
//Console.WriteLine($"The minimum bonus is {minimumBonus} and {bethany.firstName} has received a bonus of {receivedBonus}");


//int minimumBonus = 100;
//int bonusTax = 0;
//int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, ref bonusTax);
//Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {bethany.firstName} has received a bonus of {receivedBonus }");

int minimumBonus = 100;
int bonusTax;
int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, out bonusTax);
Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {bethany.firstName} has received a bonus of {receivedBonus }");


WorkTask task;
task.description = "Bake delicious pies";
task.hours = 3;
task.PerformWorkTask();

Customer customer = new Customer();

TestOkocimek okocim1 = new TestOkocimek();
TestOkocimek okocim2 = new TestOkocimek();

okocim1.MyProperty2 = 3;
okocim2.MyProperty2 = 5;

TestOkocimek.MyProperty = 5;

Console.WriteLine("Poprawnie logowanie do konsoli albo np. grafany: {0}", okocim1.Teest());
Console.WriteLine($"{okocim2.Teest()}");

#region First run Bethany
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();
bethany.ReceiveWage();
bethany.DisplayEmployeeDetails();
#endregion

#region First run George
bethany.PerformWork(10);
bethany.PerformWork();
bethany.PerformWork();
bethany.ReceiveWage();
bethany.DisplayEmployeeDetails();
#endregion

Employee.taxRate = 0.02;

#region Second run Bethany
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();
bethany.ReceiveWage();
bethany.DisplayEmployeeDetails();
#endregion

#region Second run George
bethany.PerformWork(10);
bethany.PerformWork();
bethany.PerformWork();
bethany.ReceiveWage();
bethany.DisplayEmployeeDetails();
#endregion

Employee.DisplayTaxRate();

//Employee mysteryEmploye = null;
//mysteryEmploye.DisplayEmployeeDetails();

List<Employee> employees = new List<Employee>();
//for (int i = 0; i < 10000000; i++)
//{
//    Employee randomEmployee = new Employee(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), new DateTime(1979, 1, 16), null,
//        EmployeeType.StoreManager);
//    employees.Add(randomEmployee);
//}

GC.Collect();

employees.Clear();
employees = null;

bethany.CalculteWage();

Account account = new Account("1234567890");
//account.AccountNumber = "5"; -- error because record is immutable