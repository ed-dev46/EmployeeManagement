using SistemaGestãoFuncionarios;

Console.WriteLine("--EMPLOYEE MANAGEMENT--");
Console.WriteLine("1 . Register new employee\n" +
    "2 . List all employees\n" +
    "0 . Exit");

int userOption = userSelect();
List<Employee> employeesList = new List<Employee>();

while (userOption != 0)
{
    switch (userOption)
    {
        case 1:
            registerEmployee();
            userOption = userSelect();
            break;
        case 2:
            listAllEmployees();
            userOption = userSelect();
            break;
    }
}


int userSelect()
{
    int userOption = -1;
    while (userOption < 0 || userOption > 2)
    {
        try
        {
            Console.Write("\nSelecione uma opcao: ");
            userOption = Convert.ToInt32(Console.ReadLine());
            if (userOption < 0 || userOption > 2)
            {
                userOption = -1;
                throw new Exception();
            }
        }
        catch
        {
            Console.WriteLine("Opcao invalida!");
        }
    }
    return userOption;
}

void registerEmployee()
{
    Console.Write("\nEnter employee's name: ");
    string employeeName = Console.ReadLine()!;
    Console.Write("Enter employee's base salary: $");
    double baseSalary = Convert.ToDouble(Console.ReadLine());
    Console.Write("Select employee's role: \n" +
        "1 . Developer\n" +
        "2 . Manager\n");
    string role = "";
    role = Console.ReadLine()!;
    while (role != "1" && role != "2")
    {
        Console.WriteLine("Invalid role!");
        Console.Write("Select employee's role: \n" +
        "1 . Developer\n" +
        "2 . Manager\n");
        role = Console.ReadLine()!;
    }
    switch (role)
    {
        case "1":
            role = "Developer";
            Employee newDeveloper = new Developer(employeeName, baseSalary, role);
            employeesList.Add(newDeveloper);
            break;
        case "2":
            role = "Manager";
            Employee newManager = new Manager(employeeName, baseSalary, role);
            employeesList.Add(newManager);
            break;
    }
    Console.WriteLine("New employee registered");
}

void listAllEmployees()
{
    foreach (Employee employee in employeesList)
    {
        Console.WriteLine(employee);
    }
}