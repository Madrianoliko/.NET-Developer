using _008___Value_vs_Referemce_Types;
using System.Text;

int a = 42;
int aCp = a;
aCp = 100;

Console.WriteLine($"a: {a} a copy:{aCp}");

Employee bethany = new("Bethany", "Smith", "bethany@gmail.com", new DateTime(1999, 1, 15), 25, EmployeeType.Manager);
Employee testEmployee = bethany;
testEmployee.firstName = "Gill";

testEmployee.DisplayEmployeeDetails();
bethany.DisplayEmployeeDetails(); 

bethany.PerformWork(25);

int minimumBonus = 100;

int bonusTax = 0;

int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, ref bonusTax);

int bonusTaxWithOut;
int receivedBonusWithOut = bethany.CalculateBonusAndBonusTaxWithOut(minimumBonus, out bonusTaxWithOut);

string name = "bethany";
string anotherName = name;

name += " smith";


Console.WriteLine($"Name: { name }");
Console.WriteLine($"AnotherName: {anotherName}");

string firstName = "bethany";
string lastName = "smith";

StringBuilder builder =  new StringBuilder();
builder.Append("Last name: ");
builder.AppendLine(lastName);
builder.Append("First name: ");
builder.AppendLine(firstName);

string result = builder.ToString();

string indexes = String.Empty;
for (int i = 0; i < 2500; i++)
{
    indexes += i.ToString();
}

// ^^ 2500 variables, a lot of cost of memory

// \/ use String Builder is more optimal - it doesn't create 2500 variables
StringBuilder builder2 = new StringBuilder();
for (int i = 0; i < 2500; i++)
{
    builder2.Append(i);
    builder2.Append(" ");
}
string list = builder2.ToString();

string bethanyAsJson = bethany.ConvertToJson();
Console.WriteLine(bethanyAsJson);

WorkTask task;
task.description = "Bake delicious pies";
task.hours = 3;
task.PerformWorkTask();
