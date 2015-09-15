using System;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace linq_Aviad
{
    class Program
    {
        static void Main(string[] args)
        {
            var my = new EmployeeRepository();
            string[] k = Console.ReadLine().Split(' ');
            int m = int.Parse(k[0]);
            int n = int.Parse(k[1]);
            for (int i = 0; i < m; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                int id = int.Parse(str[0]);
                var onePeople = new Employee(id, str[1], str[2], str[3], str[4]);
                my.AddEmployee(onePeople);
            }

            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                int idPeople = int.Parse(str[0]);
                int idSkills = int.Parse(str[1]);
                var oneSkill = new Skills(idPeople, idSkills, str[2], str[3]);
                my.AddSkill(oneSkill);
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
                        my.AddEmployee(e);
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
                        int id = int.Parse(Console.ReadLine());
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
                        var e = new Employee(myEmployeeId, myEmployee[1], myEmployee[2], myEmployee[3], myEmployee[4]);
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
                        my.ShowEmployeeSkills(id);
                        break;
                    }
                case "search":
                    {
                        Console.WriteLine("Enter id, name and family name employee through a gap.");
                        string[] myEmployee = Console.ReadLine().Split(' ');
                        int id = int.Parse(myEmployee[0]);
                        Employee found = my.Search(id, myEmployee[1], myEmployee[2]);
                        Console.WriteLine(found.ToString());
                        break;
                    }
                case "q":
                    {
                        Environment.Exit(0);
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
