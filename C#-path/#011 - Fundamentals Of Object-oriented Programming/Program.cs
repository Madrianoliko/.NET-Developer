using _011___Fundamentals_Of_Object_oriented_Programming.HR;
using BethanysPieShopHRM.HR;

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
Manager mary = new("Mary", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30);
JuniorResearcher bobJunior = new("Bob", "Junior", "bob@snowball.be", new DateTime(1988, 1,23), 17);
Employee jake = new Employee("Jake", "Nicols", "jake@snowball.be", new DateTime(1995, 8, 16), 25, "New street", "123", "123456", "Pie Ville");

bethany.DisplayEmployeeDetails();
bethany.PerformWork(8);
bethany.PerformWork();
bethany.PerformWork(3);
bethany.ReceiveWage();

mary.DisplayEmployeeDetails();
mary.PerformWork(25);
mary.PerformWork();
mary.PerformWork();
mary.PerformWork();
mary.AttendManagementMeeting();

bobJunior.ResearchNewPieTaste(5);
bobJunior.ResearchNewPieTaste(5);

string streetName = jake.Address.Street;
Console.WriteLine($"{jake.FirstName} lives on {jake.Address.Street}");