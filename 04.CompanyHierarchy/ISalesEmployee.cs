using System.Collections.Generic;

namespace _04.CompanyHierarchy
{
    public interface ISalesEmployee
    {
        List<ISales> SalesList { get; set; }
    }
}
