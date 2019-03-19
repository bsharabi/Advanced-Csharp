using System;
using System.Collections.Generic;
using System.Text;

namespace lambda_list
{
    class Student
    {
        private int greade;

        public int Greade
        {
            get { return greade; }
            set {
                if(value>=0 && value<=100)
                     greade = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18 && value <= 120)
                    age = value;
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string GetInfo()
        {
            return $"The name is :{name}\nAge is:{age}\nGread :{greade}\n";
        }

        public Student(int greade, int age, string name)
        {
            this.Name = name;
            this.Age = age;
            this.Greade = greade;
        }

        public Student()
        {

        }
    }
}
