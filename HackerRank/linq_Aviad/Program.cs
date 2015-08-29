using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_Aviad
{
    public class Skills  //navyki
    {
        private int SkillId { get; set; }
        public int EmployeeId { get; private set; }
        public string SkillName { get; private set; }
        private string BriefDescription { get; set; }

        public Skills(int employeeId, int skillId, string skillName, string briefDescription)
        {
            EmployeeId = employeeId;
            SkillId = skillId;
            SkillName = skillName;
            BriefDescription = briefDescription;
        }
    }

    public class Employee  //sotrudnik
    {
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Alias { get; set; }
        public string Email { get; set; }

        public Employee(int employeeId, string lastName, string firstName, string alias, string email)
        {
            EmployeeId = employeeId;
            LastName = lastName;
            FirstName = firstName;
            Alias = alias;
            Email = email;
        }

        public override string ToString()
        {
            return String.Format("Id: {0}, Name:{1}, Family:{2}, Alias:{3}, email:{4}", EmployeeId, LastName, FirstName, Alias, Email);
        }
    }

    public class EmployeeRepository
    {
        public List<Employee> people;
        public List<Skills> skills;

        public EmployeeRepository()
        {
            people = new List<Employee>();
            skills = new List<Skills>();
        }

        public void Add(Employee e) // A – Add new Employee
        {
            people.Add(e);
        }

        public void Delete(int id)    //  D – Delete Employee
        {
            var e = people
                .First(t => t.EmployeeId == id);

            people.Remove(e);
        }

        public void Show(int id) // S – Show employee
        {
            var k = people
                .First(t => t.EmployeeId == id);
            Console.WriteLine(k.ToString());
        }

        public void Update(int id, Employee e) // U – Update Employee Details
        {
            Delete(id);
            Add(e);
        }

        public void ShowAll() //v. SA – Show all employees
        {
            foreach (var i in people)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", i.EmployeeId, i.LastName, i.FirstName, i.Alias, i.Email);
            }
        }

        public void ShoeEmployeeSkills(int id) // SEK – Show employee skills
        {
            var k = skills
                .Where(t => t.EmployeeId == id)
                .Distinct();
            foreach (var i in k)
            {
                Console.WriteLine(i.SkillName);
            }
        }
        // Search – search for employee based on employeeId, name, lastName
        public Employee Search(int id, string lname, string fname)
        {
            var k = people
                .First(t => t.EmployeeId == id
                            && t.FirstName == fname
                            && t.LastName == lname);
            return k;
        }

        public void Quit() //viii. Q – quit the program
        {
            Environment.Exit(0);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            EmployeeRepository my = new EmployeeRepository();
            string[] k = Console.ReadLine().Split(' ');
            int m = int.Parse(k[0]);
            int n = int.Parse(k[1]);
            for (int i = 0; i < m; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                int id = int.Parse(str[0]);
                Employee onePeople = new Employee(id, str[1], str[2], str[3], str[4]);
                my.people.Add(onePeople);
            }
            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                int idPeople = int.Parse(str[0]);
                int idSkills = int.Parse(str[1]);
                Skills oneSkill = new Skills(idPeople, idSkills, str[2], str[3]);
                my.skills.Add(oneSkill);
            }

            Console.WriteLine("A – Add new Employee"
                              + "\r\n" + "D – Delete Employee"
                              + "\r\n" + "S – Show employee"
                              + "\r\n" + "U – Update Employee Details"
                              + "\r\n" + "SA – Show all employees"
                              + "\r\n" + "SEK – Show employee skills"
                              + "\r\n" + "Search – search for employee based on employeeId, name, lastName"
                              + "\r\n" + "Q – quit the program");


            string test = Console.ReadLine().ToLower();
            switch (test)
            {
                case "a":
                    {
                        Console.WriteLine("Enter the details of a new employee through a gap:"
                         + "\r\n" + "1. id;"
                         + "\r\n" + "2. name;"
                         + "\r\n" + "3. family name;"
                         + "\r\n" + "4. alias;"
                         + "\r\n" + "5. email."
                         + "\r\n" + "For example: 32735 Elena Cherny Programmer Elta20042004@gmail.com");
                        string[] myEmployee = Console.ReadLine().Split(' ');
                        int myEmployeeId = int.Parse(myEmployee[0]);
                        Employee e = new Employee(myEmployeeId, myEmployee[1], myEmployee[2], myEmployee[3], myEmployee[4]);
                        my.Add(e);
                        break;
                    }
                case "d":
                    {
                        Console.WriteLine("Enter id employees who want to remove.");
                        int id = int.Parse(Console.ReadLine());
                        my.Delete(id);
                        break;
                    }
                case "s":
                    {
                        Console.WriteLine("Enter id employee whose data you want to see.");
                        //int id = int.Parse(Console.ReadLine());
                        int id = 5;
                        my.Show(id);
                        break;
                    }
                case "u":
                    {
                        Console.WriteLine("Enter the details of a employee through a gap:"
                                          + "\r\n" + "1. id;"
                                          + "\r\n" + "2. name;"
                                          + "\r\n" + "3. family name;"
                                          + "\r\n" + "4. alias;"
                                          + "\r\n" + "5. email."
                                          + "\r\n" + "For example: 32735 Elena Cherny Programmer Elta20042004@gmail.com");
                        string[] myEmployee = Console.ReadLine().Split(' ');
                        int myEmployeeId = int.Parse(myEmployee[0]);
                        Employee e = new Employee(myEmployeeId, myEmployee[1], myEmployee[2], myEmployee[3], myEmployee[4]);
                        my.Update(myEmployeeId, e);
                        break;
                    }
                case "sa":
                    {
                        my.ShowAll();
                        break;
                    }
                case "sek":
                    {
                        Console.WriteLine("Enter id employee whose skells you want to see.");
                        int id = int.Parse(Console.ReadLine());
                        my.ShoeEmployeeSkills(id);
                        break;
                    }
                case "search":
                    {
                        Console.WriteLine("Enter id, name and family name employee through a gap.");
                        string[] myEmployee = Console.ReadLine().Split(' ');
                        int id = int.Parse(myEmployee[0]);
                        Employee soughtFor = my.Search(id, myEmployee[1], myEmployee[2]);
                        Console.WriteLine(soughtFor.ToString());
                        break;
                    }
                case "q":
                    {
                        my.Quit();
                        break;
                    }
                default:
                {
                    Console.WriteLine("Error...");
                    break;                   
                }
            }
        }
    }
}
