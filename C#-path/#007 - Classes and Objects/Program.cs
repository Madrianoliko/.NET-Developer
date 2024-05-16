using _007___Classes_and_Objects;

Employee adrian = new ("Adrian", "Malik", "adrian@gmail.com", new DateTime(1997, 1, 10), 25);

adrian.DisplayEmployeeDetails();

adrian.PerformWork();
adrian.PerformWork();
adrian.PerformWork(5);
adrian.PerformWork();

adrian.firstName = "Tomasz";
adrian.hourlyRate = 10;
adrian.DisplayEmployeeDetails();

double receivedWageAdrian = adrian.ReceiveWage();
Console.WriteLine($"Wage paid: {receivedWageAdrian}");


Employee goerge = new("Grzegorz", "Baczek", "grzegorz@gmail.com", new DateTime(2001, 5, 25), 28);

goerge.DisplayEmployeeDetails();

goerge.PerformWork();
goerge.PerformWork();
goerge.PerformWork(3);
goerge.PerformWork();
goerge.PerformWork(8);

double receivedWageGeorge = goerge.ReceiveWage();
Console.WriteLine($"Wage paid: {receivedWageGeorge}");