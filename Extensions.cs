using MySql.Model;

namespace backend
{
    public static class Extensions
    {
        public static Employee EmployeeDto(this Employee emp)
        {
            return new Employee
            {
                _id = emp._id,
                employeeId = emp.employeeId,
                employeeName = emp.employeeName,
                DepartementName = emp.DepartementName,
                salary = emp.salary
            };
        }

    }
}