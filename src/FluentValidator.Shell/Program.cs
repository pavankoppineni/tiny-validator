using FluentValidator.Shell;

Console.WriteLine("Hello, World!");

var employee = new Employee();
employee.Age = 10;
employee.Name = "Pavan Kumar Koppineni";

var employeeRequestValidator = new EmployeeValidator();
var result = employeeRequestValidator.Validate(employee);
Console.WriteLine("Validation completed");