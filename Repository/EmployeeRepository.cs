using tut01.Data;
using tut01.Models;

namespace tut01.Interfaces
{
    public class EmployeeRepository : EFCoreRepository<Employee, DatabaseContext>
    {
        public EmployeeRepository(DatabaseContext context) : base(context) {}
    }
}