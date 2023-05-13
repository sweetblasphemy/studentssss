using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace studentssss
{
    internal class student
    {

        public string name;
        public int age;
        public int id;
        public int grade_math;
        public int grade_eng;
        public int grade_lit;
        public int grade_IT;
        public int grade_bio;

        public student(string name, int age, int id, int grade_math, int grade_eng, int grade_lit, int grade_IT, int grade_bio)
        {

            this.name = name;
            this.age = age;
            this.id = id;
            this.grade_math = grade_math;
            this.grade_eng = grade_eng;
            this.grade_lit = grade_lit;
            this.grade_IT = grade_IT;
            this.grade_bio = grade_bio;

            

        }
        public void print ()
        {

            Console.WriteLine ("The student's name: " + name + ", age: " + age  + ", ID: " + id + ", math grade: " + grade_math + ", english grade: " + grade_eng + ", literature grade: " + grade_lit + ", IT grade: " + grade_IT + ", biology grade: " + grade_bio);

        }
        public void print1()
        {
            int av_result = (grade_math + grade_eng + grade_lit + grade_IT + grade_bio) / 5;
            Console.WriteLine (av_result);
        }
        public void print_maxGrade()
        {

            if (grade_math + grade_eng + grade_lit + grade_IT + grade_bio >> grade_math1 + grade_eng1 + grade_lit1 + grade_IT1 + grade_bio1)
            {
                Console.WriteLine("The student with the highest grade is: " + name);
            }

        }

    }
}
