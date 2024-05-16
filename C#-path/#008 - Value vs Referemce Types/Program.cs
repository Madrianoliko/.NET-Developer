using _008___Value_vs_Referemce_Types;

int a = 42;
int aCp = a;
aCp = 100;

Console.WriteLine($"a: {a} a copy:{aCp}");

Employee bethany = new("Bethany", "Smith", "bethany@gmail.com", new DateTime(1999, 1, 15), 25);
Employee testEmployee = bethany;
testEmployee.firstName = "Gill";

testEmployee.DisplayEmployeeDetails();
bethany.DisplayEmployeeDetails(); 

bethany.PerformWork(25);

int minimumBonus = 100;
int bonusTax = 0;

int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, ref bonusTax);

Console.WriteLine(receivedBonus);
Console.WriteLine(bonusTax);

