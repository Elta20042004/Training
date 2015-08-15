using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class PersonEmployee : Person
        {
        public PersonEmployee(int pE_Age, string pN_Name) : base(pE_Age, pN_Name) { }
        }

    public class PersonStudent : Person
    {
        public PersonStudent(int pS_Age, string pS_Name) : base(pS_Age, pS_Name) { }
    }

    public class MyGenericPerson<T> : IEnumerable where T :Person
    {
        private List<T> MyList = new List<T>();

        public T GetPerson(int position)
        {
            return MyList[position];
        }

        public void AddPerson(T person)
        {
            MyList.Add(person);
        }

        public void ClearPerson()
        {
            MyList.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            return MyList.GetEnumerator();
        }

       
    }

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person(int _Age, string _Name)
        {
            this.Age = _Age;
            this.Name = _Name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyGenericPerson<Person> MyPerson = new MyGenericPerson<Person>();
            MyPerson.AddPerson(new Person(14, "Tom"));
            MyPerson.AddPerson(new Person(16, "Timmer"));
            MyPerson.AddPerson(new Person(25, "Lyuis"));

            MyPerson.AddPerson(new PersonStudent(32, "Bill"));

            foreach (var p in MyPerson)
            {
            
            }
        }
    }
}
