
using System;

namespace _01_sort_list_of_student
{
    class Student: IComparable
    {
        public int Grade { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name} is {Age} yers old, grade: {Grade}";
        }

        public int CompareTo(object obj)
        {
            return this.Age - (obj as Student).Age;
        }
    }
}
