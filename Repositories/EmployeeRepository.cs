
using MongoDB.Bson;
using MongoDB.Driver;
using MySql.Model;
namespace backend.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private const string databaseName = "Test";
        private const string collectionName = "employee";
        private readonly IMongoCollection<Employee> employeesCollection;
        private readonly FilterDefinitionBuilder<Employee> filterBuilder = Builders<Employee>.Filter;
        public EmployeeRepository(IMongoClient mongoClient)
        {
            IMongoDatabase database = mongoClient.GetDatabase(databaseName);
            employeesCollection = database.GetCollection<Employee>(collectionName);
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            return await employeesCollection.Find(new BsonDocument()).ToListAsync();
        }
    }
}

