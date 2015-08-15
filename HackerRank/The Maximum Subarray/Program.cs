using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Maximum_Subarray
{
    class Student:ICloneable
    {
        private int ID { get; set; }

        public object Clone()
        {
            Student student = new Student();
            student.ID = this.ID;
            return student;
        }
    }

    class ClassRoom
    {
        private string Name { get; set; }

        private Student[] Arr;
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
