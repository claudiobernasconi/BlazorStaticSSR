namespace BlazorSSR.Services;

public interface IEmployeeService
{
    Task<IList<Employee>> GetEmployees();
}

public record Employee(string Name, string Role, DateOnly StartingDay);
