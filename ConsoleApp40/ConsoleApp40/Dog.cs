using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    public class Dog
    {
        private string color;
        private string breed;
        private int age;

        public Dog()
        {
            color = "red";
            breed = "German";
            age = 1;
        }

        public Dog(string cl, string br, int ag)
        {
            color = cl;
            breed = br;
            age = ag;
        }

        public void setColor(string cl)
        {
            color = cl;
        }

        public string getColor()
        {
            return color;
        }

        public void setBreed(string br)
        {
            breed = br;
        }

        public string getBreed()
        {
            return breed;
        }

        public void setAge(int ag)
        {
            age = ag;
        }

        public int getAge()
        {
            return age;
        }

    }
}
