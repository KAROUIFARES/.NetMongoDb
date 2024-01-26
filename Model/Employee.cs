using MongoDB.Bson;

namespace MySql.Model
{
    public class Employee
    {
        public ObjectId _id { get; init; }
        public int employeeId { get; set; }
        public string? employeeName { get; set; }
        public string? DepartementName { get; set; }
        public decimal salary { get; set; }
    }
}