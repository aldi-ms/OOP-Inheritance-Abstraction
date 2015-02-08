using System;

namespace _04.CompanyHierarchy
{
    public interface IProject
    {
        string ProjectName { get; set; }
        string Details { get; set; }
        DateTime StartDate { get; }
        State State { get; }

        void CloseProject();
    }
}
