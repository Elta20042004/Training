using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_Aviad
{
    public class EmployeeRepository
    {
        private readonly List<Employee> _people;
        private readonly List<Skills> _skills;

        public EmployeeRepository()
        {
            _people = new List<Employee>();
            _skills = new List<Skills>();
        }

        public void AddEmployee(Employee e)
        {
            _people.Add(e);
        }

        public void AddSkill(Skills s)
        {
            _skills.Add(s);
        }

        public void Delete(int id)
        {
            var e = _people
                .First(t => t.EmployeeId == id);

            _people.Remove(e);
        }

        public void Show(int id)
        {
            var e = _people
                .First(t => t.EmployeeId == id);

            Console.WriteLine(e.ToString());
        }

        public void Update(int id, Employee e)
        {
            Delete(id);
            AddEmployee(e);
        }

        public void ShowAll()
        {
            foreach (var people in _people)
            {
                Console.WriteLine(
                    "{0}, {1}, {2}, {3}, {4}",
                    people.EmployeeId,
                    people.LastName,
                    people.FirstName,
                    people.Alias,
                    people.Email);
            }
        }

        public void ShowEmployeeSkills(int id)
        {
            var k = _skills
                .Where(t => t.EmployeeId == id)
                .Distinct();
            foreach (var i in k)
            {
                Console.WriteLine(i.SkillName);
            }
        }

        public Employee Search(int id, string lname, string fname)
        {
            var k = _people
                .First(t => t.EmployeeId == id
                            && t.FirstName == fname
                            && t.LastName == lname);
            return k;
        }
    }
}