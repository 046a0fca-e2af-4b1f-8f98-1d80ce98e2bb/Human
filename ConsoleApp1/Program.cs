
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class Human
        {
            int age, weight, height;
            string name;
            bool male;

            public Human()
            {
                this.age = 0;
                this.weight = 0;
                this.height = 0;
                this.name = "no name";
                this.male = false;
            }

            public Human(int age, int weight, int height, string name, bool male)
            {
                this.age = age;
                this.weight = weight;
                this.height = height;
                this.name = name;
                this.male = male;
            }
            int getAge()
            {
                return age;
            }


        }

        static void Main(string[] args)
        {
            
        }
    }
}
