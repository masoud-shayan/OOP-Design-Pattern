using System;

namespace Fluent
{
    public interface IEmployee
    {
        string Details { get; set; }
        
        IEmployee NameOfTheEmployee(string fullName);
        IEmployee Born(string dateOfBirth);
        IEmployee WorkingOn(string department);
        IEmployee  StaysAt(string address);
    }
}