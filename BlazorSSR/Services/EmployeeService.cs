namespace BlazorSSR.Services;

public class EmployeeService : IEmployeeService
{
    public async Task<IList<Employee>> GetEmployees()
    {
        var employees = new List<Employee>
        {
            new Employee("Norbert Hugh", "CEO", new DateOnly(2022, 8, 1)),
            new Employee("Sonia Balmer", "Head of HR", new DateOnly(2022, 8, 1)),
            new Employee("Peter Jackson", "HR Assistant", new DateOnly(2023, 7, 16)),
            new Employee("Quincy Rover", "Head of Marketing", new DateOnly(2020, 1, 1)),
            new Employee("John Doe", "Software Developer", new DateOnly(2020, 2, 1)),
            new Employee("Sabrina Walsh", "Software Developer", new DateOnly(2020, 1, 1))
        };

        await Task.Delay(2000);

        return employees;
    }
}
