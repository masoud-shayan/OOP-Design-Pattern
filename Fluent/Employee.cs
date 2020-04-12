namespace Fluent
{
    public class Employee : IEmployee
    {

        public string Details { get; set; }

        public IEmployee NameOfTheEmployee(string fullName)
        {
            this.Details += $"the Employee's name is : {fullName}\n";
            return this;
        }

        public IEmployee Born(string dateOfBirth)
        {
            this.Details += $"the Employee's dateOfBirth is : {dateOfBirth}\n";
            return this;
        }

        public IEmployee WorkingOn(string department)
        {
            this.Details += $"the Employee's department is : {department}\n";
            return this;
        }

        public IEmployee StaysAt(string address)
        {
            this.Details += $"the Employee's address is : {address}\n";
            return this;
        }
    }
}