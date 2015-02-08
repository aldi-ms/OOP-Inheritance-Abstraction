using System.Collections.Generic;

namespace _04.CompanyHierarchy
{
    public interface IManager
    {
        List<IEmployee> EmployeeList { get; set; }
    }
}
