using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace IEnumerable_IClonable
{
    class ClassRoom : IEnumerable, ICloneable
    {
        public string Name { get; set; }
        private int count;
        private Student[] _students;

        public ClassRoom(int size)
        {
            _students = new Student[size];
        }


        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return _students[i];               //yield - sozdaet enumerator         
            }   
                         
        }


        public void AddStudent(Student student)
        {
            _students[count] = student;
            count++;
        }


        public object Clone()
        {
            ClassRoom k = new ClassRoom(_students.Length);
            foreach (var student in this)
            {
                 k.AddStudent((Student)((Student)student).Clone());
            }
            k.Name = this.Name;
            return k;
        }


        object ICloneable.Clone()
        {
            return Clone();
        }
    }

    class Student : ICloneable
    {
        public int Id { get; set; }

        public object Clone()
        {
            Student student = new Student();
            student.Id = this.Id;
            return student;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom temp = new ClassRoom(3);
            Student one = new Student();
            one.Id = 1343;
            temp.AddStudent(one);
            Student two = new Student();
            two.Id = 4532;
            temp.AddStudent(two);
            Student free = new Student();
            free.Id = 6734;
            temp.AddStudent(free);
            foreach (var j in temp)
            {
                Console.WriteLine(((Student)j).Id);
            }
        }
    }
}
