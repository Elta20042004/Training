namespace linq_Aviad
{
    public class Employee
    {
        public Employee(int employeeId, string lastName, string firstName, string alias, string email)
        {
            EmployeeId = employeeId;
            LastName = lastName;
            FirstName = firstName;
            Alias = alias;
            Email = email;
        }

        public int EmployeeId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Alias { get; set; }

        public string Email { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Id: {0}, Name:{1}, Family:{2}, Alias:{3}, email:{4}",
                EmployeeId,
                LastName,
                FirstName,
                Alias,
                Email);
        }
    }
}