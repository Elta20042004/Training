using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_Aviad
{
    public class Skills  //navyki
    {
        public int SkillId { get; set; }
        public int EmployeeId { get; set; }
        public string SkillName { get; set; }
        public string BriefDescription { get; set; }

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
    }

    public class MyClass
    {
        public List<Employee> people;
        public List<Skills> skills;
        public MyClass()
        {
            people = new List<Employee>();
            skills = new List<Skills>();
        }






 


        public void A(Employee e) // A – Add new Employee
        {
            people.Add(e);
        }

        public void D(int id)    //  D – Delete Employee
        {
            var e = people
                .First(t => t.EmployeeId == id);

            people.Remove(e);
        }

        public void S(int id) // S – Show employee
        {
            var k = people
                .First(t => t.EmployeeId == id);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", k.EmployeeId, k.LastName, k.FirstName, k.Alias, k.Email);
        }

        public Employee U(int id) // U – Update Employee Details
        {
            var k = people
                .First(t => t.EmployeeId == id);
            return k;
        }

        public void SA() //v. SA – Show all employees
        {
            foreach (var i in people)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", i.EmployeeId, i.LastName, i.FirstName, i.Alias, i.Email);
            }
        }

        public void SEK(int id) // SEK – Show employee skills
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
        public void Search(int id, string lname, string fname)
        {
            var k = people
                .First(t => t.EmployeeId == id
                            && t.FirstName == fname
                            && t.LastName == lname);

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", k.EmployeeId, k.LastName, k.FirstName, k.Alias, k.Email);
        }

        public void Q() //viii. Q – quit the program
        {
            Environment.Exit(0);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> people = new List<Employee>();
            //List<Skills> skills = new List<Skills>();
            MyClass my = new MyClass();
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

            // Test
            my.A(new Employee(541, "Alex", "Cherny", "Tank", "tut.by"));
            my.D(2);
            my.S(3);

            Employee chel = my.U(4);
            chel.Email = "jjjjjjjjjjj@com";

            //my.SA();
            my.SEK(5);
            my.Search(10 ,"Christop", "Clifford");
            my.Q();


        }
    }
}
